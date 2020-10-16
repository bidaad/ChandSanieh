<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCNotes.ascx.cs" Inherits="AceNews.UserControls.UCNotes" %>
<div class="DaySubjectCont">
    <div class="HeaderCont">
        <h3 class="Header">
            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Notes" runat="server">نکته</asp:HyperLink>
        </h3>
    </div>
    <div class="DaySubjectInfoCont">
        <div class="Title">
            <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
        </div>
        <ul class="gallery clearfix"><li>
        <asp:HyperLink ID="hplLargePic" rel="prettyPhoto[gallery1]" runat="server">
            <asp:Image ID="imgPic" CssClass="NotePic" runat="server" />
        </asp:HyperLink>
        </li></ul>
        <div>
            <asp:Label ID="lblDescription" runat="server" Text=""></asp:Label>
        </div>
    </div>
</div>
