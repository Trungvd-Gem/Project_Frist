﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Project_Frist.Data.Entities;
using Project_Frist.Data.Configurations;

namespace Project_Frist.Data.EF
{
    public class Project_FristDbContext : DbContext
    {
        public Project_FristDbContext( DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            /*base.OnModelCreating(modelBuilder);*/
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Category> AppConfigs { get; set; }

        public DbSet<Category> Carts { get; set; }

        public DbSet<Category> CategoryTranslations { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<ProductTranslation> ProductTranslations { get; set; }

        public DbSet<Promotion> Promotions { get; set; }


        public DbSet<Transaction> Transactions { get; set; }


    }
}
