<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MostViewedNews.ascx.cs" Inherits="ASNoor.UserControls.MostViewedNews" %>
<div class="BoxGray">
    <div class="BoxGrayHeader">
        <h4>
            <asp:Literal ID="lblHeader" Text="پر بیننده ترین خبرها" runat="server"></asp:Literal></h4>
    </div>
    <div class="BoxGrayContent">
        <asp:Repeater ID="rptItems" EnableViewState="false" runat="server">
            <ItemTemplate>
                <div class="SideNewItem">
                    <asp:HyperLink ID="HyperLink1" Target="_blank" NavigateUrl='<%#"~/News/" + Eval("Code") + ".htm" %>' runat="server">
        <%#Eval("Title").ToString().Replace("<br>", "")%>
                    </asp:HyperLink>
                </div>
                <div class="Line">
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <div class="Clear">
</div>
    </div>
</div>
<div class="Clear">
</div>