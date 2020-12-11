using WebStore.Domain.Entityes;
using System.Collections.Generic;


namespace WebStore.Infrastructure.Interfaces
{
    public interface IProductsData
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Brand> GetBrands();
    }
}
