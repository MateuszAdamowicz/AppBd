using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using Shop.Domain.Model.Customer;

namespace Shop.Domain.Model.Worker
{
    public class Worker
    {
        public int Id { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Role> Roles { get; set; }
        public int Level { get; set; }
        public IEnumerable<Activity> Activities { get; set; }
    }
}