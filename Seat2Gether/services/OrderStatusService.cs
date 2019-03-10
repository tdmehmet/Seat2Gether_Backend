using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class OrderStatusService
    {
        private OrderStatusRepository OrderStatusRepository = null;

        public OrderStatusService()
        {
            OrderStatusRepository = new OrderStatusRepository();
        }

        public List<OrderStatusDto> OrderStatusList()
        {
            List<OrderStatus> orderStatusList = new List<OrderStatus>();
            List<OrderStatusDto> orderStatusDtoList = new List<OrderStatusDto>();
            orderStatusList = OrderStatusRepository.OrderStatusList();
            orderStatusDtoList = orderStatusList.CreateMappedList<OrderStatus, OrderStatusDto>();
            return orderStatusDtoList;
        }

        public void AddOrderStatus(OrderStatusDto orderStatus)
        {
            OrderStatus orderStatusList = orderStatus.CreateMapped<OrderStatusDto, OrderStatus>();
            OrderStatusRepository.AddOrderStatus(orderStatusList);
        }

        public void UpdateOrderStatus(OrderStatusDto orderStatus)
        {
            OrderStatus orderStatusList = orderStatus.CreateMapped<OrderStatusDto, OrderStatus>();
            OrderStatusRepository.UpdateOrderStatus(orderStatusList);
        }

        public void DeleteOrderStatus(OrderStatusDto orderStatus)
        {
            OrderStatus orderStatusList = orderStatus.CreateMapped<OrderStatusDto, OrderStatus>();
            OrderStatusRepository.DeleteOrderStatus(orderStatusList);
        }

    }
}
