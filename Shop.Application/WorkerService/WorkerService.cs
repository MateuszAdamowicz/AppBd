using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model.Worker;

namespace Shop.Application.WorkerService
{
    public class WorkerService : IWorkerService
    {
        private List<Worker> _workers;

        public WorkerService()
        {
            _workers = new List<Worker>();
        }

        public IEnumerable<Worker> GetAllWorkers()
        {
            return _workers;
        }

        public void CreateNewWorker(Worker worker)
        {
            _workers.Add(worker);
        }

        public Worker FindWorkerById(int id)
        {
            return _workers.Single(x => x.Id == id);
        }

        public void DeleteWorkerById(int id)
        {
            var worker = FindWorkerById(id);
            _workers.Remove(worker);
        }
    }
}