using System;

namespace Shop.Domain.Model.Order
{
    public class OrderStatus
    {
        public StatusName StatusName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}