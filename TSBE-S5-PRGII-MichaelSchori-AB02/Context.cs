using Microsoft.EntityFrameworkCore;

namespace TSBE_S5_PRGII_MichaelSchori_AB02;

public class Context : DbContext
{
    public DbSet<Kunde> Kunden { get; set; }
    public DbSet<Lieferkosten> Lieferkosten { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=tsbe_s5_pgr2_ab02;Username=postgres;Password=admin");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kunde>().HasKey(k => k.ID);
        modelBuilder.Entity<Lieferkosten>().HasKey(l => l.ID);

        modelBuilder.Entity<Kunde>().HasOne(k => k.Lieferkosten)
            .WithMany(l => l.Kunden)
            .HasForeignKey(k => k.LieferkostenID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}