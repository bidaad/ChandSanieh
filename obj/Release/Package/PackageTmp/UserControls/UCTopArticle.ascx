<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCTopArticle.ascx.cs"
    Inherits="AceNews.UserControls.UCTopArticle" %>
<div class="MarginerRightBox">
    <div class="TopArticleCaption">
    </div>
    <div class="WhiteContent">
        <asp:Repeater ID="rptTopArticles" runat="server">
            <ItemTemplate>
                <div class="TopArticleCont">
                <div class="TopArticlePic">
                    <asp:HyperLink runat="server">
                        <asp:Image ID="Image1" BorderWidth="2" CssClass="BorderPic" ImageUrl='<%#"~/" + Eval("PicFile1") %>'
                            runat="server" />
                    </asp:HyperLink>
                </div>
                <span class="TopArticleTitle">
                    <asp:HyperLink NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" + Eval("Code")  %>' runat="server"><%#Eval("Title") %></asp:HyperLink>
                </span>
                <br />
                <span class="Author">
                    <%#Eval("Author") %>
                </span>
                <br />
                <span class="TopArticleAbstract">
                    <%#Eval("Abstract") %>
                </span>
                <div class="Clear">
                </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <div class="BotLine">
    </div>
</div>
