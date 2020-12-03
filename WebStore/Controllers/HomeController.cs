using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers

{
    public class HomeController : Controller
    {
        private readonly IConfiguration _Configuration;

        public HomeController(IConfiguration Configiration) => _Configuration = Configiration; 
        
        public IActionResult Index() => View();       
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
