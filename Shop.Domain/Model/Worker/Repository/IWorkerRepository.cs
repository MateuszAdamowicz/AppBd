using System.Collections;
using System.Collections.Generic;

namespace Shop.Domain.Model.Worker.Repository
{
    public interface IWorkerRepository
    {
        void Insert(Worker worker);
        void Delete(int id);
        Worker Find(int id);
        IEnumerable<Worker> FindAll();
    }
}