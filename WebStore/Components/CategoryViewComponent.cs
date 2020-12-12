using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly IProductsData _ProductsData;

        public CategoryViewComponent(IProductsData ProductsData) => _ProductsData = ProductsData;

        public IViewComponentResult Invoke()
        {
            var categories = _ProductsData.GetCategories().ToArray();

            var parent_categories = categories.Where(c => c.ParentId is null);

            var parent_categories_views = parent_categories
               .Select(c => new CategoryViewModel
               {
                   Id = c.Id,
                   Name = c.Name,
                   Order = c.Order,
               })
                .ToList();

            foreach (var parent_category in parent_categories_views)
            {
                var childs = categories.Where(c => c.ParentId == parent_category.Id);

                foreach (var child_category in childs)
                    parent_category.ChildCategories.Add(new CategoryViewModel
                    {
                        Id = child_category.Id,
                        Name = child_category.Name,
                        Order = child_category.Order,
                        ParentCategory = parent_category
                    });

                parent_category.ChildCategories.Sort((a, b) => Comparer<int>.Default.Compare(a.Order, b.Order));
            }

            parent_categories_views.Sort((a, b) => Comparer<int>.Default.Compare(a.Order, b.Order));

            return View(parent_categories_views);
        }
    }
}