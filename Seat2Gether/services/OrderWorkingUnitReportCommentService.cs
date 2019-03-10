
using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class OrderWorkingUnitReportCommentService
    {
        private OrderWorkingUnitReportCommentRepository OrderWorkingUnitReportCommentRepository = null;

        public OrderWorkingUnitReportCommentService()
        {
            OrderWorkingUnitReportCommentRepository = new OrderWorkingUnitReportCommentRepository();
        }

        public List<ReportOrderDto> ListReportOrderByOrderID(string OrderNumber)
        {
            List<ReportOrder> reportOrderList = new List<ReportOrder>();
            List<ReportOrderDto> reportOrderDtoList = new List<ReportOrderDto>();
            reportOrderList = OrderWorkingUnitReportCommentRepository.ListReportOrderByOrderID(OrderNumber);
            return reportOrderDtoList = reportOrderList.CreateMappedList<ReportOrder, ReportOrderDto>();
        }

        public List<OrderWorkingUnitReportCommentDto> FindOrderWorkingUnitReportCommentByOrderID(string OrderNumber)
        {
            List<OrderWorkingUnitReportComment> OrderWorkingUnitReportCommentList = OrderWorkingUnitReportCommentRepository.FindOrderWorkingUnitReportCommentByOrderID(OrderNumber);
            List<OrderWorkingUnitReportCommentDto> OrderWorkingUnitReportCommentDtoList = new List<OrderWorkingUnitReportCommentDto>();

            foreach (OrderWorkingUnitReportComment orderWorkingUnitReportComment in OrderWorkingUnitReportCommentList)
            {
                OrderWorkingUnitReportCommentDto OrderWorkingUnitReportCommentDtoMdl = new OrderWorkingUnitReportCommentDto()
                {
                    OrderID = orderWorkingUnitReportComment.OrderID,
                    ReportComment = orderWorkingUnitReportComment.ReportComment.CreateMapped<ReportComment, ReportCommentDto>(),
                    WorkingUnit = orderWorkingUnitReportComment.WorkingUnit.CreateMapped<WorkingUnit, WorkingUnitDto>()
                };
                OrderWorkingUnitReportCommentDtoList.Add(OrderWorkingUnitReportCommentDtoMdl);
            }
            return OrderWorkingUnitReportCommentDtoList;
        }

        public void AddOrderWorkingUnitReportComment(OrderWorkingUnitReportCommentDto OrderWorkingUnitReportCommentDto)
        {

            OrderWorkingUnitReportComment OrderWorkingUnitReportComment = new OrderWorkingUnitReportComment()
            {
                OrderID = OrderWorkingUnitReportCommentDto.OrderID,
                WorkingUnit = OrderWorkingUnitReportCommentDto.WorkingUnit.CreateMapped<WorkingUnitDto, WorkingUnit>(),
                ReportComment = OrderWorkingUnitReportCommentDto.ReportComment.CreateMapped<ReportCommentDto, ReportComment>()

            };
            OrderWorkingUnitReportCommentRepository.AddOrderWorkingUnitReportComment(OrderWorkingUnitReportComment);
        }

        public void DeleteOrderWorkingUnitReportComment(OrderWorkingUnitReportCommentDto OrderWorkingUnitReportCommentDto)
        {

            OrderWorkingUnitReportComment OrderWorkingUnitReportComment = new OrderWorkingUnitReportComment()
            {
                OrderID = OrderWorkingUnitReportCommentDto.OrderID,
                WorkingUnitID = OrderWorkingUnitReportCommentDto.WorkingUnitID,
                CommentID = OrderWorkingUnitReportCommentDto.CommentID,
                WorkingUnit = OrderWorkingUnitReportCommentDto.WorkingUnit.CreateMapped<WorkingUnitDto, WorkingUnit>(),
                ReportComment = OrderWorkingUnitReportCommentDto.ReportComment.CreateMapped<ReportCommentDto, ReportComment>()

            };
            OrderWorkingUnitReportCommentRepository.DeleteOrderWorkingUnitReportComment(OrderWorkingUnitReportComment);
        }


        public void UpdateOrderWorkingUnitReportComment(OrderWorkingUnitReportCommentDto OrderWorkingUnitReportCommentDto)
        {

            OrderWorkingUnitReportComment OrderWorkingUnitReportComment = new OrderWorkingUnitReportComment()
            {
                OrderID = OrderWorkingUnitReportCommentDto.OrderID,
                WorkingUnitID = OrderWorkingUnitReportCommentDto.WorkingUnitID,
                CommentID = OrderWorkingUnitReportCommentDto.CommentID,
                WorkingUnit = OrderWorkingUnitReportCommentDto.WorkingUnit.CreateMapped<WorkingUnitDto, WorkingUnit>(),
                ReportComment = OrderWorkingUnitReportCommentDto.ReportComment.CreateMapped<ReportCommentDto, ReportComment>()

            };
            OrderWorkingUnitReportCommentRepository.UpdateOrderWorkingUnitReportComment(OrderWorkingUnitReportComment);
        }

        public IQueryable<WorkingUnit> ListAllWorkingUnit()
        {
            return OrderWorkingUnitReportCommentRepository.ListAllWorkingUnit();
        }
        
    }
}