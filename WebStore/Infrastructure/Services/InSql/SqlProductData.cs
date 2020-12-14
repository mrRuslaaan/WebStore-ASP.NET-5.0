using System.Collections.Generic;
using System.Linq;
using WebStore.DAL.Context;
using WebStore.Domain;
using WebStore.Domain.Entityes;
using WebStore.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace WebStore.Infrastructure.Services.InSql
{
    public class SqlProductData : IProductsData
    {
        private readonly WebStoreDB _db;

        public SqlProductData(WebStoreDB db) => _db = db;

        public IEnumerable<Category> GetCategories() => _db.Categories.Include(category => category.Products);

        public IEnumerable<Brand> GetBrands() => _db.Brands.Include(brand => brand.Products);

        public IEnumerable<Product> GetProducts(ProductFilter Filter = null)
        {
            IQueryable<Product> query = _db.Products;

            if (Filter?.BrandId != null)
                query = query.Where(product => product.BrandId == Filter.BrandId);

            if (Filter?.CategoryId != null)
                query = query.Where(product => product.CategoryId == Filter.CategoryId);

            return query;
        }
    }
}