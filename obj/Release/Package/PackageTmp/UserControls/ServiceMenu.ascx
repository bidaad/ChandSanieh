<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ServiceMenu.ascx.cs" Inherits="AceNews.UserControls.ServiceMenu" %>
<div class="MeuHeader">
خدمات
</div>
<ul class="MainMenu">
    <li>
        <asp:HyperLink  NavigateUrl="~/AdSearch.aspx" runat="server">جستجو</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink  NavigateUrl="~/ContactUs.aspx" runat="server">ارتباط با ما</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink NavigateUrl="~/OurWord.aspx" runat="server">سخن ما</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink NavigateUrl="~/Links" runat="server">پیوندها</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink NavigateUrl="~/RSS.xml" runat="server">نسخه RSS</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink NavigateUrl="~/Reg.aspx" runat="server">پیام مستقیم</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink NavigateUrl="~/Reg.aspx" runat="server">اعلام مشکلات سایت</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink NavigateUrl="~/Reg.aspx" runat="server">خبرنگار افتخاری</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink NavigateUrl="~/Reg.aspx" runat="server">پیشنهاد سوژه</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink NavigateUrl="~/Reg.aspx" runat="server">درخواست تبلیغ</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink NavigateUrl="~/SiteMap.aspx" runat="server">نقشه سایت</asp:HyperLink>
    </li>
</ul>
