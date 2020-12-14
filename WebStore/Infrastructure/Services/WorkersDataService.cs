using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;
using WebStore.Data;

namespace WebStore.Infrastructure.Services
{
    public class WorkersDataService : IWorkersData
    {
        private static readonly List<Worker> __Workers = TestData.Workers;
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
