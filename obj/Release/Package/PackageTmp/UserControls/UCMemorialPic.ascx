<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCMemorialPic.ascx.cs"
    Inherits="AceNews.UserControls.UCMemorialPic" %>
<div class="MemorialPicsCont">
    <div class="DayPicCaption">
        یک عکس ، یک خاطره
    </div>
    <div id="LatestMemorialPicsBox">
        <asp:Repeater ID="rptPics" runat="server">
            <ItemTemplate>
                <div class="LatestNewspaper">
                    <h3>
                        <div class="img">
                            <ul class="gallery clearfix">
                                <li>
                                    <asp:HyperLink ID="HyperLink1" ToolTip='<%#Eval("Title") %>' rel="prettyPhoto" CssClass="NewsManHeader"
                                        NavigateUrl='<%#"~/" + Eval("LargePicFile") %>' runat="server">
                                        <asp:Image ID="Image1" CssClass="cLatestPicCycle" BorderWidth="1" ImageUrl='<%#"~/" + Eval("PicFile") %>'
                                            runat="server" />
                                    </asp:HyperLink>
                                </li>
                            </ul>
                        </div>
                        <div class="Farsi Justify">
                            <%#Eval("Description") %>
                        </div>
                    </h3>
                    <br class="clearfloat" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {

            $('#LatestMemorialPicsBox').cycle({
                fx: 'fade',
                speed: 'slow',
                timeout: 5000,
                pagerAnchorBuilder: function (index, slide) {
                    imgSrc = jQuery(slide).find('img').attr('src');
                    Title = jQuery(slide).find('h3').text();
                    return '<li><div class="LatestTopItem"><div class="LatestPagerTitle">' + Title + '</div><div class="LatestPagerImageCont"><img class="LatestPagerImg" src="' + imgSrc + '" /></div><div class="clearfloat" ></div></div></li>';
                }
            });

            $("#LatestMemorialPicsBox").mouseover(function () {
                $(this).cycle('pause');
            }).mouseout(function () {
                $(this).cycle('resume');
            });


        });
    </script>
</div>
