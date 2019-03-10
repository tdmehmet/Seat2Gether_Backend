using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Reporting.WebForms;
using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Seat2Gether.Reports
{
    public partial class Seat2GetherReports : System.Web.UI.Page
    {
        private ReportService ReportService = null;
        List<ReportLogDto> ReportLogDtoList = null;
        Seat2GetherReportsVisibilityDataSet ReportsVisibility = new Seat2GetherReportsVisibilityDataSet();
        
        protected class Seat2GetherReportsVisibilityDataSet
        {
            public string IsCutReportVisible;
            public string IsGesslerReportVisible;
            public string IsMontageReportVisible;
            public string IsSpecialChairReportVisible;
            public string IsStitchingReportVisible;
            public string IsChairDazzleReportVisible;
            public string IsStitchingCurtainReportVisible;

            public Seat2GetherReportsVisibilityDataSet()
            {
                this.IsCutReportVisible = "false";
                this.IsGesslerReportVisible = "false";
                this.IsMontageReportVisible = "false";
                this.IsSpecialChairReportVisible = "false";
                this.IsStitchingReportVisible = "false";
                this.IsChairDazzleReportVisible = "false";
                this.IsStitchingCurtainReportVisible = "false";
            }
        }

        public Seat2GetherReports()
        {
            ReportService = new ReportService();
            ReportLogDtoList = new List<ReportLogDto>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string BBNr = Request["BBNr"];
                string types = Request["types"];
                string user = Request["user"];
                string[] reportTypeList = null;


                if (types != null || !types.Equals(""))
                {
                    reportTypeList = Request["types"].Split(',');
                }
                BBNR bbnr = ReportService.FindBBNRByBBNR(BBNr);
                Session.Add("AuftragsNr", bbnr.OrderID);
                ReportParameter[] parameters = new ReportParameter[7];
                
                if (reportTypeList != null)
                {
                    foreach (string reportType in reportTypeList)
                    {
                        ReportLogDto reportLogDto = new ReportLogDto(BBNr, "-", null, DateTime.Now, user);
                        ReportLogDto reportLogDto2 = null;

                        if (reportType.Equals("cut"))
                        {
                            this.ReportsVisibility.IsCutReportVisible = "true";
                            reportLogDto.ReportName = "B_BBNR_UA_Zuschnitt";
                        }

                        if (reportType.Equals("ges"))
                        {
                            this.ReportsVisibility.IsGesslerReportVisible = "true";
                            reportLogDto.ReportName = "B_BBNr_UA_Gessler";
                            reportLogDto2 = new ReportLogDto(BBNr, "-", "B_Gessler", DateTime.Now, user);
                        }
                        if (reportType.Equals("sti"))
                        {
                            this.ReportsVisibility.IsStitchingReportVisible = "true";
                            reportLogDto.ReportName = "B_BBNR_UA_Näherei";
                            reportLogDto2 = new ReportLogDto(BBNr, "-", "B_Ausdruck_Näherei", DateTime.Now, user);
                        }
                        if (reportType.Equals("mon"))
                        {
                            this.ReportsVisibility.IsMontageReportVisible = "true";
                            reportLogDto.ReportName = "B_BBNR_UA_Montage";
                            reportLogDto2 = new ReportLogDto(BBNr, "-", "B_BBNR_UA_Montage_Fond", DateTime.Now, user);
                        }
                        if (reportType.Equals("exs"))
                        {
                            this.ReportsVisibility.IsSpecialChairReportVisible = "true";
                            reportLogDto.ReportName = "B_BBNR_UA_Sonderstuhl";
                        }
                        if (reportType.Equals("msk"))
                        {
                            this.ReportsVisibility.IsChairDazzleReportVisible = "true";
                            reportLogDto.ReportName = "B_BBNr_Sesselblenden";
                            reportLogDto2 = new ReportLogDto(BBNr, "-", "B_BBNr_Gurtschloss_Wandseitig", DateTime.Now, user);
                        }
                        if (reportType.Equals("stc"))
                        {
                            this.ReportsVisibility.IsStitchingCurtainReportVisible = "true";
                            reportLogDto.ReportName = "B_BBNr_UA_Näherei_Vorhang";
                        }

                        this.ReportLogDtoList.Add(reportLogDto);
                        if (reportLogDto2 != null)
                        {
                            this.ReportLogDtoList.Add(reportLogDto2);
                        }

                    }
                }
                DataTable reportVisibilityDataTable = new DataTable();
                
                reportVisibilityDataTable.Columns.Add("IsCutReportVisible", typeof(string));
                reportVisibilityDataTable.Columns.Add("IsGesslerReportVisible", typeof(string));
                reportVisibilityDataTable.Columns.Add("IsMontageReportVisible", typeof(string));
                reportVisibilityDataTable.Columns.Add("IsSpecialChairReportVisible", typeof(string));
                reportVisibilityDataTable.Columns.Add("IsStitchingReportVisible", typeof(string));
                reportVisibilityDataTable.Columns.Add("IsChairDazzleReportVisible", typeof(string));
                reportVisibilityDataTable.Columns.Add("IsStitchingCurtainReportVisible", typeof(string));
                reportVisibilityDataTable.Rows.Add(
                    this.ReportsVisibility.IsCutReportVisible,
                    this.ReportsVisibility.IsGesslerReportVisible,
                    this.ReportsVisibility.IsMontageReportVisible,
                    this.ReportsVisibility.IsSpecialChairReportVisible,
                    this.ReportsVisibility.IsStitchingReportVisible,
                    this.ReportsVisibility.IsChairDazzleReportVisible,
                    this.ReportsVisibility.IsStitchingCurtainReportVisible
                    );
                this.Seat2GetherReportsViewer.LocalReport.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_ReportsVisibility",
                    reportVisibilityDataTable));
                this.Seat2GetherReportsViewer.LocalReport.SubreportProcessing += new
                             SubreportProcessingEventHandler(SetSubReportsDataSource);
                this.Seat2GetherReportsViewer.KeepSessionAlive = true;
                this.Seat2GetherReportsViewer.LocalReport.Refresh();
                this.ReportService.AddReportLogList(ReportLogDtoList);
            }
        }
        public void SetSubReportsDataSource(object sender, SubreportProcessingEventArgs e)

        {
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_A_BBNR", "Seat2GetherReportsDataSource_A_BBNR"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_Stammdaten", "Seat2GetherReportsDataSource_SP_BBNR_Stammdaten"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_T_ST_Variante_Stoffangabe", "Seat2GetherReportsDataSource_T_ST_Variante_Stoffangabe"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_23", "Seat2GetherReportsDataSource_SP_BBNR_UA_23"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_TGR_Zuschnitt_BA_TG", "Seat2GetherReportsDataSource_SP_BBNR_TGR_Zuschnitt_BA_TG"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_Anbauteile_Zuschnitt_Rücken", "Seat2GetherReportsDataSource_SP_BBNR_Anbauteile_Zuschnitt_Rücken"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Fahrernebenstuhl", "Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrernebenstuhl"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Diverses", "Seat2GetherReportsDataSource_SP_BBNR_UA_Diverses"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_KSW_Zuschnitt", "Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Zuschnitt"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_A_BBNR_Bemerkungen_Zuschnitt", "Seat2GetherReportsDataSource_A_BBNR_Bemerkungen_Zuschnitt"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Divers_98", "Seat2GetherReportsDataSource_SP_BBNR_UA_Divers_98"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_43", "Seat2GetherReportsDataSource_SP_BBNR_UA_43"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_49", "Seat2GetherReportsDataSource_SP_BBNR_UA_49"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_Anbauteile_Zuschnitt_Kissen", "Seat2GetherReportsDataSource_SP_BBNR_Anbauteile_Zuschnitt_Kissen"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_Anbauteile_Zuschnitt", "Seat2GetherReportsDataSource_SP_BBNR_Anbauteile_Zuschnitt"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_A_BBNR_Gessler_gruppiert", "Seat2GetherReportsDataSource_A_BBNR_Gessler_gruppiert"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_A_BBNr_Anzahl_Rücken", "Seat2GetherReportsDataSource_A_BBNr_Anzahl_Rücken"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Fahrernebenstuhl_Stückliste", "Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrernebenstuhl_Stückliste"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_TGR_Vorhang", "Seat2GetherReportsDataSource_SP_BBNR_TGR_Vorhang"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_KSW_Näherei", "Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Näherei"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_A_BBnr_Bemerkungen_Näherei", "Seat2GetherReportsDataSource_A_BBnr_Bemerkungen_Näherei"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Fahrerstuhl", "Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrerstuhl"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Fahrerstuhl_Stückliste", "Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrerstuhl_Stückliste"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_NONFondNoDeck", "Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_NONFondNoDeck"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_NONFondOD", "Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_NONFondOD"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_NONFondUD", "Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_NONFondUD"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_KSW_Montage", "Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Montage"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_KSW_Sonderstuhl", "Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Sonderstuhl"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Schiebestuhl_44", "Seat2GetherReportsDataSource_SP_BBNR_UA_Schiebestuhl_44"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_A_BBnr_Bemerkungen_Montage", "Seat2GetherReportsDataSource_A_BBnr_Bemerkungen_Montage"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_Fond", "Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_Fond"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_FondOD", "Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_FondOD"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_FondUD", "Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_FondUD"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_UA_Kinostuhl_45", "Seat2GetherReportsDataSource_SP_BBNR_UA_Kinostuhl_45"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_A_BBnr_Bemerkungen_Sonderstuhl", "Seat2GetherReportsDataSource_A_BBnr_Bemerkungen_Sonderstuhl"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_SP_BBNR_TGR_Zunschnitt_BA_TG", "Seat2GetherReportsDataSource_SP_BBNR_TGR_Zunschnitt_BA_TG"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_A_BBNr_Sesselblenden_Blockierungen", "Seat2GetherReportsDataSource_A_BBNr_Sesselblenden_Blockierungen"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_A_BBNr_Sesselblenden_Zusatzangaben", "Seat2GetherReportsDataSource_A_BBNr_Sesselblenden_Zusatzangaben"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_T_Auftrag_Bemerkungen", "Seat2GetherReportsDataSource_T_Auftrag_Bemerkungen"));
            e.DataSources.Add(new ReportDataSource("Seat2GetherReportsDataSet_A_BBNr_Gurtschloss_Wandseitig", "Seat2GetherReportsDataSource_A_BBNr_Gurtschloss_Wandseitig"));

        }

    }
}