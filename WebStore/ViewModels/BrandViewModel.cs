﻿using System.Collections.Generic;
using WebStore.Domain.Entityes.Base.Interfaces;

namespace WebStore.ViewModels
{
    public class BrandViewModel : INamedEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public int ProductsCount { get; set; }
    }
}
