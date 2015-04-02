using System.Collections.Generic;
using Shop.Domain.Model.Order;

namespace Shop.Application.OrderService
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        void CreateNewOrder(Order order);
        Order FindOrderById(int id);
        void DeleteOrderById(int id);
    }
}