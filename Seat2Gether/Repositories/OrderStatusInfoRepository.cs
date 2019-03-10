using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class OrderStatusInfoRepository
    {
        private Seat2GetherDBContext DBContext = null;

        public OrderStatusInfoRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<OrderStatusInfo>OrderStatusIDList()
        {
            var orderStatusIDQuery = from orderStatusID in DBContext.OrderStatusID
                                     select orderStatusID;

            List<OrderStatusInfo> orderStatusIDList = orderStatusIDQuery.ToList();

            return orderStatusIDList;
        }

        public void AddOrderStatusID(OrderStatusInfo orderStatusID)
        {
            DBContext.OrderStatusID.Add(orderStatusID);
            DBContext.SaveChanges();
        }

        public void UpdateOrderStatusID(OrderStatusInfo orderStatusID)
        {
            DBContext.OrderStatusID.Attach(orderStatusID);
            var entity = DBContext.Entry(orderStatusID);
            entity.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteOrderStatusID(OrderStatusInfo orderStatusID)
        {
            DBContext.OrderStatusID.Attach(orderStatusID);
            var entity = DBContext.Entry(orderStatusID);
            entity.State = EntityState.Deleted;
            DBContext.SaveChanges();
            
        }
    }
}