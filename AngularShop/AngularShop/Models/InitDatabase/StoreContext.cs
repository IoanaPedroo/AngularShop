using Microsoft.EntityFrameworkCore;

namespace AngularShop.Models.InitDatabase
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.Images).HasConversion(myValue => String.Join(",", myValue), dbValue => dbValue.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList());
        }
    }
}
