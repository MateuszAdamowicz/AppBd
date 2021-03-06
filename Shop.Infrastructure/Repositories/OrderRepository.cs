﻿using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model.Order;
using Shop.Domain.Model.Order.Repository;

namespace Shop.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private IList<Order> _orders;

        public OrderRepository()
        {
            _orders = new List<Order>();
        }

        public void Insert(Order order)
        {
            _orders.Add(order);
        }

        public void Delete(int id)
        {
            _orders.Remove(Find(id));
        }

        public Order Find(int id)
        {
            var result = _orders.Single(x => x.Id == id);
            return result;
        }

        public IEnumerable<Order> FindAll()
        {
            return _orders;
        }
    }
}