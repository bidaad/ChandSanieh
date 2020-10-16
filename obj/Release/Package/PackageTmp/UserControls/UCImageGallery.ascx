<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCImageGallery.ascx.cs"
    Inherits="AceNews.UserControls.UCImageGallery" %>
<div class="ImgGallery">
    <div class="hd">
        <h4>
            گزارش تصویری</h4>
    </div>
    <div class="InnerBox">
        <div class="Padder10">
            <div class="Header">
            </div>
            <div class="Middle">
                <script type='text/javascript'>
                    $(window).load(function () {
                        $('#featured').orbit({
                            bullets: true,
                            animationSpeed: 800, 
                            timer: true,
                            captions: true, 
                            animation: 'fade'
                        });
                    });
                </script>
                <table align='center' width='190' height='150' cellspacing='0' cellpadding='0' style='padding: 0px;
                    margin: 0px;'>
                    <tr>
                        <td align='right' style='padding: 0px; margin: 0px;'>
                        
                            <div id='featured' style='display: none;'>
                                <asp:Repeater ID="rptImageGallery" EnableViewState="false" runat="server">
                                    <ItemTemplate>
                                        
                                        <div>
                                            <asp:HyperLink runat="server" NavigateUrl='<%# "~/News/" + Eval("Code") + ".htm" %>'
                                                Target="_blank">
                                            <asp:Image runat="server" ImageUrl=<%#Eval("PicFile1") %> AlternateText=<%#Eval("Title") %> rel="rel1" />
                                            <div class='orbit-caption'>
                                            <span>&nbsp;<%#Eval("Title") %>&nbsp;</span>
                                        </div>
                                            </asp:HyperLink>
                                        </div>
                                        
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="FLeft3">
                <asp:HyperLink ID="HyperLink2" NavigateUrl="~/ImageGalleryArchive.aspx" runat="server">آرشیو »</asp:HyperLink>
            </div>
            <div class="Footer">
            </div>
        </div>
    </div>
</div>
