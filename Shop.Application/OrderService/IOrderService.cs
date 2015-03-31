using System.Collections.Generic;

namespace Shop.Application.OrderService
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        void CreateNewOrder(Order order);
    }
}