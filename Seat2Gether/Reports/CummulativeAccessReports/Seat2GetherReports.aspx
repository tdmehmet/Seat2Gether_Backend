<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Seat2GetherReports.aspx.cs" Inherits="Seat2Gether.Reports.Seat2GetherReports" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Seat2Gether Reports</title>
    <link rel="stylesheet" type="text/css" href="../print.button.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div id="post" style="width: 50%; height: 100%; float: left;">
            <rsweb:ReportViewer ID="Seat2GetherReportsViewer" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="100%" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
                <LocalReport ReportPath="Reports\CummulativeAccessReports\Seat2GetherReports.rdlc">
                    <DataSources>
                        <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_A_BBNR" Name="Seat2GetherReportsDataSet_A_BBNR" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_Stammdaten" Name="Seat2GetherReportsDataSet_SP_BBNR_Stammdaten" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_T_ST_Variante_Stoffangabe" Name="Seat2GetherReportsDataSet_T_ST_Variante_Stoffangabe" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_23" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_23" />

                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_TGR_Zuschnitt_BA_TG" Name="Seat2GetherReportsDataSet_SP_BBNR_TGR_Zuschnitt_BA_TG" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_Anbauteile_Zuschnitt" Name="Seat2GetherReportsDataSet_SP_BBNR_Anbauteile_Zuschnitt" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_Anbauteile_Zuschnitt_Rücken" Name="Seat2GetherReportsDataSet_SP_BBNR_Anbauteile_Zuschnitt_Rücken" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrernebenstuhl" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Fahrernebenstuhl" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Diverses" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Diverses" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Zuschnitt" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_KSW_Zuschnitt" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_A_BBNR_Bemerkungen_Zuschnitt" Name="Seat2GetherReportsDataSet_A_BBNR_Bemerkungen_Zuschnitt" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Divers_98" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Divers_98" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_43" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_43" />

                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_49" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_49" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_A_BBNR_Gessler_gruppiert" Name="Seat2GetherReportsDataSet_A_BBNR_Gessler_gruppiert" />

                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_A_BBNr_Anzahl_Rücken" Name="Seat2GetherReportsDataSet_A_BBNr_Anzahl_Rücken" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_Anbauteile_Zuschnitt_Kissen" Name="Seat2GetherReportsDataSet_SP_BBNR_Anbauteile_Zuschnitt_Kissen" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrernebenstuhl_Stückliste" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Fahrernebenstuhl_Stückliste" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_TGR_Vorhang" Name="Seat2GetherReportsDataSet_SP_BBNR_TGR_Vorhang" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Näherei" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_KSW_Näherei" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_A_BBnr_Bemerkungen_Näherei" Name="Seat2GetherReportsDataSet_A_BBnr_Bemerkungen_Näherei" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrerstuhl" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Fahrerstuhl" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrerstuhl_Stückliste" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Fahrerstuhl_Stückliste" />

                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_NONFondNoDeck" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_NONFondNoDeck" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_NONFondOD" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_NONFondOD" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_NONFondUD" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_NONFondUD" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Montage" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_KSW_Montage" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Sonderstuhl" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_KSW_Sonderstuhl" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Schiebestuhl_44" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Schiebestuhl_44" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_A_BBnr_Bemerkungen_Montage" Name="Seat2GetherReportsDataSet_A_BBnr_Bemerkungen_Montage" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_Fond" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_Fond" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_FondOD" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_FondOD" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_FondUD" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Anbauteile_MOntage_FondUD" />

                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_UA_Kinostuhl_45" Name="Seat2GetherReportsDataSet_SP_BBNR_UA_Kinostuhl_45" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_A_BBnr_Bemerkungen_Sonderstuhl" Name="Seat2GetherReportsDataSet_A_BBnr_Bemerkungen_Sonderstuhl" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_SP_BBNR_TGR_Zunschnitt_BA_TG" Name="Seat2GetherReportsDataSet_SP_BBNR_TGR_Zunschnitt_BA_TG" />

                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_A_BBNr_Sesselblenden_Blockierungen" Name="Seat2GetherReportsDataSet_A_BBNr_Sesselblenden_Blockierungen" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_A_BBNr_Sesselblenden_Zusatzangaben" Name="Seat2GetherReportsDataSet_A_BBNr_Sesselblenden_Zusatzangaben" />
                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_T_Auftrag_Bemerkungen" Name="Seat2GetherReportsDataSet_T_Auftrag_Bemerkungen" />

                            <rsweb:ReportDataSource DataSourceId="Seat2GetherReportsDataSource_A_BBNr_Gurtschloss_Wandseitig" Name="Seat2GetherReportsDataSet_A_BBNr_Gurtschloss_Wandseitig" />


                    </DataSources>
                </LocalReport>


            </rsweb:ReportViewer>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_A_BBNR_Bemerkungen_Zuschnitt" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT BBNr, Bemerkung FROM A_BBnr_Bemerkungen_Zuschnitt WHERE (BBNr = @BBNr)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_A_BBNr_Gurtschloss_Wandseitig" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT BBNr, Programm, Anzahl_Gurt_Wandseitig, Spalte, EB, Bezeichnung, Deck FROM A_BBNr_Gurtschloss_Wandseitig WHERE (BBNr = @BBNr)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_T_Auftrag_Bemerkungen" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT AuftragsNr, Bemerkung, Zuschnitt, Näherei, Sonderstuhl, Montage, Sesselblenden FROM T_Auftrag_Bemerkungen WHERE (Sesselblenden = 1) AND (AuftragsNr = @AuftragsNr)">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_A_BBNr_Sesselblenden_Zusatzangaben" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT BBNr, Bezeichnung, Menge, lfdNr_Merkmal FROM A_BBNr_Sesselblenden_Zusatzangaben WHERE (BBNr = @BBNr)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_A_BBNr_Sesselblenden_Blockierungen" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT BBNr, Spalte, Anzahl_Programm, Programm_doppelt, Programm_einzeln, Blockierungen, Gurt_Gangseitig, Wippe, Bezeichnung_Verstellhebel, AuftragsNr, Seite FROM A_BBNr_Sesselblenden_Blockierungen WHERE (BBNr = @BBNr)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_TGR_Zunschnitt_BA_TG" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_TGR_Zuschnitt_BA_TG" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_A_BBnr_Bemerkungen_Sonderstuhl" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT BBNr, Bemerkung FROM A_BBnr_Bemerkungen_Sonderstuhl WHERE (BBNr = @BBNr)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Kinostuhl_45" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Kinostuhl_45" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_FondUD" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Anbauteile_MOntage_Fond" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" Type="String" />
                    <asp:Parameter DefaultValue="UD" Name="Deck" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_FondOD" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Anbauteile_MOntage_NONFond" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" Type="String" />
                    <asp:Parameter DefaultValue="OD" Name="Deck" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_Fond" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Anbauteile_MOntage_Fond" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" Type="String" />
                    <asp:Parameter DefaultValue="OD" Name="Deck" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_A_BBnr_Bemerkungen_Montage" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT BBNr, Bemerkung FROM A_BBnr_Bemerkungen_Montage WHERE (BBNr = @BBNr)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Schiebestuhl_44" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Schiebestuhl_44" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Sonderstuhl" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_KSW_Sonderstuhl" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Montage" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_KSW_Montage" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_NONFondUD" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Anbauteile_MOntage_NONFond" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" Type="String" />
                    <asp:Parameter DefaultValue="UD" Name="Deck" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_NONFondOD" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Anbauteile_MOntage_NONFond" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" Type="String" />
                    <asp:Parameter DefaultValue="OD" Name="Deck" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Anbauteile_MOntage_NONFondNoDeck" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Anbauteile_MOntage_NONFond" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" Type="String" />
                    <asp:Parameter DefaultValue="-" Name="Deck" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrerstuhl_Stückliste" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Fahrerstuhl_Stückliste" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrerstuhl" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Fahrerstuhl" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Näherei" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_KSW_Näherei" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_TGR_Vorhang" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_TGR_Vorhang" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrernebenstuhl_Stückliste" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Fahrernebenstuhl_Stückliste" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_Anbauteile_Zuschnitt_Kissen" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_Anbauteile_Zuschnitt_Kissen" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_A_BBnr_Bemerkungen_Näherei" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT BBNr, Bemerkung FROM A_BBnr_Bemerkungen_Näherei WHERE (BBNr = @BBNr)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_A_BBNr_Anzahl_Rücken" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT BBNr, Stuhltyp, was, Anzahl FROM A_BBNr_Anzahl_Rücken WHERE (BBNr = @BBNr)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_A_BBNR_Gessler_gruppiert" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT BBNr, TNR_Gessler, Bestellung, Bezeichnung, ID_Gruppe, Gruppe, Sortierung, Menge, Soll_Termin, AuftragsNr FROM A_BBNR_Gessler_gruppiert WHERE (BBNr = @BBNr)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_Anbauteile_Zuschnitt" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_Anbauteile_Zuschnitt" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_49" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_49" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_43" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_43" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Divers_98" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Divers_98" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_Bemerkungen_Zuschnitt" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT BBNr, Bemerkung FROM A_BBnr_Bemerkungen_Zuschnitt WHERE (BBNr = @BBNr)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_KSW_Zuschnitt" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_KSW_Zuschnitt" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Diverses" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Diverses" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_Fahrernebenstuhl" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_Fahrernebenstuhl" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_Anbauteile_Zuschnitt_Rücken" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_Anbauteile_Zuschnitt_Rücken" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_TGR_Zuschnitt_BA_TG" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_TGR_Zuschnitt_BA_TG" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_UA_23" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_UA_23" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_T_ST_Variante_Stoffangabe" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT lfdNr_Variante_Stoffangabe, AuftragsNr, Bezeichnung, angelegt_am, angelegt_von, Rücken, Kopfteil, Keder, Tasche_Kopflatz FROM T_ST_Variante_Stoffangabe WHERE (AuftragsNr = @AuftragsNr)">
                <SelectParameters>
                    <asp:SessionParameter Name="AuftragsNr" SessionField="AuftragsNr" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_SP_BBNR_Stammdaten" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="sp_BBNR_Stammdaten" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBnr" QueryStringField="BBNr" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="Seat2GetherReportsDataSource_A_BBNR" runat="server" ConnectionString="<%$ ConnectionStrings:Seat2GetherDBContext %>" SelectCommand="SELECT BBNr, AuftragsNr, Anzahl_links, Anzahl_rechts, Anzahl_Fond, Anzahl_Clubecke, Stuhltyp, Soll_Termin, Reihenfolge, Ist_Termin, angelegt_am, angelegt_von, lfdNr_Status, Status_gesetzt_am, BBNr_Farbe_Bezug, BBNr_Farbe_Lederkopfteil, Länderkennzeichen, Kunde, intern, Anzahl_UD_links, Anzahl_UD_rechts, Werk, Sitzeinteilung, Belegung, Ansprechpartner_Vertrieb, Ansprechpartner_AZ, EU_Richtilinie, Abnahme, Baumuster, Maktx, FZG_pro_AuftragsNr, BBNr_Min, BBNr_Max, Steuern_nach, Jahr, Anzahl_Lose, Typ, Standort FROM A_BBNR WHERE (BBNr = @BBNr)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="BBNr" QueryStringField="BBNr" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
