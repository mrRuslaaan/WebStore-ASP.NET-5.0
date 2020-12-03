using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;
using System.Linq;


namespace WebStore.Controllers
{
    public class WorkerController : Controller
    {
        private static readonly List<Worker> __Workers = new()
        {
            new Worker { Id = 1, LastName = "Пушкин", FirstName = "Александр", Patronymic = "Сергеевич", Age = 22, Position = "junior developer" },
            new Worker { Id = 2, LastName = "Достоевский", FirstName = "Фёдор", Patronymic = "Михайлович", Age = 39, Position = "designer" },
            new Worker { Id = 3, LastName = "Толстой", FirstName = "Лев", Patronymic = "Николаевич", Age = 45, Position = "senior developer" },
        };
        public IActionResult Index => View(__Workers);

        public IActionResult AdditionalInformation(int id)
        {
            var employee = __Workers.FirstOrDefault(w => w.Id == id);
            if(employee is not null)
                return View(employee);

            return NotFound();
        }


}
}
