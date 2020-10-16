﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCMainMenu.ascx.cs" Inherits="AceNews.UserControls.MainMenu" %>

<div class="VerMenu">
    <div class="Latest VMenuItem">
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/" runat="server">آخرین اخبار</asp:HyperLink>
    </div>
    <div class="Politics VMenuItem">
        <asp:HyperLink ID="HyperLink2" NavigateUrl="~/?CatCode=1&Archive=1" runat="server">چند سطر سیاست</asp:HyperLink>
    </div>
    <div class="Socity VMenuItem">
        <asp:HyperLink ID="HyperLink3" NavigateUrl="~/?CatCode=2&Archive=1" runat="server">چند سطر جامعه</asp:HyperLink>
    </div>
    <div class="Socity VMenuItem">
        <asp:HyperLink ID="HyperLink11" NavigateUrl="~/?CatCode=9&Archive=1" runat="server">چند سطر اقتصاد</asp:HyperLink>
    </div>
    <div class="Sport VMenuItem">
        <asp:HyperLink ID="HyperLink4" NavigateUrl="~/?CatCode=3&Archive=1" runat="server">چند سطر ورزش</asp:HyperLink>
    </div>
    <div class="Event VMenuItem">
        <asp:HyperLink ID="HyperLink5" NavigateUrl="~/?CatCode=4&Archive=1" runat="server">چند سطر حوادث</asp:HyperLink>
    </div>
    <div class="Tech VMenuItem">
        <asp:HyperLink ID="HyperLink6" NavigateUrl="~/?CatCode=5&Archive=1" runat="server">چند سطر تکنولوژی</asp:HyperLink>
    </div>
    <div class="Culture VMenuItem">
        <asp:HyperLink ID="HyperLink7" NavigateUrl="~/?CatCode=6&Archive=1" runat="server">چند سطر فرهنگ و هنر</asp:HyperLink>
    </div>
    <div class="Reading VMenuItem">
        <asp:HyperLink ID="HyperLink8" NavigateUrl="~/?CatCode=7&Archive=1" runat="server">چند سطر خواندنی ها</asp:HyperLink>
    </div>
    <div class="Health VMenuItem">
        <asp:HyperLink ID="HyperLink10" NavigateUrl="~/?CatCode=8&Archive=1" runat="server">چند سطر سلامت</asp:HyperLink>
    </div>
    <div class="Photo VMenuItem">
        <asp:HyperLink ID="HyperLink9" NavigateUrl="~/Pic" runat="server">چند فریم عکس</asp:HyperLink>
    </div>
</div>
