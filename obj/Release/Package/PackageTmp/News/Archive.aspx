<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MainRoot.Master"
    Title="آرشیو اخبار" CodeBehind="Archive.aspx.cs" Inherits="AceNews.NewsFolder.Archive" %>

<%@ Register Src="~/UserControls/PersianCalendar.ascx" TagName="PersianCalendar"
    TagPrefix="UC" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <div class="MainDataCont">
        <ul class="Calendar">
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar1" />
            </li>
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar2" />
            </li>
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar3" />
            </li>
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar4" />
            </li>
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar5" />
            </li>
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar6" />
            </li>
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar7" />
            </li>
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar8" />
            </li>
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar9" />
            </li>
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar10" />
            </li>
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar11" />
            </li>
            <li class="Months">
                <UC:PersianCalendar runat="server" ID="PersianCalendar12" />
            </li>
        </ul>
        <%--<asp:Repeater ID="rptMonths" runat="server">
            <ItemTemplate>
                
            </ItemTemplate>
        </asp:Repeater>--%>
    </div>
</asp:Content>
