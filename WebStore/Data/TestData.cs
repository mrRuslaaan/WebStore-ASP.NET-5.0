using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain;
using WebStore.Domain.Entityes;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Data
{
    public static class TestData
    {
        public static List<Worker> Workers { get; } = new()
        {
            new Worker { Id = 1, LastName = "Пушкин", FirstName = "Александр", Patronymic = "Сергеевич", Age = 22, Position = "junior developer" },
            new Worker { Id = 2, LastName = "Достоевский", FirstName = "Фёдор", Patronymic = "Михайлович", Age = 39, Position = "designer" },
            new Worker { Id = 3, LastName = "Толстой", FirstName = "Лев", Patronymic = "Николаевич", Age = 45, Position = "senior developer" },
        };

        public static IEnumerable<Category> Categories { get; } = new[]
       {
              new Category { Id = 1, Name = "Спорт", Order = 0 },
              new Category { Id = 2, Name = "Nike", Order = 0, ParentId = 1 },
              new Category { Id = 3, Name = "Under Armour", Order = 1, ParentId = 1 },
              new Category { Id = 4, Name = "Adidas", Order = 2, ParentId = 1 },
              new Category { Id = 5, Name = "Puma", Order = 3, ParentId = 1 },
              new Category { Id = 6, Name = "ASICS", Order = 4, ParentId = 1 },
              new Category { Id = 7, Name = "Для мужчин", Order = 1 },
              new Category { Id = 8, Name = "Fendi", Order = 0, ParentId = 7 },
              new Category { Id = 9, Name = "Guess", Order = 1, ParentId = 7 },
              new Category { Id = 10, Name = "Valentino", Order = 2, ParentId = 7 },
              new Category { Id = 11, Name = "Диор", Order = 3, ParentId = 7 },
              new Category { Id = 12, Name = "Версачи", Order = 4, ParentId = 7 },
              new Category { Id = 13, Name = "Армани", Order = 5, ParentId = 7 },
              new Category { Id = 14, Name = "Prada", Order = 6, ParentId = 7 },
              new Category { Id = 15, Name = "Дольче и Габбана", Order = 7, ParentId = 7 },
              new Category { Id = 16, Name = "Шанель", Order = 8, ParentId = 7 },
              new Category { Id = 17, Name = "Гуччи", Order = 9, ParentId = 7 },
              new Category { Id = 18, Name = "Для женщин", Order = 2 },
              new Category { Id = 19, Name = "Fendi", Order = 0, ParentId = 18 },
              new Category { Id = 20, Name = "Guess", Order = 1, ParentId = 18 },
              new Category { Id = 21, Name = "Valentino", Order = 2, ParentId = 18 },
              new Category { Id = 22, Name = "Dior", Order = 3, ParentId = 18 },
              new Category { Id = 23, Name = "Versace", Order = 4, ParentId = 18 },
              new Category { Id = 24, Name = "Для детей", Order = 3 },
              new Category { Id = 25, Name = "Мода", Order = 4 },
              new Category { Id = 26, Name = "Для дома", Order = 5 },
              new Category { Id = 27, Name = "Интерьер", Order = 6 },
              new Category { Id = 28, Name = "Одежда", Order = 7 },
              new Category { Id = 29, Name = "Сумки", Order = 8 },
              new Category { Id = 30, Name = "Обувь", Order = 9 },
        };

        public static IEnumerable<Brand> Brands { get; } = new[]
        {
            new Brand { Id = 1, Name = "Acne"  },
            new Brand { Id = 2, Name = "Grune Erde"},
            new Brand { Id = 3, Name = "Albiro"},
            new Brand { Id = 4, Name = "Ronhill" },
            new Brand { Id = 5, Name = "Oddmolly" },
            new Brand { Id = 6, Name = "Boudestijn"},
            new Brand { Id = 7, Name = "Rosch creative culture"},
        };

        public static IEnumerable<Product> Products { get; } = new[]
       {
            new Product { Id = 1, Name = "Белое платье", Price = 1025, ImageUrl = "product1.jpg", CategoryId = 2, BrandId = 1 },
            new Product { Id = 2, Name = "Розовое платье", Price = 1025, ImageUrl = "product2.jpg", CategoryId = 2, BrandId = 1 },
            new Product { Id = 3, Name = "Красное платье", Price = 1025, ImageUrl = "product3.jpg", CategoryId = 2, BrandId = 1 },
            new Product { Id = 4, Name = "Джинсы", Price = 1025, ImageUrl = "product4.jpg", CategoryId = 2, BrandId = 1 },
            new Product { Id = 5, Name = "Лёгкая майка", Price = 1025, ImageUrl = "product5.jpg", CategoryId = 2, BrandId = 2 },
            new Product { Id = 6, Name = "Лёгкое голубое поло", Price = 1025, ImageUrl = "product6.jpg", CategoryId = 2, BrandId = 1 },
            new Product { Id = 7, Name = "Платье белое", Price = 1025, ImageUrl = "product7.jpg", CategoryId = 2, BrandId = 1 },
            new Product { Id = 8, Name = "Костюм кролика", Price = 1025, ImageUrl = "product8.jpg", CategoryId = 25, BrandId = 1 },
            new Product { Id = 9, Name = "Красное китайское платье", Price = 1025, ImageUrl = "product9.jpg", CategoryId = 25, BrandId = 1 },
            new Product { Id = 10, Name = "Женские джинсы", Price = 1025, ImageUrl = "product10.jpg", CategoryId = 25, BrandId = 3 },
            new Product { Id = 11, Name = "Джинсы женские", Price = 1025, ImageUrl = "product11.jpg", CategoryId = 25, BrandId = 3 },
            new Product { Id = 12, Name = "Летний костюм", Price = 1025, ImageUrl = "product12.jpg", CategoryId = 25, BrandId = 3 },
        };
    }
}
