<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCRelatedNews.ascx.cs" Inherits="AceNews.UserControls.UCRelatedNews" %>
<div class="MarginerRightBox">
    <div class="RightBoxCaption">
        <asp:Literal ID="ltrTitle" runat="server">الأخبار المتعلقة</asp:Literal>
    </div>
    <div class="Clear"></div>
    <div class="WhiteContent">
        <div class="MostViewedList">
            <asp:Repeater ID="rptRelatedNews" runat="server">
                <ItemTemplate>
                    <div class="NewsItem">
                        <asp:HyperLink  NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" + Eval("RelatedNewsCode")  %>'
                            ToolTip='<%#Eval("Title") %>' runat="server"><%#Tools.ShowBriefText(Eval("Title"),35) %></asp:HyperLink>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="Clear">
        </div>
    </div>
    <div class="BotLine"></div>
</div>