using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;
using DB.Entities;

namespace DB;

public enum MigrationType
{
    DropAndCreate,
    CreateIfNotExist,
    Seed,
    Migrate

}
public interface IMigrateDbCtrl
{
    void MigrateDatabase(string? isMigrationType);
}
public class MigrateDbCtrl : IMigrateDbCtrl
{
    ILogger<IMigrateDbCtrl> _Logger;
    ApplicationDbContext _DBContext;
    public MigrateDbCtrl(ApplicationDbContext iDBContext,ILogger<MigrateDbCtrl> iLogger)
    {
        _DBContext = iDBContext;
        _Logger = iLogger;
    }
    private void EnsureMigrateInternal(MigrationType migrationType = MigrationType.DropAndCreate,CancellationToken token = default)
    {
        var fisDbExists = _DBContext.Database.CanConnect();

        switch (migrationType)
        {
            case MigrationType.DropAndCreate:
                DropDatabase();
                MigrateDatabase();
                //SeedDatabase();
                break;

            case MigrationType.CreateIfNotExist:
                MigrateDatabase();
                if (!fisDbExists)
                {
                    //SeedDatabase();
                }

                break;

            case MigrationType.Migrate:
                MigrateDatabase();
                break;

            case MigrationType.Seed:
                //SeedDatabase();
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(migrationType), migrationType, null);
        }
    }

    private void DropDatabase()
    {
        _Logger.LogInformation("Dropping existed database");
        _DBContext.Database.EnsureDeleted();
        _Logger.LogInformation("Dropped existed database");
    }

    private void MigrateDatabase()
    {
        _Logger.LogInformation("Start Migrating database to latest version");
        _DBContext.Database.Migrate();
        _Logger.LogInformation("Finish Migrated database to latest version");
    }

    public void MigrateDatabase(string? isMigrationType)
    {
        try
        {

            if (Enum.IsDefined(typeof(MigrationType), isMigrationType ?? ""))
            {
                EnsureMigrateInternal((MigrationType)Enum.Parse(typeof(MigrationType), isMigrationType ?? ""));
            }
            else
            {
                EnsureMigrateInternal(MigrationType.DropAndCreate);
            }
        }
        catch
        {
            // ignored
        }
    }
}
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = GetType().Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
    }
    
    public override int SaveChanges() => SaveChanges(acceptAllChangesOnSuccess: true);

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        SetAuditProperties();

        return base.SaveChanges(acceptAllChangesOnSuccess);
    }


    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        => await SaveChangesAsync(acceptAllChangesOnSuccess: true, cancellationToken);

    public override async Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default)
    {
        SetAuditProperties();

        return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    private void SetAuditProperties()
    {
        var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is IEntityBase)
            .Where(e =>
                e.State is EntityState.Added or EntityState.Modified);

        foreach (var entityEntry in entries)
        {
            var auditEntry = (IEntityBase)entityEntry.Entity;

            if (entityEntry.State == EntityState.Added)
            {
                auditEntry.Created = DateTime.UtcNow;
            }

            auditEntry.Updated = DateTime.UtcNow;
        }
    }
}