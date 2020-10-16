<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MainRoot.Master"
    CodeBehind="Default.aspx.cs" Inherits="AceNews.NewsFolder.Default" %>

<%@ Register Src="~/UserControls/UCNewsList.ascx" TagName="NewsList" TagPrefix="UCNewsList" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <div class="MainDataCont">
        <UCNewsList:NewsList id="NewsList1" TimeFormat="PerfectTime" runat="server">
        </UCNewsList:NewsList>
    </div>
</asp:Content>
