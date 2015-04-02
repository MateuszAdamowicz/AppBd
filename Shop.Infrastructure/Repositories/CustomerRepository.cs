using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model.Customer;
using Shop.Domain.Model.Customer.Repository;

namespace Shop.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private IList<Customer> _customers;

        public CustomerRepository()
        {
            _customers = new List<Customer>();
        }

        public void Insert(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Delete(int id)
        {
            _customers.Remove(Find(id));
        }

        public Customer Find(int id)
        {
            var result = _customers.Single(x => x.Id == id);
            return result;
        }

        public IEnumerable<Customer> FindAll()
        {
            return _customers;
        }
    }
}