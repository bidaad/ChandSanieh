<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCDaySubjects.ascx.cs"
    Inherits="AceNews.UserControls.UCDaySubjects" %>
<div class="DaySubjectCont">
    <div class="HeaderCont">
        <h3 class="Header">
            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/DaySubjects" runat="server">موضوع روز</asp:HyperLink>
        </h3>
    </div>
    <div class="DaySubjectInfoCont">
        <div class="Title">
            <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblDescription" runat="server" Text=""></asp:Label>
        </div>
    </div>
</div>
