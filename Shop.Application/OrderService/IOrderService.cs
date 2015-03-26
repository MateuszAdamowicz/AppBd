using System.Collections;
using System.Collections.Generic;
using Shop.Domain.Model.Order;

namespace Shop.Application
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        void CreateNewOrder(Order order);
    }
}