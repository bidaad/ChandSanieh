<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCSelectedNews.ascx.cs"
    Inherits="AceNews.UserControls.UCSelectedNews" %>
<div class="topNewsBox">
    <div id="topNewsBox">
        <asp:Repeater ID="rptNews" runat="server">
            <ItemTemplate>
                <div class="topNews">
                    <h3>
                        <div class="img">
                            <div class="row">
                                <div class="col-lg-6">
                                    <asp:Image ID="Image1" CssClass="cPicCycle" ImageUrl='<%#Eval("PicFile2") %>' runat="server" />
                                </div>
                                <div class="col-lg-6">
                                    <div class="CycleTitleCont">
                                        <div class="Link">
                                            <asp:HyperLink ID="hplselectedTitle" NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" + Eval("Code") %>' CssClass="NewsManTitle"
                                                runat="server"><%#Tools.ShowBriefText(Eval("Title"), 550)%>
                                            </asp:HyperLink>
                                        </div>
                                        <div class="Justify">
                                            <%#Tools.ShowBriefText(Eval("Abstract"), 750)%>
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <div>
                            </div>

                        </div>
                    </h3>
                    <br class="clearfloat" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
<script type="text/javascript">
    $(document).ready(function () {

        var titles = $('#topNewsBox').find("h3").map(function () { return $(this).text(); });
        //var images = $('#topNewsBox').find("img").map(function () { return $(this).text(); });

        //$('#topNewsBox').after('<div class="MarginBotCycle" ></div><div class="WholePager"><ul id="CyclePager" ></ul><br class="clearfloat" /></div>').cycle({
        $('#topNewsBox').after('').cycle({
            fx: 'slideX',
            speed: 'slow',
            timeout: 10000,
            pager: '#CyclePager',
            prev: '#PrevCycle',
            next: '#NextCycle',
            pagerAnchorBuilder: function (index, slide) {
                //var img = $(slide).children('.img').attr("src");
                imgSrc = jQuery(slide).find('img').attr('src');
                Title = jQuery(slide).find('h3').text();
                //alert(Title);
                //var h3 = slide.children('.img');
                return '<li><div class="TopSlider"></div></li>';
            }
        });

        $("#topNewsBox").mouseover(function () {
            $(this).cycle('pause');
        }).mouseout(function () {
            $(this).cycle('resume');
        });





    });

</script>
