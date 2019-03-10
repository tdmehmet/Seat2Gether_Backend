using Seat2Gether.dto;
using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class OrderRepository
    {
        private Seat2GetherDBContext DBContext = null;

        public OrderRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<Order> OrderList()
        {
            var orderListQuery = from order in DBContext.Order
                                 select order;

            List<Order> orderList = orderListQuery.ToList();

            return orderList;
        }

        public void AddOrder(Order order)
        {
            DBContext.Order.Add(order);
            DBContext.SaveChanges();

        }

        public void UpdateOrder(Order order)
        {
            Order x = FindOrderById(order.OrderNumber);
            
            // It can be that the OrderNumber doesn't exist in T_Auftrag
            // In this case add a new entry to the table T_Auftrag
            if (x != null)
            {
                x.Comment = order.Comment;

                DBContext.Order.Attach(x);
                var entity = DBContext.Entry(x);
                entity.State = EntityState.Unchanged;
                entity.State = EntityState.Modified;
                DBContext.SaveChanges();

                entity.State = EntityState.Unchanged;
            }
            else
            {
                AddOrder(order);
            }
        }

        public void DeleteOrder(Order order)
        {
            Order x = FindOrderById(order.OrderNumber);
            // It can be that the OrderNumber doesn't exist in T_Auftrag
            // Comment is just to set to null. No entry will be deleted
            if (x != null)
            {
                x.Comment = null;

                DBContext.Order.Attach(x);
                var entity = DBContext.Entry(x);
                entity.State = EntityState.Unchanged;
                entity.State = EntityState.Modified;

                DBContext.SaveChanges();
                entity.State = EntityState.Unchanged;
            }
        }

        public Order FindOrderById(string orderId)
        {
            var orderQuery = from order in DBContext.Order
                             where order.OrderNumber.Equals(orderId)
                             select order;
            Order uniqueOrder = orderQuery.FirstOrDefault();

            return uniqueOrder;
        }
    }
}