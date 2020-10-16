<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCTabContents.ascx.cs"
    Inherits="AceNews.UserControls.UCTabContents" %>
<div class="BoxNoor1" style="margin-top: 5px;">
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
                <div id="tabContents" class="usual">
                    <ul>
                        <li><a href="#Content-1">یادداشت</a></li>
                        <li><a href="#Content-2">مقاله</a></li>
                    </ul>
                    <div id="Content-1">
                        <asp:Repeater ID="rptNotes" runat="server">
                            <HeaderTemplate>
                                <ul class="ContentTabs">
                            </HeaderTemplate>
                            <ItemTemplate>
                                <li>
                                    <div class="ContentImg">
                                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" + Eval("Code")  %>'
                                            runat="server">
                                            <asp:Image ID="Image1" ImageUrl='<%#ShowPic(Eval("PicFile1")) %>' runat="server" />
                                        </asp:HyperLink>
                                    </div>
                                    <div class="ContentTabLink">
                                        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" + Eval("Code")  %>'
                                            runat="server">
                                            <%#Eval("Title") %>
                                        </asp:HyperLink>
                                    </div>
                                </li>
                            </ItemTemplate>
                            <FooterTemplate>
                                </ul>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                    <div id="Content-2">
                        <asp:Repeater ID="rptArticles" runat="server">
                            <HeaderTemplate>
                                <ul class="ContentTabs">
                            </HeaderTemplate>
                            <ItemTemplate>
                                <li>
                                    <div class="ContentImg">
                                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" + Eval("Code")  %>'
                                            runat="server">
                                            <asp:Image ID="Image1" BorderWidth="2" ImageUrl='<%#ShowPic(Eval("PicFile1")) %>' runat="server" />
                                        </asp:HyperLink>
                                    </div>
                                    <div class="ContentTabLink">
                                        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" + Eval("Code")  %>'
                                            runat="server">
                    <%#Eval("Title") %>
                                        </asp:HyperLink>
                                    </div>
                                </li>
                            </ItemTemplate>
                            <FooterTemplate>
                                </ul>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                    
                    <div class="Clear">
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
<script type="text/javascript">
    $(function () {
        $("#tabContents").tabs();
    });
</script>
