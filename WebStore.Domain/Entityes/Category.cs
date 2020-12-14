using WebStore.Domain.Entityes.Base;
using WebStore.Domain.Entityes.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebStore.Domain.Entityes
{
    public class Category : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public Category Parent { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}