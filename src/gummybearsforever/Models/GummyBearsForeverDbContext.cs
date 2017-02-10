using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;


namespace GummyBearsForever.Models
{
    public class GummyBearsForeverDbContext : DbContext
    {
        public virtual DbSet<Inventory> Inventories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummyBearsForever;integrated security=True");
        }

        public GummyBearsForeverDbContext(DbContextOptions<GummyBearsForeverDbContext> options) : base(options)
        {
        }

        public GummyBearsForeverDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
