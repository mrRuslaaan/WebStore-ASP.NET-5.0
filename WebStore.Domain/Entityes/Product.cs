using WebStore.Domain.Entityes.Base;
using WebStore.Domain.Entityes.Base.Interfaces;

namespace WebStore.Domain.Entityes
{
    public class Product : NamedEntity
    {
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
        public int? BrandId { get; set; }
        public decimal Price { get; set; }


    }
}