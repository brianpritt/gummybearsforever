using Microsoft.EntityFrameworkCore;


namespace GummyBearsForeverWithMigrations.Models
{
    public class GummyBearsForever : DbContext
    {
        //public GummyBearsForeverContext()
        //{
        //}

        //public DbSet<Category> Categories { get; set; }

        //public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummyBearsForeverWithMigrations;integrated security=True");
        }

        //public GummyBearsForeverContext(DbContextOptions<GummyBearsForeverContext> options)
        //    : base(options)
        //{
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
