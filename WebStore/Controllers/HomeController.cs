using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebStore.Controllers

{
    public class HomeController : Controller
    {
        private readonly IConfiguration _Configuration;
        public HomeController(IConfiguration Configiration) => _Configuration = Configiration; 
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index_2()
        {
            return Content(_Configuration["TextForFirstControllerSecondAction"]);
        }
    }
}
