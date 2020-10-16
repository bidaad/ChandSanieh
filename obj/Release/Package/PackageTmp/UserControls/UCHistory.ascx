<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCHistory.ascx.cs" Inherits="AceNews.UserControls.UCHistory" %>
<div class="EditorChoice">
    <div class="HeaderCont">
        <h3 class="Header">
            <asp:HyperLink ID="HyperLink2" NavigateUrl="~/AroundWorld" runat="server">دور دنیا در چند ثانیه</asp:HyperLink>
        </h3>
    </div>
    <div class="MayNotReadsInfoCont">
        <asp:Repeater ID="rptPics" runat="server">
            <ItemTemplate>
                <div>
                    <asp:HyperLink ID="HyperLink1" ToolTip='<%#Eval("Title") %>' CssClass="NewsManHeader"
                        NavigateUrl='<%#"~/AroundWorld/ShowItem.aspx?Code=" + Eval("Code") %>' runat="server">
                                        <%#Eval("Title") %>
                    </asp:HyperLink>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
