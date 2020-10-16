<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SiteMapNews.aspx.cs" Inherits="AceNews.SiteMapNews" %>
<urlset xmlns="http://www.sitemaps.org/schemas/sitemap/0.9"
        xmlns:image="http://www.google.com/schemas/sitemap-image/1.1"
        xmlns:video="http://www.google.com/schemas/sitemap-video/1.1">
<asp:Repeater runat="server" ID="rptNews" EnableViewState="False">
<ItemTemplate>
    <url>
        <loc><%#"http://www.AceNews.ir/News/ShowNews.aspx?Code=" + Eval("Code") %></loc>
        <image:image>
            <image:loc><%#"http://www.acenews.ir" + Eval("PicFile2")%></image:loc> 
        </image:image>
    </url>
</ItemTemplate>
</asp:Repeater>
</urlset>