using Microsoft.EntityFrameworkCore;
using TestTaskForm.Models;
namespace TestTaskForm.Db;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Dep> Deps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Person>()
            .HasOne(p => p.Status)
            .WithMany(s => s.Persons)
            .HasForeignKey(p => p.StatusId);

        modelBuilder.Entity<Person>()
            .HasOne(p => p.Dep)
            .WithMany(d => d.Persons)
            .HasForeignKey(p => p.DepId);

        modelBuilder.Entity<Person>()
            .HasOne(p => p.Post)
            .WithMany(ps => ps.Persons)
            .HasForeignKey(p => p.PostId);
    }

    public void Migrate()
    {
        
    }
}