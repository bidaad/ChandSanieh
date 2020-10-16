<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCSelectedPics.ascx.cs"
    Inherits="AlphaShop.UserControls.UCSelectedNews" %>
<div class="topNewsBox">
    <div id="topNewsBox">
        
                <div class="topNews">
                    <h3>
                        <div class="img">
                            <asp:Image CssClass="cPicCycle" ImageUrl='~/Files/Pics/1.jpg' runat="server" />
                            
                        </div>
                    </h3>
                    <br class="clearfloat" />
                </div>
                <div class="topNews">
                    <h3>
                        <div class="img">
                            <asp:Image ID="Image1" CssClass="cPicCycle" ImageUrl='~/Files/Pics/2.jpg' runat="server" />
                            
                        </div>
                    </h3>
                    <br class="clearfloat" />
                </div>
                <div class="topNews">
                    <h3>
                        <div class="img">
                            <asp:Image ID="Image2" CssClass="cPicCycle" ImageUrl='~/Files/Pics/3.jpg' runat="server" />
                            
                        </div>
                    </h3>
                    <br class="clearfloat" />
                </div>
                <div class="topNews">
                    <h3>
                        <div class="img">
                            <asp:Image ID="Image3" CssClass="cPicCycle" ImageUrl='~/Files/Pics/4.jpg' runat="server" />
                            
                        </div>
                    </h3>
                    <br class="clearfloat" />
                </div>
                <div class="topNews">
                    <h3>
                        <div class="img">
                            <asp:Image ID="Image4" CssClass="cPicCycle" ImageUrl='~/Files/Pics/5.jpg' runat="server" />
                            
                        </div>
                    </h3>
                    <br class="clearfloat" />
                </div>
                
           
    </div>
</div>
<script type="text/javascript">
    $(document).ready(function () {
        var titles = $('#topNewsBox').find("h3").map(function () { return $(this).text(); });
        //var images = $('#topNewsBox').find("img").map(function () { return $(this).text(); });

        $('#topNewsBox').after('<div class="MarginBotCycle" ></div><div class="WholePager"><ul id="CyclePager" ></ul><br class="clearfloat" /></div>').cycle({
            fx: 'slideX',
            speed: 'slow',
            timeout: 5000,
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
