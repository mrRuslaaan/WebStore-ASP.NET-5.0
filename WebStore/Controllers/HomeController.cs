using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers

{
    public class HomeController : Controller
    {
        private readonly IConfiguration _Configuration;

        private static readonly List<Worker> __Workers = new()
        {
            new Worker { Id = 1, LastName = "Пушкин", FirstName = "Александр", Patronymic = "Сергеевич", Age = 22, Position = "junior developer" },
            new Worker { Id = 2, LastName = "Достоевский", FirstName = "Фёдор", Patronymic = "Михайлович", Age = 39, Position = "designer" },
            new Worker { Id = 3, LastName = "Толстой", FirstName = "Лев", Patronymic = "Николаевич", Age = 45, Position = "senior developer"},
        };

        public HomeController(IConfiguration Configiration) => _Configuration = Configiration; 
        
        public IActionResult Index() => View();       
        public IActionResult Workers() => View(__Workers);
    
        public IActionResult Error404() => View();
        public IActionResult Blogs() => View();
        public IActionResult BlogSingle() => View();
        public IActionResult Cart() => View();
        public IActionResult Checkout() => View();
        public IActionResult ContactUs() => View();
        public IActionResult Login() => View();
        public IActionResult ProductDetails() => View();
        public IActionResult Shop() => View();

    }
}
