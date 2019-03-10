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
    [RoutePrefix("api/OrderStatusInfo")]
    public class OrderStatusInfoController : BaseController
    {
        private OrderStatusInfoService OrderStatusIDService = null;

        public OrderStatusInfoController()
        {
            OrderStatusIDService = new OrderStatusInfoService();
        }

        [Route("OrderStatusInfoList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult OrderStatusIDList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(OrderStatusIDService.OrderStatusIDList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderStatusInfoController", "OrderStatusInfoList", E);
            }
            return result;
        }

        [Route("AddOrderStatusInfo")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddOrderStatusID(OrderStatusInfoDto orderStatusID)
        {
            try
            {
                OrderStatusIDService.AddOrderStatusID(orderStatusID);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderStatusInfoController", "AddOrderStatusInfo", E);
            }
            return Ok("Order Status ID Successfully Created");
        }

        [Route("UpdateOrderStatusInfo")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateOrderStatusID(OrderStatusInfoDto orderStatusID)
        {
            try
            {
                OrderStatusIDService.UpdateOrderStatusID(orderStatusID);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderStatusInfoController", "UpdateOrderStatusInfo", E);

            }
            return Ok("Order Status ID Successfully Updated");
        }

        [Route("DeleteOrderStatusInfo")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteOrderStatusID(OrderStatusInfoDto orderStatusID)
        {
            try
            {
                OrderStatusIDService.DeleteOrderStatusID(orderStatusID);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderStatusInfoController", "DeleteOrderStatusInfo", E);
            }
            return Ok("Order Status ID Successfully Deleted");

        }
    }
}