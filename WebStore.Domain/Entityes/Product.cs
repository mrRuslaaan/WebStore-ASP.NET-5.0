using WebStore.Domain.Entityes.Base;
using WebStore.Domain.Entityes.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Domain.Entityes
{
    public class Product : NamedEntity
    {
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public string ImageUrl { get; set; }
        public int? BrandId { get; set; }

        [ForeignKey(nameof(BrandId))]
        public Brand Brand { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }


    }
}