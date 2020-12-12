using WebStore.Domain.Entityes;
using System.Collections.Generic;
using WebStore.Domain;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IProductsData
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter Filter = null);
    }
}
