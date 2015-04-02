using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model.Order;
using Shop.Domain.Model.Order.Repository;

namespace Shop.Application.OrderService
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.FindAll();
        }

        public void CreateNewOrder(Order order)
        {
            _orderRepository.Insert(order);
        }

        public Order FindOrderById(int id)
        {
            return _orderRepository.Find(id);
        }

        public void DeleteOrderById(int id)
        {
            _orderRepository.Delete(id);
        }
    }
}