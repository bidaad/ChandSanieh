<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCMayNotReads.ascx.cs"
    Inherits="AceNews.UserControls.UCMayNotReads" %>
<div class="MayNotReads">
    <div class="HeaderCont">
        <h3 class="Header">
            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/MayNotReads" runat="server">شاید نخوانده باشید</asp:HyperLink>
        </h3>
    </div>
    <div class="MayNotReadsInfoCont">
        <asp:Repeater ID="rptMayNotReads" runat="server">
            <ItemTemplate>
                <div>
                    <%#Eval("Title") %>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
