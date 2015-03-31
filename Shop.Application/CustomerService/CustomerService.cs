using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model.Customer;
using Shop.Domain.Model.Customer.Repository;

namespace Shop.Application.CustomerService
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.FindAll();
        }

        public void CreateNewCustomer(Customer customer)
        {
            _customerRepository.Insert(customer);
        }

        public Customer FindCustomerById(int id)
        {
            return _customerRepository.Find(id);
        }

        public void DeleteCustomerById(int id)
        {
            _customerRepository.Delete(id);
        }
    }
}