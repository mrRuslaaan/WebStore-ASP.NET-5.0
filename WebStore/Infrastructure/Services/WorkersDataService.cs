using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Infrastructure.Services
{
    public class WorkersDataService : IWorkersData
    {
        private static readonly List<Worker> __Workers = new()
        {
            new Worker { Id = 1, LastName = "Пушкин", FirstName = "Александр", Patronymic = "Сергеевич", Age = 22, Position = "junior developer" },
            new Worker { Id = 2, LastName = "Достоевский", FirstName = "Фёдор", Patronymic = "Михайлович", Age = 39, Position = "designer" },
            new Worker { Id = 3, LastName = "Толстой", FirstName = "Лев", Patronymic = "Николаевич", Age = 45, Position = "senior developer" },
        };
        public int Add(Worker worker)
        {
            if (worker is null)
                throw new ArgumentNullException(nameof(worker));

            if (__Workers.Contains(worker))
                return worker.Id;

            worker.Id = __Workers
               .Select(w => w.Id)
               .DefaultIfEmpty()
               .Max() + 1;

            __Workers.Add(worker);

            return worker.Id;
        }

        public bool Delete(int id)
        {
            var worker = Get(id);
            if (worker is null) return false;
            return __Workers.Remove(worker);
        }

        public IEnumerable<Worker> Get()
        {
            return __Workers;
        }

        public Worker Get(int id)
        {
            return __Workers.FirstOrDefault(w => w.Id == id);
        }

        public void Update(Worker worker)
        {
            if (worker is null)
                throw new ArgumentNullException(nameof(worker));

            if (__Workers.Contains(worker))
                return;

            var db_item = Get(worker.Id);
            if (db_item is null)
                return;

            db_item.LastName = worker.LastName;
            db_item.FirstName = worker.FirstName;
            db_item.Patronymic = worker.Patronymic;
            db_item.Age = worker.Age;
            db_item.Position = worker.Position;
        }
    }
}
