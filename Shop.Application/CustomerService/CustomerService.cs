using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model.Category;
using Shop.Domain.Model.Customer;

namespace Shop.Application
{
    public class CustomerService: ICustomerService
    {
        private List<Customer> _customers = new List<Customer>();

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customers;
        }

        public void CreateNewCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public Customer FindCustomerById(int id)
        {
            var customer = _customers.Single(x => x.Id == id);
            return customer;
        }

        public void DeleteCustomerById(int id)
        {
            //todo Nie usuwać tylko oznaczać jako usunięte
            _customers.Remove(FindCustomerById(id));
        }
    }
}