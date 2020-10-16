<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCMostViewed.ascx.cs"
    Inherits="ASNoor.UserControls.UCMostViewed" %>
<div class="MarginerRightBox">
    <div class="RightBoxCaption">
        <asp:Label ID="ltrTitle" runat="server" Text="الاکثر قراءة"></asp:Label>
        
    </div>
    <div class="Clear"></div>
    <div class="WhiteContent">
        <div class="MostViewedList">
            <asp:Repeater ID="rptMostNews" runat="server">
                <ItemTemplate>
                    <div class="NewsItem">
                        <asp:HyperLink  NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" + Eval("Code")  %>'
                            ToolTip='<%#Eval("Title") %>' runat="server"><%#Tools.ShowBriefText(Eval("Title"),30) %></asp:HyperLink>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="Clear">
        </div>
    </div>
    <div class="BotLine"></div>
</div>
