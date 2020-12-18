using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entityes;
using WebStore.Domain.Entityes.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebStore.DAL.Context
{
    public class WebStoreDB : IdentityDbContext<User, Role, string>
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