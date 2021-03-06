﻿using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entityes;

namespace WebStore.DAL.Context
{
    public class WebStoreDB : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        public WebStoreDB(DbContextOptions<WebStoreDB> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
        }
    }
}