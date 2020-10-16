<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCPics.ascx.cs" Inherits="AceNews.UserControls.UCMultiMedia" %>
<div class="MarginerRightBox">
    <div class="RightBoxCaption">
        <asp:Literal ID="ltrTitle" runat="server">الصـور</asp:Literal>
    </div>
    <div class="Clear">
    </div>
    <div>
        <asp:Panel runat="server" ID="pnlLatestPics" CssClass="LatestPics">
            <asp:Repeater ID="rptPics" runat="server">
                <HeaderTemplate>
                    <ul class="MMItems">
                </HeaderTemplate>
                <ItemTemplate>
                    <li class="PicItems">
                        <div class="RightText">
                            <asp:HyperLink CssClass="TopMovieTitle" NavigateUrl='<%#"~/MultiMedia/?Code=" + Eval("Code")  %>'
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
            <script type="text/javascript">
                $(function () {
                    $(".LatestPics").jCarouselLite({
                        btnNext: ".MMPre",
                        btnPrev: ".MMNext",
                        speed: 2000,
                        visible: 1
                    });
                });
            </script>
        </asp:Panel>
        <div class="MMPreNext">
            <div class="MMPre">
            </div>
            <div class="MMNext">
            </div>
        </div>
        <div class="Clear">
        </div>
    </div>
    <div class="BotLine">
    </div>
</div>
