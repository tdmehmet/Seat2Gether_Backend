using Microsoft.Reporting.WebForms;
using Seat2Gether.services.ExternalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Seat2Gether.Reports.ExReports.MaterialsReport.MaterialsBySeat
{
    public partial class MaterialsBySeat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string bbNumber = Request.QueryString["BB"];
                if (bbNumber != null)
                {
                    ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.SizeToReportContent = true;
                    var materialService = new SeatService();
                    var materialaList = materialService.GetList(bbNumber);

                    ReportDataSource datasource = new ReportDataSource("MaterialsDataSet", materialaList);
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(datasource);
                }

            }
        }
    }
}