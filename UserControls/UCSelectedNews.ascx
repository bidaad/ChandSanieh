<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCSelectedNews.ascx.cs"
    Inherits="AceNews.UserControls.UCSelectedNews" %>
<div class="topNewsBox">
    <div id="topNewsBox">
        <asp:Repeater ID="rptNews" runat="server">
            <ItemTemplate>
                <div class="topNews">
                    <asp:HyperLink runat="server" CssClass="cTitle" Target="_blank" ToolTip='<%#DataBinder.Eval(Container.DataItem, "Title") + " " + FormatDateTime( Eval("NewsDate"))  %>'
                        NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" +DataBinder.Eval(Container.DataItem, "Code")  %>'>
                        <asp:Image ID="Image2" CssClass="cPicCycle" ImageUrl='<%#Eval("PicFile2") %>' runat="server" />
                        <div class="news-caption"><%#Tools.ShowBriefText(Eval("Title"), 750)%></div>
                    </asp:HyperLink>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>

