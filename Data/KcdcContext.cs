using Microsoft.EntityFrameworkCore;

namespace Kcdc.Api.Data
{
  public class KcdcContext : DbContext
  {
    public KcdcContext(DbContextOptions<KcdcContext> options) : base(options)
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<Speaker> Speakers { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //quick and dirty takes care of my entities not all scenarios
        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            modelBuilder.Entity(entity.Name).ToTable(entity.ClrType.Name + "s");
        }
    }
  }
}