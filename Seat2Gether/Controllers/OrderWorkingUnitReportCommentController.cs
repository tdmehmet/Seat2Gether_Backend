
using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/OrderWorkingUnitReportComment")]
    public class OrderWorkingUnitReportCommentController : BaseController
    {
        private OrderWorkingUnitReportCommentService OrderWorkingUnitReportCommentService = null;

        public OrderWorkingUnitReportCommentController()
        {
            OrderWorkingUnitReportCommentService = new OrderWorkingUnitReportCommentService();
        }

        [Route("ListReportOrderByOrderID/{OrderNumber?}")]
        [HttpGet]
        [Authorize]
        public IHttpActionResult ListReportOrderByOrderID(string OrderNumber = null)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(OrderWorkingUnitReportCommentService.ListReportOrderByOrderID(OrderNumber));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "OrderWorkingUnitReportCommentController", "ListReportOrderByOrderID", E);
            }
            return result;
        }

        [Route("FindOrderWorkingUnitReportCommentByOrderID/{OrderNumber}")]
        [HttpGet]
        public IHttpActionResult FindOrderWorkingUnitReportCommentByOrderID(string OrderNumber)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(OrderWorkingUnitReportCommentService.FindOrderWorkingUnitReportCommentByOrderID(OrderNumber));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "OrderWorkingUnitReportCommentController", "FindOrderWorkingUnitReportCommentByOrderID", E);
            }
            return result;
        }

        [Route("AddOrderWorkingUnitReportComment")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddOrderWorkingUnitReportComment(OrderWorkingUnitReportCommentDto OrderWorkingUnitReportComment)
        {
            try
            {
                OrderWorkingUnitReportCommentService.AddOrderWorkingUnitReportComment(OrderWorkingUnitReportComment);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderWorkingUnitReportCommentController", "AddOrderWorkingUnitReportComment", E);
            }
            return Ok("Order Working Unit Report Controller Successfully Created");
        }

        [Route("DeleteOrderWorkingUnitReportComment")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteOrderWorkingUnitReportComment(OrderWorkingUnitReportCommentDto OrderWorkingUnitReportComment)
        {
            try
            {
                OrderWorkingUnitReportCommentService.DeleteOrderWorkingUnitReportComment(OrderWorkingUnitReportComment);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "OrderWorkingUnitReportCommentController", "DeleteOrderWorkingUnitReportComment", E);
            }
            return Ok("Order Working Unit Report Comment Successfuly Deleted");
        }

        [Route("UpdateOrderWorkingUnitReportComment")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateOrderWorkingUnitReportComment(OrderWorkingUnitReportCommentDto OrderWorkingUnitReportComment)
        {
            try
            {
                OrderWorkingUnitReportCommentService.UpdateOrderWorkingUnitReportComment(OrderWorkingUnitReportComment);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "OrderWorkingUnitReportComment", "UpdateOrderWorkingUnitReportComment", E);
            }
            return Ok("Order Working Unit Report Comment Successfuly Updated");
        }

        [Route("ListAllWorkingUnit")]
        [HttpGet]
        [Authorize]
        public IHttpActionResult ListAllWorkingUnit()
        {
            try
            {
                var workingUnitList = OrderWorkingUnitReportCommentService.ListAllWorkingUnit().Select(k => new WorkingUnitDto
                {
                    ID = k.ID,
                    Tr = k.Tr,
                    De = k.De,
                    En = k.En
                });
                return Ok(workingUnitList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "OrderWorkingUnitReportComment", "ListAllWorkingUnit", E);
            }
        }
    }
}