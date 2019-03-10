using Microsoft.Reporting.WebForms;
using Seat2Gether.services.ExternalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seat2Gether.dto.ExternalDto;
namespace Seat2Gether.Reports.ExReports.MaterialsReport.MaterialsByStation
{
    public partial class MaterialsByStation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.SizeToReportContent = true;
                var materialService = new MaterialService();
                var materialaList = materialService.GetList();
                //ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report.rdlc");
                //Customers dsCustomers = GetData("select top 20 * from customers");
                //ExTb_VehicleMaterial
                ReportDataSource datasource = new ReportDataSource("DataSet1", materialaList);
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(datasource);
            }
        }
    }
}