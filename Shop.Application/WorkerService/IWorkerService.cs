using System.Collections.Generic;
using Shop.Domain.Model.Worker;

namespace Shop.Application.WorkerService
{
    public interface IWorkerService
    {
        IEnumerable<Worker> GetAllWorkers();
        void CreateNewWorker(Worker worker);
    }
}