<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SideNewsType.ascx.cs"
    Inherits="AceNews.UserControls.SideNewsType" %>
<div class="BoxGray">
    <div class="BoxGrayHeader">
        <h4>
            <asp:Literal ID="lblHeader" runat="server"></asp:Literal></h4>
    </div>
    <div class="BoxGrayContent">
        <asp:Repeater ID="rptItems" EnableViewState="false" runat="server">
            <ItemTemplate>
                <div class="SideNewItem">
                    <asp:HyperLink  Target="_blank" NavigateUrl='<%#"~/News/" + Eval("Code") + ".htm" %>'
                        runat="server">
        <%#Eval("Title").ToString().Replace("<br>", "")%>
                    </asp:HyperLink>
                </div>
                <div class="Line">
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <div class="FLeft">
            <asp:HyperLink ID="hplMore" runat="server">ادامه »</asp:HyperLink>
        </div>
        <div class="Clear">
</div>
    </div>
</div>
<div class="Clear">
</div>
