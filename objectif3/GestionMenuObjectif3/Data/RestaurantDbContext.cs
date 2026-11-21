using GestionMenusRecettes.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionMenusRecettes.Data;

/// <summary>
/// Le DbContext est le « pont » entre les classes C# et la base SQLite :
/// chaque DbSet correspond à une table, et SaveChanges() envoie les modifications à la base.
/// </summary>
public class RestaurantDbContext : DbContext
{
    public DbSet<Restaurant> Restaurants => Set<Restaurant>();
    public DbSet<Fournisseur> Fournisseurs => Set<Fournisseur>();
    public DbSet<Ingredient> Ingredients => Set<Ingredient>();
    public DbSet<Recette> Recettes => Set<Recette>();
    public DbSet<LigneRecette> LignesRecette => Set<LigneRecette>();
    public DbSet<Plat> Plats => Set<Plat>();
    public DbSet<Menu> Menus => Set<Menu>();

    /// <summary>
    /// Le fichier gestion_menus.db est placé à la racine du projet (à côté du .csproj)
    /// pour pouvoir être versionné sur GitHub avec le code.
    /// </summary>
    public static string CheminBase()
    {
        var dossier = new DirectoryInfo(AppContext.BaseDirectory);
        while (dossier is not null && dossier.GetFiles("*.csproj").Length == 0)
            dossier = dossier.Parent;

        string racine = dossier?.FullName ?? AppContext.BaseDirectory;
        return Path.Combine(racine, "gestion_menus.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
            options.UseSqlite($"Data Source={CheminBase()}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Charge toutes les classes IEntityTypeConfiguration<T> (voir Configurations.cs)
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RestaurantDbContext).Assembly);
    }
}
