using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain;
using WebStore.Domain.Entityes;
using WebStore.Infrastructure.Interfaces;
using WebStore.Data;

namespace WebStore.Infrastructure.Services.InMemory
{
    public class ProductsDataService : IProductsData
    {
        private static IEnumerable<Category> __Categories = TestData.Categories;

        private static IEnumerable<Brand> __Brands = TestData.Brands;

        public static IEnumerable<Product> __Products = TestData.Products;
        public IEnumerable<Brand> GetBrands() => __Brands;

        public IEnumerable<Category> GetCategories() => __Categories;
        public IEnumerable<Product> GetProducts(ProductFilter Filter = null)
        {
            var query = __Products;

            if (Filter?.CategoryId != null) 
                query = query.Where(product => product.CategoryId == Filter.CategoryId);

            if (Filter?.BrandId != null)
                query = query.Where(product => product.BrandId == Filter.BrandId);

            return query;
        }
    }
}
