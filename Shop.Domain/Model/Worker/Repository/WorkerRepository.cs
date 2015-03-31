using System.Collections.Generic;
using System.Linq;

namespace Shop.Domain.Model.Worker.Repository
{
    public class WorkerRepository : IWorkerRepository
    {
        private IList<Worker> _workers; 

        public void Insert(Worker worker)
        {
            _workers.Add(worker);
        }

        public void Delete(int id)
        {
            _workers.Remove(Find(id));
        }

        public Worker Find(int id)
        {
            var result = _workers.Single(x => x.Id == id);
            return result;
        }

        public IEnumerable<Worker> FinAll()
        {
            return _workers;
        }
    }
}