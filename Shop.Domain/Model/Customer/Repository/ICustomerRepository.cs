using System.Collections;
using System.Collections.Generic;

namespace Shop.Domain.Model.Customer.Repository
{
    public interface ICustomerRepository
    {
        void Insert(Customer customer);
        void Delete(int id);
        Customer Find(int id);
        IEnumerable<Customer> FindAll();
    }
}