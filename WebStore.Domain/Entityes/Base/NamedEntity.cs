using WebStore.Domain.Entityes.Base.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Domain.Entityes.Base
{
    public abstract class NamedEntity : Entity, INamedEntity
    {
        [Required]
        public string Name { get; set; }
    }
}