using System.Collections.Generic;
using WebStore.Domain.Entityes.Base.Interfaces;

namespace WebStore.ViewModels
{
    public class CategoryViewModel : INamedEntity, IOrderedEntity
    {
        public string Name { get ; set; }
        public int Id { get ; set; }
        public int Order { get ; set; }
        public List<CategoryViewModel> ChildCategories { get; set; } = new();
        public CategoryViewModel ParentCategory { get; set; }

        public int ProductsCount { get; set; }
    }
}
