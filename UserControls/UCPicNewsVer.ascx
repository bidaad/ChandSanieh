<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCPicNewsVer.ascx.cs"
    Inherits="AceNews.UserControls.UCPicNewsVer" %>
<div class="LatestNewsCaption">
    </div>
<div class="LatestNewsBox">
    <div class="ColLatestNewsLeft">
    <div id="LatestNewsBox">
        <asp:Repeater ID="rptNews" runat="server">
            <ItemTemplate>
                <div class="LatestNews">
                    <h3>
                        <div class="img">
                            <asp:Image CssClass="cLatestPicCycle" BorderWidth="3" ImageUrl='<%#Eval("PicFile1") %>'
                                runat="server" />
                        </div>
                        <asp:HyperLink CssClass="NewsManHeader" NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" + Eval("Code")  %>'
                            runat="server"><%#Eval("Title") %>
                        </asp:HyperLink>
                    </h3>
                    <div class="LatestNewsBody">
                        <span>
                            <%#Eval("Abstract")%>
                        </span>
                    </div>
                    <br class="clearfloat" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </div>
    <div class="ColLatestNewsRight">
        <ul id="LatestCyclePager" ></ul>
    </div>
</div>
<div class="BotLine" style="width:541px;">
    </div>
<script type="text/javascript">
    $(document).ready(function () {

        $('#LatestNewsBox').cycle({
            fx: 'fade',
            speed: 'slow',
            timeout: 15000,
            pager: '#LatestCyclePager',
            pagerAnchorBuilder: function (index, slide) {
                imgSrc = jQuery(slide).find('img').attr('src');
                Title = jQuery(slide).find('h3').text();
                return '<li><div class="LatestTopItem"><div class="LatestPagerTitle">' + Title + '</div><div class="LatestPagerImageCont"><img class="LatestPagerImg" src="' + imgSrc + '" /></div><div class="clearfloat" ></div></div></li>';
            }
        });

        $("#LatestNewsBox").mouseover(function () {
            $(this).cycle('pause');
        }).mouseout(function () {
            $(this).cycle('resume');
        });


    });
</script>
