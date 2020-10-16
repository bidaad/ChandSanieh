<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MainRoot.Master"
    CodeBehind="Default.aspx.cs" Inherits="AceNews.MultiMedia.Default" %>

<%@ Register Src="~/UserControls/UCComments.ascx" TagName="UCComments" TagPrefix="UCC" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <link href="../Styles/prettyPhoto.css" type="text/css" rel="stylesheet" media="all" />
    <script src="../scripts/jquery.prettyPhoto.js" type="text/javascript"></script>
    <div class="InnerPage">
        <div class="GrayContent">
            <div class="ContentTop">
            </div>
            <div class="ContentInner">
                <div>
                    <div class="FullNewsBox">
                        <div>
                            <div class="Padder5">
                                <div class="ShowNews">
                                    <div>
                                        <div class="FullNewsTitle">
                                            <asp:Label ID="lblTitle" ClientIDMode="Static" runat="server"></asp:Label></div>
                                    </div>
                                    
                                    <asp:Panel ID="pnlPlayMusic" Style="margin: 10px;" runat="server" Visible="false">
                                        <script type="text/javascript" src="../Scripts/audio-player.js"></script>
                                        <script type="text/javascript">
                                            AudioPlayer.setup("../Scripts/player.swf", {
                                                width: 290
                                            });  
                                        </script>
                                        <div>
                                            <table>
                                                <tr>
                                                    <td style="padding-bottom: 8px;">
                                                        <asp:HyperLink ID="hplDlSound" ImageUrl="~/images/Site/download-audio.jpg" runat="server"></asp:HyperLink>
                                                    </td>
                                                    <td>
                                                        <p id="audioplayer_1" style="direction: rtl;">
                                                            در حال بارگذاری ...</p>
                                                        <script type="text/javascript">
                                                            AudioPlayer.embed("audioplayer_1", { soundFile: "..<%=MusicsFileName %>" });  
                                                        </script>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2">
                                                        <div class="cSoundCont">
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Image ID="imgSound" CssClass="imgSound" runat="server" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="lblSoundDesc" runat="server" Text=""></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </div>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </asp:Panel>
                                    <asp:Panel ID="pnlMovies" Style="margin: 10px;" runat="server" Visible="false">
                                        <script type="text/javascript" src="../Scripts/jwplayer.js"></script>
                                        <div>
                                            <div id="mediaplayer">
                                            </div>
                                            <script type="text/javascript">
                                                jwplayer("mediaplayer").setup({
                                                    flashplayer: "../swf/player.swf",
                                                    file: "..<%=MovieFileName%>",
                                                    image: "../images/MPreview.jpg"
                                                });
                                            </script>
                                        </div>
                                        <div style="margin-top: 5px;">
                                            <asp:HyperLink ID="hplDlMovie" ToolTip="دریافت فایل فیلم" ImageUrl="~/images/Site/download-video.jpg"
                                                runat="server">دریافت فایل فیلم</asp:HyperLink>
                                        </div>
                                    </asp:Panel>
                                    <div class="clearfloat">
                                    </div>
                                    <asp:Panel ID="pnlPictures" Style="margin: 10px;" runat="server" Visible="false">
                                        <ul class="gallery clearfix">
                                            <asp:DataList ID="rptPictures" CssClass="tblAlbumPictures" RepeatDirection="Horizontal"
                                                RepeatColumns="3" EnableViewState="false" runat="server">
                                                <ItemTemplate>
                                                    <li><a href="../..<%#Eval("PicFile") %>" rel="prettyPhoto[gallery2]">
                                                        <img src="../..<%#Eval("PicFile") %>" height="100" alt="<%#Eval("Title") %>" /></a></li>
                                                </ItemTemplate>
                                            </asp:DataList>
                                        </ul>
                                        <script type="text/javascript" charset="utf-8">
                                            $(document).ready(function () {
                                                $("area[rel^='prettyPhoto']").prettyPhoto();

                                                $(".gallery:first a[rel^='prettyPhoto']").prettyPhoto({ animation_speed: 'normal', theme: 'light_square', slideshow: 9000, autoplay_slideshow: true });

                                            });
                                        </script>
                                    </asp:Panel>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="Clear">
                </div>
            </div>
            <div class="ContentBot">
            </div>
        </div>
    </div>
    <UCC:UCComments runat="server" HCSectionCode="2" id="UCComments1">
    </UCC:UCComments>
    <div class="Clear">
    </div>
    <script type="text/javascript">
        $("#totop-scroller").click(function () {
            $("html, body").animate({ scrollTop: 0 }, "slow");
            return false;
        });
    </script>
</asp:Content>
