using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class OrderService
    {
        private OrderRepository OrderRepository = null;

        public OrderService()
        {
            OrderRepository = new OrderRepository();
        }

        public List<OrderDto> OrderList()
        {
            List<Order> orderList = new List<Order>();
            List<OrderDto> orderDtoList = new List<OrderDto>();
            orderList = OrderRepository.OrderList();

            orderDtoList = orderList.CreateMappedList<Order, OrderDto>();
            return orderDtoList;
        }

        public void AddOrder(OrderDto orderDto)
        {
            Order orderList = orderDto.CreateMapped<OrderDto, Order>();
            OrderRepository.UpdateOrder(orderList);
        }

        public void UpdateOrder(OrderDto orderDto)
        {
            Order order = orderDto.CreateMapped<OrderDto, Order>();
            OrderRepository.UpdateOrder(order);
        }

        public void DeleteOrder(OrderDto orderDto)
        {
            Order orderList = orderDto.CreateMapped<OrderDto, Order>();
            OrderRepository.DeleteOrder(orderList);
        }
    }
}