using System.Collections.Generic;
using Shop.Domain.Model.Customer;

namespace Shop.Application.CustomerService
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        void CreateNewCustomer(Customer customer);
        Customer FindCustomerById(int id);
        void DeleteCustomerById(int id);
    }
}