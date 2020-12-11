using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;
using System.Linq;
using WebStore.Infrastructure.Services;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;
using System;


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

        public IActionResult Edit(int id)
        {
            if (id < 0)
                return BadRequest();

            var worker = _Workers.Get(id);
            if (worker is null)
                return NotFound();

            return View(new WorkerViewModel
            {
                Id = worker.Id,
                LastName = worker.LastName,
                FirstName = worker.FirstName,
                Patronymic = worker.Patronymic,
                Age = worker.Age,
                Position = worker.Position,
            });
        }

        public IActionResult EditComplete (WorkerViewModel Model)
        {
            if (!ModelState.IsValid)
                return View(Model);

            if (Model is null)
                throw new ArgumentNullException(nameof(Model));

            var worker = new Worker
            {
                Id = Model.Id,
                LastName = Model.LastName,
                FirstName = Model.FirstName,
                Patronymic = Model.Patronymic,
                Age = Model.Age,
                Position = Model.Position,
            };

            _Workers.Update(worker);

            return RedirectToAction("Index");
        }

        public IActionResult Create(WorkerViewModel Model)
        {
            if (!ModelState.IsValid)
                return View(Model);

            if (Model is null)
                 throw new ArgumentNullException(nameof(Model));

            if (Model.LastName is not null)
            {
                var worker = new Worker
                {
                    LastName = Model.LastName,
                    FirstName = Model.FirstName,
                    Patronymic = Model.Patronymic,
                    Age = Model.Age,
                    Position = Model.Position,
                };

                _Workers.Add(worker);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _Workers.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
