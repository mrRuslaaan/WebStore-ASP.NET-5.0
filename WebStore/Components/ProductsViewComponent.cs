using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;


namespace WebStore.Components
{
    public class ProductsViewComponent : ViewComponent
    {
        private readonly IProductsData _ProductsData;
        public ProductsViewComponent(IProductsData ProductsData) => _ProductsData = ProductsData;

        public IViewComponentResult Invoke() => View(GetProducts());

        private IEnumerable<ProductViewModel> GetProducts() =>
            _ProductsData.GetProducts()
                .Select(product => new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    ImageUrl = product.ImageUrl,
                    Price = product.Price,
                });

    }
}
