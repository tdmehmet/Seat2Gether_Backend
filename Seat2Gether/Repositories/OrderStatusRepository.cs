using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class OrderStatusRepository
    {
        private Seat2GetherDBContext DBContext = null;

        public OrderStatusRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<OrderStatus> OrderStatusList()
        {
            var OrderStatusQuery = from orderStatus in DBContext.OrderStatus
                                   select orderStatus;

            List<OrderStatus> orderStatusList = OrderStatusQuery.ToList();

            return orderStatusList;
        }

        public void AddOrderStatus(OrderStatus orderStatus)
        {
            DBContext.OrderStatus.Add(orderStatus);
            DBContext.SaveChanges();
        }

        public void UpdateOrderStatus(OrderStatus orderStatus)
        {
            OrderStatus x = FindOrderStatusById(orderStatus.OrderNumber);
            if (x != null)
            {
                x.StatusID = orderStatus.StatusID;

                DBContext.OrderStatus.Attach(x);
                var entry = DBContext.Entry(x);
                entry.State = EntityState.Unchanged;
                entry.State = EntityState.Modified;

                DBContext.SaveChanges();
                entry.State = EntityState.Unchanged;
            }
            else
            {
                AddOrderStatus(orderStatus);
            }
        }

        public void DeleteOrderStatus(OrderStatus orderStatus)
        {
            
            OrderStatus x = FindOrderStatusById(orderStatus.OrderNumber);
            if (x != null)
            {
                x.StatusID = 1;

                DBContext.OrderStatus.Attach(x);
                var entry = DBContext.Entry(x);
                entry.State = EntityState.Unchanged;
                entry.State = EntityState.Modified;

                DBContext.SaveChanges();
                entry.State = EntityState.Unchanged;
            }
        }

        public OrderStatus FindOrderStatusById(string orderNumber)
        {
            var orderQuery = from order in DBContext.OrderStatus
                             where order.OrderNumber.Equals(orderNumber)
                             select order;
            OrderStatus uniqueOrder = orderQuery.FirstOrDefault();

            return uniqueOrder;
        }
    }
}




















//public void DeleteOrder(Order order)
//{

//   
//}

