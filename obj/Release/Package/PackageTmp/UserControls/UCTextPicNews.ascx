<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCTextPicNews.ascx.cs"
    Inherits="AceNews.UserControls.UCTextPicNews" %>
<div class="MayNotReads">
    <div class="HeaderCont">
        <h3 class="Header">
            <asp:HyperLink ID="hplArchive" NavigateUrl="~/News/TextNewsArchive.aspx" runat="server">
                عکس خبری
            </asp:HyperLink>
        </h3>
    </div>
    <div class="">
        <asp:Repeater ID="rptNews" runat="server">
            <ItemTemplate>
                <div class="TextPicNews">
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="SideTitle" Target="_blank"
                        NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" +DataBinder.Eval(Container.DataItem, "Code")  %>'>
                    <%#Eval("Title") %>
                    </asp:HyperLink>
                </div>
                <div class="Clear">
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
