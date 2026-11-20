using GestionMenusRecettes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionMenusRecettes.Data;

// Configuration « Fluent API » : précise ce que les conventions d'EF Core ne devinent pas
// (longueurs, relations, comportement de suppression, enums stockés en texte...).

public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> b)
    {
        b.Property(r => r.Nom).IsRequired().HasMaxLength(100);

        // Relations 1 - * du diagramme de classes. La clé étrangère « RestaurantId » est créée
        // par EF Core dans chaque table (propriété « fantôme », absente des classes).
        b.HasMany(r => r.Fournisseurs).WithOne().HasForeignKey("RestaurantId").IsRequired().OnDelete(DeleteBehavior.Cascade);
        b.HasMany(r => r.Ingredients).WithOne().HasForeignKey("RestaurantId").IsRequired().OnDelete(DeleteBehavior.Cascade);
        b.HasMany(r => r.Recettes).WithOne().HasForeignKey("RestaurantId").IsRequired().OnDelete(DeleteBehavior.Cascade);
        b.HasMany(r => r.Plats).WithOne().HasForeignKey("RestaurantId").IsRequired().OnDelete(DeleteBehavior.Cascade);
        b.HasMany(r => r.Menus).WithOne().HasForeignKey("RestaurantId").IsRequired().OnDelete(DeleteBehavior.Cascade);
    }
}

public class FournisseurConfiguration : IEntityTypeConfiguration<Fournisseur>
{
    public void Configure(EntityTypeBuilder<Fournisseur> b)
    {
        b.Property(f => f.Nom).IsRequired().HasMaxLength(100);
        b.Property(f => f.Telephone).HasMaxLength(30);
    }
}

public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
{
    public void Configure(EntityTypeBuilder<Ingredient> b)
    {
        b.Property(i => i.Nom).IsRequired().HasMaxLength(100);
        b.Property(i => i.Unite).HasConversion<string>().HasMaxLength(20);

        // « est fourni par » : on ne supprime pas un fournisseur qui fournit encore des ingrédients
        b.HasOne(i => i.Fournisseur)
            .WithMany(f => f.Ingredients)
            .HasForeignKey(i => i.FournisseurId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class RecetteConfiguration : IEntityTypeConfiguration<Recette>
{
    public void Configure(EntityTypeBuilder<Recette> b)
    {
        b.Property(r => r.Nom).IsRequired().HasMaxLength(100);

        // « contient » : supprimer une recette supprime ses lignes
        b.HasMany(r => r.Lignes)
            .WithOne(l => l.Recette)
            .HasForeignKey(l => l.RecetteId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

public class LigneRecetteConfiguration : IEntityTypeConfiguration<LigneRecette>
{
    public void Configure(EntityTypeBuilder<LigneRecette> b)
    {
        // « utilise » : on ne peut pas supprimer un ingrédient utilisé dans une recette
        b.HasOne(l => l.Ingredient)
            .WithMany()
            .HasForeignKey(l => l.IngredientId)
            .OnDelete(DeleteBehavior.Restrict);

        // Un même ingrédient n'apparaît qu'une fois par recette
        b.HasIndex(l => new { l.RecetteId, l.IngredientId }).IsUnique();
    }
}

public class PlatConfiguration : IEntityTypeConfiguration<Plat>
{
    public void Configure(EntityTypeBuilder<Plat> b)
    {
        b.Property(p => p.Nom).IsRequired().HasMaxLength(100);
        b.Property(p => p.Categorie).HasConversion<string>().HasMaxLength(30);

        // « prépare selon » : un plat a une recette, une recette sert au plus un plat (0..1)
        b.HasOne(p => p.Recette)
            .WithOne()
            .HasForeignKey<Plat>(p => p.RecetteId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class MenuConfiguration : IEntityTypeConfiguration<Menu>
{
    public void Configure(EntityTypeBuilder<Menu> b)
    {
        b.Property(m => m.Nom).IsRequired().HasMaxLength(100);

        // « propose » : relation plusieurs-à-plusieurs, EF Core crée la table de jointure « MenuPlat »
        b.HasMany(m => m.Plats)
            .WithMany(p => p.Menus)
            .UsingEntity(j => j.ToTable("MenuPlat"));
    }
}
