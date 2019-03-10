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
    [RoutePrefix("api/OrderStatus")]
    public class OrderStatusController : BaseController
    {
        private OrderStatusService OrderStatusService = null;

        public OrderStatusController()
        {
            OrderStatusService = new OrderStatusService();
        }

        [Route("OrderStatusList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult OrderStatusList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(OrderStatusService.OrderStatusList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderStatusController", "OrderStatusList", E);
            }
            return result;
        }

        [Route("AddOrderStatus")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddOrderStatus(OrderStatusDto orderStatus)
        {
            try
            {
                OrderStatusService.AddOrderStatus(orderStatus);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderStatusController", "AddOrderStatus", E);
            }
            return Ok("Order Status Successfully Created");
        }

        [Route("UpdateOrderStatus")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateOrderStatus(OrderStatusDto orderStatus)
        {
            try
            {
                OrderStatusService.UpdateOrderStatus(orderStatus);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderStatusController", "UpdateOrderStatus", E);
            }
            return Ok("Order Status Successfully Updated");
        }

        [Route("DeleteOrderStatus")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteOrderStatus(OrderStatusDto orderStatus)
        {
            try
            {
                OrderStatusService.DeleteOrderStatus(orderStatus);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderStatusController", "DeleteOrderStatus", E);
            }
            return Ok("Order Status Successfully Deleted");
        }

    }
}