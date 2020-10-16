<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MoreNews.aspx.cs" Inherits="AceNews.PostBack.MoreNews" %>
<%@ Register Src="~/UserControls/UCNewsList.ascx" TagName="NewsList" TagPrefix="UCNewsList" %>

 <UCNewsList:NewsList id="NewsList1" ShowHeader="false" runat="server" />

