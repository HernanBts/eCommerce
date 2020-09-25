using eCommerce.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>()
                .HasIndex(i => i.Name)
                .IsUnique();

            modelBuilder.Entity<Country>()
                .HasIndex(i => i.Name)
                .IsUnique();

            modelBuilder.Entity<Department>()
                .HasIndex(i => i.Name)
                .IsUnique();
        }
    }
}
