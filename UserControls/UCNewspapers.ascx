<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCNewspapers.ascx.cs"
    Inherits="AceNews.UserControls.UCNewspapers" %>
<div class="NewspapersCont">
    <div class="NewspaperCaption">
    </div>
    <div id="LatestNewspapersBox">

        <asp:Repeater ID="rptNewspapers" runat="server">
            <ItemTemplate>

                <div class="LatestNewspaper">
                    <h3>
                        <div class="img">
                            <ul class="gallery clearfix">
                                <li>
                                    <asp:HyperLink ToolTip='<%#Eval("Title") %>' rel="prettyPhoto" CssClass="NewsManHeader"
                                        NavigateUrl='<%#"~/" + Eval("PicFile") %>' runat="server">
                                        <asp:Image ID="Image1" CssClass="cLatestPicCycle" BorderWidth="1" ImageUrl='<%#"~/" + Eval("PicFile") %>'
                                            runat="server" />
                                    </asp:HyperLink>
                                </li>
                            </ul>
                        </div>
                    </h3>
                    <br class="clearfloat" />
                </div>

            </ItemTemplate>
        </asp:Repeater>

    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#LatestNewspapersBox').cycle({
                fx: 'fade',
                speed: 'slow',
                timeout: 5000,
                pagerAnchorBuilder: function (index, slide) {
                    imgSrc = jQuery(slide).find('img').attr('src');
                    Title = jQuery(slide).find('h3').text();
                    return '<li><div class="LatestTopItem"><div class="LatestPagerTitle">' + Title + '</div><div class="LatestPagerImageCont"><img class="LatestPagerImg" src="' + imgSrc + '" /></div><div class="clearfloat" ></div></div></li>';
                }
            });

            $("#LatestNewspapersBox").mouseover(function () {
                $(this).cycle('pause');
            }).mouseout(function () {
                $(this).cycle('resume');
            });


        });
    </script>
</div>
<br />
<div class="clearfloat"></div>
