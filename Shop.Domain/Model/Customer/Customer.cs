using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Shop.Domain.Model.Customer
{
    public class Customer
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public Name Name { get; set; }
        public EmailAddress EmailAddress { get; set; }
        public IEnumerable<Order.Order> Orders { get; set; }
    }
}