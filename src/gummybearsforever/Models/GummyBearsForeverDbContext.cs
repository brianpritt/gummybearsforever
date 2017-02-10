using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;


namespace GummyBearsForever.Models
{
    public class GummyBearsForeverDbContext : DbContext
    {
        public virtual DbSet<Inventory> Inventtories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummyBearsForever;integrated security=True");
        }

        public GummyBearsForeverDbContext(DbContextOptions<GummyBearsForeverDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
