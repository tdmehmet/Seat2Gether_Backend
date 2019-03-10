<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaterialsByStation.aspx.cs" Inherits="Seat2Gether.Reports.ExReports.MaterialsReport.MaterialsByStation.MaterialsByStation" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1790px">
            <LocalReport ReportPath="Reports\ExReports\MaterialsReport\MaterialsByStation\MaterialsByStation.rdlc">
                
            </LocalReport>
        </rsweb:ReportViewer>
    </form>
</body>
</html>
