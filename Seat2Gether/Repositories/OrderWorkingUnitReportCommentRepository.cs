using Seat2Gether.dto;
using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class OrderWorkingUnitReportCommentRepository
    {
        private Seat2GetherDBContext DBContext = null;

        public OrderWorkingUnitReportCommentRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<ReportOrder> ListReportOrderByOrderID(string OrderNumber)
        {
            var listReportOrdersQuery = from reportOrder in DBContext.ReportOrder
                                        where (reportOrder.OrderNumber.StartsWith(OrderNumber) || OrderNumber == null)
                                        orderby OrderNumber ascending
                                        select reportOrder;

            List<ReportOrder> ListReportOrders = listReportOrdersQuery.ToList();
            return ListReportOrders;
        }

        public List<OrderWorkingUnitReportComment> FindOrderWorkingUnitReportCommentByOrderID(string OrderNumber)
        {
            var findOrderWorkingUnitComment = from orderWorkingUnitComment in DBContext.OrderWorkingUnitComment
                                              where orderWorkingUnitComment.OrderID == OrderNumber
                                              orderby orderWorkingUnitComment.OrderID
                                              select orderWorkingUnitComment;
            List<OrderWorkingUnitReportComment> FindOrderWorkingUnitReportComment = findOrderWorkingUnitComment.ToList();
            return FindOrderWorkingUnitReportComment;
        }

        public void AddOrderWorkingUnitReportComment(OrderWorkingUnitReportComment OrderWorkingUnitReportComment)
        {
            var entry = DBContext.Entry(OrderWorkingUnitReportComment.WorkingUnit);
            entry.State = EntityState.Unchanged;
            DBContext.OrderWorkingUnitComment.Add(OrderWorkingUnitReportComment);
            DBContext.SaveChanges();
        }

        public void DeleteOrderWorkingUnitReportComment(OrderWorkingUnitReportComment OrderWorkingUnitReportComment)
        {
            DBContext.OrderWorkingUnitComment.Attach(OrderWorkingUnitReportComment);
            var WorkingUnitEntry = DBContext.Entry(OrderWorkingUnitReportComment.WorkingUnit);
            WorkingUnitEntry.State = EntityState.Unchanged;
            var ReportCommentEntry = DBContext.Entry(OrderWorkingUnitReportComment.ReportComment);
            ReportCommentEntry.State = EntityState.Deleted;
            var OrderWorkingUnitCommentEntry = DBContext.Entry(OrderWorkingUnitReportComment);
            OrderWorkingUnitCommentEntry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }

        public void UpdateOrderWorkingUnitReportComment(OrderWorkingUnitReportComment OrderWorkingUnitReportComment)
        {
            DBContext.ReportComment.Attach(OrderWorkingUnitReportComment.ReportComment);
            var reportCommentEntry = DBContext.Entry(OrderWorkingUnitReportComment.ReportComment);
            reportCommentEntry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public IQueryable<WorkingUnit> ListAllWorkingUnit()
        {
            return DBContext.WorkingUnit.AsQueryable();
        }

    }
}