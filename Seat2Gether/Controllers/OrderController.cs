using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/Order")]
    public class OrderController:BaseController
    {
        private OrderService OrderService = null;

        public OrderController()
        {
            OrderService = new OrderService();
        }

        [Route("OrderList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult OrderList()
        {
            IHttpActionResult result = null;
            try
            {
                result=Ok(OrderService.OrderList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderController", "OrderList", E);
            }
            return result;
        }


        [Route("AddOrder")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddOrder(OrderDto orderDto)
        {
            
            try
            {
                OrderService.AddOrder(orderDto);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderController", "AddOrder", E);
            }
            return Ok("Order Successfully Created");
        }


        [Route("UpdateOrder")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateOrder(OrderDto orderDto)
        {

            try
            {
                OrderService.UpdateOrder(orderDto);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderController", "UpdateOrder", E);
            }
            return Ok("Order Successfully Updated");
        }


        [Route("DeleteOrder")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteOrder(OrderDto orderDto)
        {

            try
            {
                OrderService.DeleteOrder(orderDto);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderController", "DeleteOrder", E);
            }
            return Ok("Order Successfully Deleted");
        }
    }
}