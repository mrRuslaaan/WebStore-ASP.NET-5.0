using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Components
{
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProductsData _ProductsData;
        public BrandsViewComponent(IProductsData ProductsData) => _ProductsData = ProductsData;

        public IViewComponentResult Invoke() => View(GetBrands());

        private IEnumerable<BrandViewModel> GetBrands() =>
            _ProductsData.GetBrands()
                .OrderBy(brand => brand.Order)
                .Select(brand => new BrandViewModel
                {
                    Id = brand.Id,
                    Name = brand.Name,
                });
    }
}
