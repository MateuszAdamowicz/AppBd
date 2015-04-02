using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model.Worker;
using Shop.Domain.Model.Worker.Repository;

namespace Shop.Application.WorkerService
{
    public class WorkerService : IWorkerService
    {
        private IWorkerRepository _workerRepository;

        public WorkerService(IWorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public IEnumerable<Worker> GetAllWorkers()
        {
            return _workerRepository.FindAll();
        }

        public void CreateNewWorker(Worker worker)
        {
            _workerRepository.Insert(worker);
        }

        public Worker FindWorkerById(int id)
        {
            return _workerRepository.Find(id);
        }

        public void DeleteWorkerById(int id)
        {
            _workerRepository.Delete(id);
        }
    }
}