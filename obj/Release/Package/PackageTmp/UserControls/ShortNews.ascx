<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShortNews.ascx.cs" Inherits="AceNews.UserControls.ShortNews" %>
<div>
    <div class="TopBar">
        <h3>
            اخبار کوتاه</h3>
    </div>
    <div class="Padder2">
        <asp:Repeater ID="rptSideNews" EnableViewState="false" runat="server">
            <ItemTemplate>
                <div>
                    <div class="cSideNews">
                        <div class="Title">
                            <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" ToolTip='<%#DataBinder.Eval(Container.DataItem, "Title") %>'
                                NavigateUrl='<%#"~/News/" +DataBinder.Eval(Container.DataItem, "Code") + ".htm" %>'><%#Tools.ShowBriefText(DataBinder.Eval(Container.DataItem, "Title"), 90)%></asp:HyperLink>
                        </div>
                        <%--<div class="NewsDate">
                                        <%#FormatDate( Eval("NewsDate")) %>
                                    </div>--%>
                    </div>
                    <div class="Clear">
                    </div>
                    <div class="Line">
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
