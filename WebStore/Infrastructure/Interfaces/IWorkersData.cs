using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IWorkersData
    {
        IEnumerable<Worker> Get();

        Worker Get(int id);

        int Add(Worker worker);

        void Update(Worker worker);

        bool Delete(int id);
    }
}
