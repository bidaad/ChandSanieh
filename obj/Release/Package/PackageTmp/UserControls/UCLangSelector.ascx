<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCLangSelector.ascx.cs" Inherits="ASNoor.UserControls.UCLangSelector" %>
<div class="LangSelector">
<ul>
    <li>
        <asp:HyperLink ID="hplEn" NavigateUrl="~/?Lang=3" runat="server">English</asp:HyperLink>
    </li>
    <li>&nbsp;|&nbsp;</li>
    <li>
        <asp:HyperLink ID="hplAr" NavigateUrl="~/?Lang=1" runat="server">العربیة</asp:HyperLink>
    </li>
    <li>&nbsp;|&nbsp;</li>
    <li>
        <asp:HyperLink ID="hplFarsi" NavigateUrl="~/?Lang=2" runat="server">فارسی</asp:HyperLink>
    </li>
</ul>
</div>