<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCMovieSound.ascx.cs"
    Inherits="AceNews.UserControls.UCMovieSound" %>
<div class="MarginerRightBox">
    <div>
        <table class="tblMediaSelector">
            <tr>
                <td>
                    <div onclick="MMToggle(0)" id="tab0" class="RightBoxCaption">
                        <asp:Literal ID="ltrMovies" runat="server">افلام</asp:Literal>
                    </div>
                </td>
                <td>
                    <div onclick="MMToggle(1)" id="tab1" class="RightBoxCaptionNoBorder">
                        <asp:Literal ID="ltrSounds" runat="server">الصوت</asp:Literal>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <div class="Clear">
    </div>
    <div>
        <div id="content0" style="display: block;">
            <div>
                <asp:Panel runat="server" ID="pnlLatestMovies" class="LatestMovies">
                    <asp:Repeater ID="rptMovies" runat="server">
                        <HeaderTemplate>
                            <ul class="MMItems">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="PicItems">
                                <div class="RightText">
                                    <asp:HyperLink ID="HyperLink2" CssClass="TopMovieTitle" NavigateUrl='<%#"~/MultiMedia/?Code=" + Eval("Code")  %>'
                                        runat="server">
                                        <asp:Image ID="Image1" CssClass="MMSmallPic" ImageUrl='<%#"~/" + Eval("PicFile")  %>'
                                            runat="server" />
                                    </asp:HyperLink>
                                </div>
                                <div class="MMCaption">
                                    <asp:HyperLink ID="HyperLink1" CssClass="TopMovieTitle" NavigateUrl='<%#"~/MultiMedia/?Code=" + Eval("Code")  %>'
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
                    <script>
                        $(function () {
                            $(".LatestMovies").jCarouselLite({
                                btnNext: ".MoviePre",
                                btnPrev: ".MovieNext",
                                speed: 2000,
                                visible: 1
                            });
                        });
                    </script>
                </asp:Panel>
                <div class="MMPreNext">
                    <div class="MoviePre">
                    </div>
                    <div class="MovieNext">
                    </div>
                </div>
                <div class="Clear">
                </div>
            </div>
        </div>
        <div id="content1">
            <div class="MovieSoundList">
                <asp:Repeater ID="rptSounds" runat="server">
                    <ItemTemplate>
                        <div class="MMItem">
                            <asp:HyperLink ID="HyperLink1" CssClass="TopMovieTitle" NavigateUrl='<%#"~/MultiMedia/?Code=" + Eval("Code")  %>'
                                runat="server">
                                            <%#Eval("Title") %>
                            </asp:HyperLink>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <div class="Clear">
        </div>
        <div class="Clear">
        </div>
    </div>
    <div class="BotLine">
    </div>
</div>
<script type="text/javascript">
    var CurMode = 0;

    function MMToggle(paramToggleVar) {
        if (paramToggleVar == CurMode)
            return;
        CurMode = paramToggleVar;
        if (paramToggleVar == 0) {
            $("#tab0").attr('class', 'RightBoxCaption');
            $("#tab1").attr('class', 'RightBoxCaptionNoBorder');
        }
        else {
            $("#tab1").attr('class', 'RightBoxCaption');
            $("#tab0").attr('class', 'RightBoxCaptionNoBorder');
        }
        $("#content0").toggle("slow");
        $("#content1").toggle("slow");
    }



</script>
