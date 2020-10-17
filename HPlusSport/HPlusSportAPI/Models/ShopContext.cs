﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSportAPI.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext>options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(c => c.Products);
            modelBuilder.Entity<Order>().HasMany(o => o.Products);
            modelBuilder.Entity<Order>().HasOne(o => o.User);
            modelBuilder.Entity<User>().HasMany(u => u.Orders).WithOne(o => o.User);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Catergorys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
