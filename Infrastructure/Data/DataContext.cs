using System.Reflection;
using Core.Entities;
using Core.Entities._LookUps;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Asset> Assets { get; set; }
    public DbSet<AssetHistory> AssetHistories { get; set; }
    public DbSet<AssetMovement> AssetMovements { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<AuditRecord> AuditRecords { get; set; }
    public DbSet<BranchProject> BranchProjects { get; set; }
    public DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
    public DbSet<AssetBrand> AssetBrands { get; set; }
    public DbSet<AssetType> AssetTypes { get; set; }
    public DbSet<BinLocation> BinLocations { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Condition> Conditions { get; set; }
    public DbSet<Insurer> Insurers { get; set; }
    public DbSet<OwnershipCategory> OwnershipCategories { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<ServiceProvider> ServiceProviders { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
