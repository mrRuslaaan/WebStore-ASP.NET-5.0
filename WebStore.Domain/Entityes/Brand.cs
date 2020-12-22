using WebStore.Domain.Entityes.Base;
using WebStore.Domain.Entityes.Base.Interfaces;
using System.Collections.Generic;

namespace WebStore.Domain.Entityes
{
    public class Brand : NamedEntity
    {
        public ICollection<Product> Products { get; set; }
    }
}