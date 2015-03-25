using System;
using System.Collections;
using System.Collections.Generic;
using Shop.Domain.Model.Product;

namespace Shop.Domain.Model.Order
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Customer Customer{ get; set; }
        public OrderStatus OrderStatus { get; set; }
        public IEnumerable<OrderLine> Products { get; set; }
        public string Comment { get; set; }
        public Price Price { get; set; }
    }
}