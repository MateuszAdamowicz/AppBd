using System.Collections;
using System.Collections.Generic;
using Shop.Domain.Model.Customer;

namespace Shop.Application
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        void CreateNewCustomer(Customer customer);
    }
}