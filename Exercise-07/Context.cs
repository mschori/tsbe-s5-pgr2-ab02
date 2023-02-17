using Microsoft.EntityFrameworkCore;

namespace Exercise_07;

public class Context : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Permission> Permissions { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Database=tsbe_s5_pgr2_usermanagementapi;Username=postgres;Password=admin");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(u => u.Id);
        modelBuilder.Entity<Group>().HasKey(g => g.Id);
        modelBuilder.Entity<Permission>().HasKey(p => p.Id);

        modelBuilder.Entity<Group>()
            .HasMany(g => g.Users)
            .WithMany(u => u.Groups);
        modelBuilder.Entity<Group>()
            .HasMany(g => g.Permissions)
            .WithMany(p => p.Groups);
        modelBuilder.Entity<User>().HasMany(u => u.Permissions)
            .WithMany(p => p.Users);
    }
}