﻿using eCommerce.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
                .HasIndex(i => i.Name)
                .IsUnique();
        }
    }
}
