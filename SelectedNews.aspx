<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectedNews.aspx.cs" Inherits="AceNews.SelectedNews" %>

<%@ Register Src="~/UserControls/UCSelectedNews.ascx" TagName="UCSelectedNews" TagPrefix="UCSN" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles/jd.gallery.css" type="text/css" media="screen"
        charset="utf-8" />
    <script src="scripts/mootools-1.2.1-core-yc.js" type="text/javascript"></script>
    <script src="scripts/mootools-1.2-more.js" type="text/javascript"></script>
    <script src="scripts/History.js" type="text/javascript"></script>
    <script src="scripts/History.Routing.js" type="text/javascript"></script>
    <script src="scripts/jd.gallery.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    
    <div>
        <script type="text/javascript">
            function startGallery() {
                History.start();
                var myGallery = new gallery($('myGallery'), {
                    timed: true
                });
            }
            window.addEvent('domready', startGallery);
        </script>
        <table style="width: 100%;" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td class="BoxNoor1TopLeft">
            </td>
            <td class="BoxNoor1Top">
            </td>
            <td class="BoxNoor1TopRight">
            </td>
        </tr>
        <tr>
            <td class="BoxNoor1_Left">
            </td>
            <td class="BoxNoor1_Content">
                <div class="content">
            <div id="myGallery">
                <asp:Repeater ID="rptNews" runat="server">
                    <ItemTemplate>
                        <div class="imageElement">
                            <h3>
                                <%#Eval("Title") %></h3>
                            <p>
                                <%#Eval("Abstract") %></p>
                            <asp:HyperLink runat="server" NavigateUrl='#' Target="_top"  Title="مشاهده خبر" CssClass="open" ></asp:HyperLink>
                            <asp:Image runat="server" ImageUrl='<%#"~/" + Eval("PicFile1") %>' class="full" />
                            <asp:Image runat="server" ImageUrl='<%#"~/" + Eval("PicFile1") %>' class="thumbnail" />
                            
                        </div>
                        
                        
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
                <div class="Clear">
                </div>
            </td>
            <td class="BoxNoor1_Right">
            </td>
        </tr>
        <tr>
            <td class="BoxNoor1BotLeft">
            </td>
            <td class="BoxNoor1_Bot">
            </td>
            <td class="BoxNoor1BotRight">
            </td>
        </tr>
    </table>
        
    </div>
    </form>
</body>
</html>
