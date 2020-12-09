using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;
using System.Linq;
using WebStore.Infrastructure.Services;
using WebStore.Infrastructure.Interfaces;


namespace WebStore.Controllers
{
    public class WorkerController : Controller
    {
        private readonly IWorkersData _Workers;
        public WorkerController(IWorkersData Workers) => _Workers = Workers;
        public IActionResult Index()
        {
            var workers = _Workers.Get();
            return View(workers);
        }

        public IActionResult AdditionalInformation(int id)
        {
            var employee = _Workers.Get(id);
            if(employee is not null)
                return View(employee);

            return NotFound();
        }


}
}
