using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model.Order;

namespace Shop.Application.OrderService
{
    public class OrderService:IOrderService
    {
        private List<Order> _orders;

        public OrderService()
        {
            _orders = new List<Order>();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orders;
        }

        public void CreateNewOrder(Order order)
        {
            _orders.Add(order);
        }

        public Order FindOrderById(int id)
        {
            return _orders.Single(x => x.Id == id);
        }

        public void DeleteOrderById(int id)
        {
            var order = FindOrderById(id);
            _orders.Remove(order);
        }
    }
}