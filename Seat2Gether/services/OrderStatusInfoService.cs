using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class OrderStatusInfoService
    {
        private OrderStatusInfoRepository OrderStatusIDRepository = null;

        public OrderStatusInfoService()
        {
            OrderStatusIDRepository = new OrderStatusInfoRepository();
        }
            
        public List<OrderStatusInfoDto>OrderStatusIDList()
        {
            List<OrderStatusInfo> orderStatusIDList = new List<OrderStatusInfo>();
            List<OrderStatusInfoDto> orderStatusIDDtoList = new List<OrderStatusInfoDto>();

            orderStatusIDList = OrderStatusIDRepository.OrderStatusIDList();
            orderStatusIDDtoList = orderStatusIDList.CreateMappedList<OrderStatusInfo, OrderStatusInfoDto>();
            return orderStatusIDDtoList;
        }

        public void AddOrderStatusID(OrderStatusInfoDto orderStatusID)
        {
            OrderStatusInfo orderStatusIDList = orderStatusID.CreateMapped<OrderStatusInfoDto, OrderStatusInfo>();
            OrderStatusIDRepository.AddOrderStatusID(orderStatusIDList);
        }

        public void UpdateOrderStatusID(OrderStatusInfoDto orderStatusID)
        {
            OrderStatusInfo orderStatusIDList = orderStatusID.CreateMapped<OrderStatusInfoDto, OrderStatusInfo>();
            OrderStatusIDRepository.UpdateOrderStatusID(orderStatusIDList);
        }

        public void DeleteOrderStatusID(OrderStatusInfoDto orderStatusID)
        {
            OrderStatusInfo orderStatusIDList = orderStatusID.CreateMapped<OrderStatusInfoDto, OrderStatusInfo>();
            OrderStatusIDRepository.DeleteOrderStatusID(orderStatusIDList);
        }
    }
}