using System.Collections;
using System.Collections.Generic;

namespace Shop.Domain.Model.Order.Repository
{
    public interface IOrderRepository
    {
        void Insert(Order order);
        void Delete(int id);
        Order Find(int id);
        IEnumerable<Order> FindAll();
    }
}