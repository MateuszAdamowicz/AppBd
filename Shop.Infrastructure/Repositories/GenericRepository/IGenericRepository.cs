using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Shop.Infrastructure.Repositories.GenericRepository
{
    public interface IGenericRepository<T> where T : BuisnessObject
    {
        void Insert(T entity);
        IEnumerable<T> FindAll();
        T Find(int id);
        void Delete(int id);
    }

    public class BuisnessObject
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }
    }

    public class GenericRepository<T> : IGenericRepository<T> where T : BuisnessObject
    {

        private IList<T> _repository;

        public void Insert(T entity)
        {
            _repository.Add(entity);
        }

        public IEnumerable<T> FindAll()
        {
            return _repository;
        }

        public T Find(int id)
        {
            return _repository.Single(x => x.Id == id);
        }

        public void Delete(int id)
        {
            var entity = Find(id);
            if (entity.Deleted)
            {
                throw new AlreadyDeletedEntityException<T>(id);
            }
        }
    }

    public class AlreadyDeletedEntityException<T> : Exception
    {
        private string tempMsg;
        public AlreadyDeletedEntityException(int id)
        {
            tempMsg = String.Format("Entity of type: {0} and id: {0} is already deleted", typeof(T), id);
        }

        public override string Message
        {
            get { return tempMsg; }
        }
    }

}

