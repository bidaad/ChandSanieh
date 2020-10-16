<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCDayPhotos.ascx.cs" Inherits="AceNews.UserControls.UCDayPhotos" %>
<div class="DaySubjectCont">
    <div class="HeaderCont">
        <h3 class="Header">
            چهره روز
        </h3>
    </div>
    <div class="DaySubjectInfoCont">
        <div class="Title">
            <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Image ID="imgPicFile" runat="server" />
        </div>
    </div>
</div>