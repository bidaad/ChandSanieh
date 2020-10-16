<%@ Page Language="C#" AutoEventWireup="True" ValidateRequest="false" CodeBehind="MyTest.aspx.cs" Inherits="ASNoor.MyTest" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1">
    <link rel="shortcut icon" href="/images/favicon.ico" type="image/x-icon" />
    <link rel="icon" href="/images/favicon.ico" type="image/x-icon" />
    <link id="lnkMainCSS" href="Styles/Main.css" media="screen" rel="stylesheet" type="text/css" />
    <link id="Link3" href="Styles/Orbit.css" rel="stylesheet" type="text/css" />
    <link id="Link1" rel="stylesheet" href="styles/bootstrap.min.css" />
    <link href="Styles/prettyPhoto.css" type="text/css" rel="stylesheet" media="all" />
    <title>:: چند ثانیه :: 
    </title>
    <meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
    <meta content="چند ثانیه" name="keywords" />
    <meta content="چند ثانیه" name="description" />
    <meta name="author" content=" «چند ثانیه»" />
    <meta id="Refresh" http-equiv="refresh" content="300" />
    <link rel="alternate" type="application/rss+xml" title="AceNewsNews RSS 2.0 News Feed" href="/Rss.aspx" />
    <script src="Scripts/jquery.min1.7.2.js" type="text/javascript"></script>
    <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="Scripts/main.js" type="text/javascript"></script>
    <script src="Scripts/jquery.cycle.all.js" type="text/javascript"></script>
    <script src="Scripts/jquery.ticker.js" type="text/javascript"></script>
    <script src="Scripts/farsi.js" type="text/javascript"></script>
    <script src="Scripts/jquery.prettyPhoto.js" type="text/javascript"></script>
</head>
<body onload="updateClock(); setInterval('updateClock()', 1000 )">
    <script type="text/javascript">
        function WideKeyword() {
            if ($("#txtKeyword").width() < 200)
                $("#txtKeyword").animate({ "width": "+=150px" }, "slow");
        }
        function UnWideKeyword() {
            $("#txtKeyword").animate({ "width": "+=-150px" }, "slow");

        }

    </script>
    <form method="post" action="./Default.aspx" id="form1">
        <div class="aspNetHidden">
            <input type="hidden" name="__EVENTTARGET" id="__EVENTTARGET" value="" />
            <input type="hidden" name="__EVENTARGUMENT" id="__EVENTARGUMENT" value="" />
            <input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="/wEPDwUKLTcwMDk2Mjg1Nw9kFgJmD2QWAgIDD2QWAgIDD2QWJgIDD2QWAgIBDxYCHgtfIUl0ZW1Db3VudAIBFgJmD2QWAmYPFQICMTNdINiq2LHYp9mF2b46INio2YfigIzZh9uM2obigIzZiNis2Ycg2Ybar9ix2KfZhiDYp9mB2LLYp9uM2LQg2KrZhti0INio2Kcg2KfbjNix2KfZhiDZhtuM2LPYqtmFZAIFDw9kFgIeBm9uYmx1cgVIdGhpcy5jbGFzc05hbWU9J0tleXdvcmQnO2lmKHRoaXMudmFsdWUgPT0gJycpIHRoaXMudmFsdWUgPSAn2KzYs9iq2KzZiCc7ZAIJDw8WAh4EVGV4dAUt2KfZhdix2YjYsiDYtNmG2KjZhyDYjCDbtiDZhdix2K/Yp9ivINux27Pbudu3ZGQCCw8PFgIfAgUg27HZpSDYsNmIwqDYp9mE2YLYudiv2Kkg27HZpNuz2alkZAINDw8WAh8CBQ9TYXQgMjggSnVsIDIwMThkZAIPD2QWAmYPZBYCZg8PFgYeCEltYWdlVXJsBSJ+Ly9GaWxlcy9CYW5uZXJzL2JlIHZhZ3RoIHNoYW0uanBnHgVXaWR0aBsAAAAAAIBrQAEAAAAeBF8hU0ICgAJkZAIXD2QWAgIBDxYCHwACARYCZg9kFgICAQ8PFgQeB1Rvb2xUaXAFjwHZgduM2YTZhS8g2b7YtNiqINm+2LHYr9mHINi32YjZgdin2YYg2KrZiNim24zYqtix24wg2LnZhNuM2Ycg2KfbjNix2KfZhi8g2LHYqNin2KrigIzZh9inINmIINin2qnYp9mG2KrigIzZh9in24zbjCDYqNinINmF2KfZhdmI2LHbjNiqINmI24zamNmHIR4LTmF2aWdhdGVVcmwFI34vR2FsbGVyaWVzL1Nob3dHYWxsZXJ5LmFzcHg/Q29kZT0xZBYCZg8VAY8B2YHbjNmE2YUvINm+2LTYqiDZvtix2K/ZhyDYt9mI2YHYp9mGINiq2YjYptuM2KrYsduMINi52YTbjNmHINin24zYsdin2YYvINix2KjYp9iq4oCM2YfYpyDZiCDYp9qp2KfZhtiq4oCM2YfYp9uM24wg2KjYpyDZhdin2YXZiNix24zYqiDZiNuM2pjZhyFkAhkPZBYCAgEPFgIfAAIKFhRmD2QWAgIBDw8WBB8GZR8HBRl+Ly9GaWxlcy9OZXdzcGFwZXJzLzEuanBnZBYCZg8PFgIfAwUZfi8vRmlsZXMvTmV3c3BhcGVycy8xLmpwZ2RkAgEPZBYCAgEPDxYEHwZlHwcFGX4vL0ZpbGVzL05ld3NwYXBlcnMvMi5qcGdkFgJmDw8WAh8DBRl+Ly9GaWxlcy9OZXdzcGFwZXJzLzIuanBnZGQCAg9kFgICAQ8PFgQfBmUfBwUZfi8vRmlsZXMvTmV3c3BhcGVycy8zLmpwZ2QWAmYPDxYCHwMFGX4vL0ZpbGVzL05ld3NwYXBlcnMvMy5qcGdkZAIDD2QWAgIBDw8WBB8GZR8HBRl+Ly9GaWxlcy9OZXdzcGFwZXJzLzQuanBnZBYCZg8PFgIfAwUZfi8vRmlsZXMvTmV3c3BhcGVycy80LmpwZ2RkAgQPZBYCAgEPDxYEHwZlHwcFGX4vL0ZpbGVzL05ld3NwYXBlcnMvNS5qcGdkFgJmDw8WAh8DBRl+Ly9GaWxlcy9OZXdzcGFwZXJzLzUuanBnZGQCBQ9kFgICAQ8PFgQfBmUfBwUZfi8vRmlsZXMvTmV3c3BhcGVycy82LmpwZ2QWAmYPDxYCHwMFGX4vL0ZpbGVzL05ld3NwYXBlcnMvNi5qcGdkZAIGD2QWAgIBDw8WBB8GZR8HBRl+Ly9GaWxlcy9OZXdzcGFwZXJzLzcuanBnZBYCZg8PFgIfAwUZfi8vRmlsZXMvTmV3c3BhcGVycy83LmpwZ2RkAgcPZBYCAgEPDxYEHwZlHwcFGX4vL0ZpbGVzL05ld3NwYXBlcnMvOC5qcGdkFgJmDw8WAh8DBRl+Ly9GaWxlcy9OZXdzcGFwZXJzLzguanBnZGQCCA9kFgICAQ8PFgQfBmUfBwUZfi8vRmlsZXMvTmV3c3BhcGVycy85LmpwZ2QWAmYPDxYCHwMFGX4vL0ZpbGVzL05ld3NwYXBlcnMvOS5qcGdkZAIJD2QWAgIBDw8WBB8GZR8HBRp+Ly9GaWxlcy9OZXdzcGFwZXJzLzEwLmpwZ2QWAmYPDxYCHwMFGn4vL0ZpbGVzL05ld3NwYXBlcnMvMTAuanBnZGQCGw9kFgICAw8WAh8AAgoWFGYPZBYCAgEPDxYEHwYFMtmB2YjYqtiz2KfZhCDYqNin2YbZiNin2YYg2KfbjNix2KfZhiDZiCDYsdmI2LPb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" />
        </div>

        <script type="text/javascript">
            //<![CDATA[
            var theForm = document.forms['form1'];
            if (!theForm) {
                theForm = document.form1;
            }
            function __doPostBack(eventTarget, eventArgument) {
                if (!theForm.onsubmit || (theForm.onsubmit() != false)) {
                    theForm.__EVENTTARGET.value = eventTarget;
                    theForm.__EVENTARGUMENT.value = eventArgument;
                    theForm.submit();
                }
            }
            //]]>
        </script>


        <script src="/WebResource.axd?d=CI3mWdZQ4xWy6SAtAtlwouzHXKfX7WnwmsI2YbT4jaAg-HTWaojKE0-l7oOWM3WAHDDXZcxKf681Xorw368P75VMXnP7LwM5QUj8fZ9odIw1&amp;t=636638374180000000" type="text/javascript"></script>


        <script src="/ScriptResource.axd?d=Q0DdG4nqGGwKN26xBA_lfMkA1pU-LhTe14OE_5CL9Pekqw2us4jo3r3QiUpZJNTqu-W5PI98egpr_0KMUFFnNC3cparebJ5_XkIUIdOjihuUS_fnROPLIZ6-OjCGWmsBavj2KvGz1bpeFkfIJ1pJxA2&amp;t=f2cd5c5" type="text/javascript"></script>
        <script type="text/javascript">
            //<![CDATA[
            if (typeof (Sys) === 'undefined') throw new Error('ASP.NET Ajax client-side framework failed to load.');
            //]]>
        </script>

        <script src="/ScriptResource.axd?d=a2vJLHp6gRFO_ApA0ICMjDMFGvJUj_vJNMQyyz3JJny44Rtckago0D1cwXHugCzIteWiPpXnrNh86weerLJOjolRuhAvFxsVhqjvnZ8Z3BKKFqy_pigKT_1nvg8I6A-L66mChWeKwucqTpIte8TM1w2&amp;t=f2cd5c5" type="text/javascript"></script>
        <input name="SendSlide" id="SendSlide" type="hidden" />
        <script type="text/javascript">
            //<![CDATA[
            Sys.WebForms.PageRequestManager._initialize('ctl00$ScriptManager1', 'form1', [], [], [], 90, 'ctl00');
            //]]>
        </script>

        <div id="pnlHomeWrapper" class="HomeWrapper">

            <div class="MainPage" id="MainContent">
                <div class="ColLeft">
                    
                    <div>
                        <div class="AllDates">
                            <ul class="DateCaptions">
                                <li>
                                    <span id="lblPersianDate">امروز شنبه ، ۶ مرداد ۱۳۹۷</span>
                                </li>
                                <li>
                                    <span id="lblArabicDate">۱٥ ذو القعدة ۱٤۳٩</span>
                                </li>
                                <li>
                                    <span id="lblGerigorianDate" class="MiladiDate">Sat 28 Jul 2018</span>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="InnerHome">
                        <div class="ColLeftInner">
                            

                            <div class="NewspapersCont">
                                <div class="MultimediaCaption">
                                </div>
                                <div id="LatestNewspapersBox">


                                    <div class="LatestGalleries">
                                        <h3>
                                            <div>
                                                <ul>
                                                    <li>
                                                        <a title="فیلم/ پشت پرده طوفان توئیتری علیه ایران/ ربات‌ها و اکانت‌هایی با ماموریت ویژه!" class="NewsManHeader" rel="prettyPhoto" href="Galleries/ShowGallery.aspx?Code=1" target="_blank">فیلم/ پشت پرده طوفان توئیتری علیه ایران/ ربات‌ها و اکانت‌هایی با ماموریت ویژه!</a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </h3>
                                        <br class="clearfloat" />
                                    </div>



                                </div>

                            </div>


                            <div class="NewspapersCont">
                                <div class="NewspaperCaption">
                                </div>
                                <div id="LatestNewspapersBox">



                                    <div class="LatestNewspaper">
                                        <h3>
                                            <div class="img1">
                                                <ul class="">
                                                    <li>
                                                        <a class="NewsManHeader" rel="prettyPhoto" href="Files/Newspapers/1.jpg">
                                                            <img id="UCNewspapers1_rptNewspapers_Image1_0" class="cLatestPicCycle" src="Files/Newspapers/1.jpg" style="border-width: 1px; border-style: solid;" /></a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </h3>
                                        <br class="clearfloat" />
                                    </div>



                                    <div class="LatestNewspaper">
                                        <h3>
                                            <div class="img1">
                                                <ul class="">
                                                    <li>
                                                        <a class="NewsManHeader" rel="prettyPhoto" href="Files/Newspapers/2.jpg">
                                                            <img id="UCNewspapers1_rptNewspapers_Image1_1" class="cLatestPicCycle" src="Files/Newspapers/2.jpg" style="border-width: 1px; border-style: solid;" /></a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </h3>
                                        <br class="clearfloat" />
                                    </div>



                                    <div class="LatestNewspaper">
                                        <h3>
                                            <div class="img1">
                                                <ul class="">
                                                    <li>
                                                        <a class="NewsManHeader" rel="prettyPhoto" href="Files/Newspapers/3.jpg">
                                                            <img id="UCNewspapers1_rptNewspapers_Image1_2" class="cLatestPicCycle" src="Files/Newspapers/3.jpg" style="border-width: 1px; border-style: solid;" /></a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </h3>
                                        <br class="clearfloat" />
                                    </div>



                                    <div class="LatestNewspaper">
                                        <h3>
                                            <div class="img1">
                                                <ul class="">
                                                    <li>
                                                        <a class="NewsManHeader" rel="prettyPhoto" href="Files/Newspapers/4.jpg">
                                                            <img id="UCNewspapers1_rptNewspapers_Image1_3" class="cLatestPicCycle" src="Files/Newspapers/4.jpg" style="border-width: 1px; border-style: solid;" /></a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </h3>
                                        <br class="clearfloat" />
                                    </div>



                                    <div class="LatestNewspaper">
                                        <h3>
                                            <div class="img1">
                                                <ul class="">
                                                    <li>
                                                        <a class="NewsManHeader" rel="prettyPhoto" href="Files/Newspapers/5.jpg">
                                                            <img id="UCNewspapers1_rptNewspapers_Image1_4" class="cLatestPicCycle" src="Files/Newspapers/5.jpg" style="border-width: 1px; border-style: solid;" /></a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </h3>
                                        <br class="clearfloat" />
                                    </div>



                                    <div class="LatestNewspaper">
                                        <h3>
                                            <div class="img1">
                                                <ul class="">
                                                    <li>
                                                        <a class="NewsManHeader" rel="prettyPhoto" href="Files/Newspapers/6.jpg">
                                                            <img id="UCNewspapers1_rptNewspapers_Image1_5" class="cLatestPicCycle" src="Files/Newspapers/6.jpg" style="border-width: 1px; border-style: solid;" /></a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </h3>
                                        <br class="clearfloat" />
                                    </div>



                                    <div class="LatestNewspaper">
                                        <h3>
                                            <div class="img1">
                                                <ul class="">
                                                    <li>
                                                        <a class="NewsManHeader" rel="prettyPhoto" href="Files/Newspapers/7.jpg">
                                                            <img id="UCNewspapers1_rptNewspapers_Image1_6" class="cLatestPicCycle" src="Files/Newspapers/7.jpg" style="border-width: 1px; border-style: solid;" /></a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </h3>
                                        <br class="clearfloat" />
                                    </div>



                                    <div class="LatestNewspaper">
                                        <h3>
                                            <div class="img1">
                                                <ul class="">
                                                    <li>
                                                        <a class="NewsManHeader" rel="prettyPhoto" href="Files/Newspapers/8.jpg">
                                                            <img id="UCNewspapers1_rptNewspapers_Image1_7" class="cLatestPicCycle" src="Files/Newspapers/8.jpg" style="border-width: 1px; border-style: solid;" /></a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </h3>
                                        <br class="clearfloat" />
                                    </div>



                                    <div class="LatestNewspaper">
                                        <h3>
                                            <div class="img1">
                                                <ul class="">
                                                    <li>
                                                        <a class="NewsManHeader" rel="prettyPhoto" href="Files/Newspapers/9.jpg">
                                                            <img id="UCNewspapers1_rptNewspapers_Image1_8" class="cLatestPicCycle" src="Files/Newspapers/9.jpg" style="border-width: 1px; border-style: solid;" /></a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </h3>
                                        <br class="clearfloat" />
                                    </div>



                                    <div class="LatestNewspaper">
                                        <h3>
                                            <div class="img1">
                                                <ul class="">
                                                    <li>
                                                        <a class="NewsManHeader" rel="prettyPhoto" href="Files/Newspapers/10.jpg">
                                                            <img id="UCNewspapers1_rptNewspapers_Image1_9" class="cLatestPicCycle" src="Files/Newspapers/10.jpg" style="border-width: 1px; border-style: solid;" /></a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </h3>
                                        <br class="clearfloat" />
                                    </div>



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



                            <div class="EditorChoice">
                                <div class="HeaderCont">
                                    <h3 class="Header">
                                        <a id="UCHistory1_HyperLink2" href="AroundWorld">دور دنیا در چند ثانیه</a>
                                    </h3>
                                </div>

                            </div>



























                            <div class="Clear">
                            </div>
                        </div>
                        <div class="ColRightInner">
                            <div id="HomeHeader">
                                <div class="CycleTopBG">
                                </div>
                                <div class="TopMarginer">
                                </div>
                                <div class="Clear">
                                </div>
                                <div class="Clear">
                                </div>
                                <div class="Head1">
                                </div>
                            </div>
                            <div class="Clear">
                            </div>

                            <div class="MainDataCont">

                                <div id="PageNews">


                                    <div class="Padder551">
                                        <div id="CP1_NewsList1_pnlHeader" class="NewsListHeader">

                                            <div class="HeaderArchive">
                                                <a id="CP1_NewsList1_HyperLink1" class="Farsi" href="News/Archive.aspx">آرشیو</a>
                                            </div>
                                            <div class="HeaderText Latest VMenuItem">
                                                آخرین اخبار
                                            </div>
                                            <div class="Clear">
                                            </div>

                                        </div>
                                        <div class="Clear">
                                        </div>

                                    </div>
                                    <div id="CP1_NewsList1_pnlPaging">
                                    </div>
                                    <div id="CommentSendForm" class="Hidden CommentSendForm">
                                        <table class="tblComment">
                                            <tr>
                                                <td style="padding-right: 30px;">
                                                    <div class="CommentFormLabel">
                                                        نظر
                                                    </div>
                                                    <textarea id="txtComment" rows="5" cols="100" text="نظر" style="text-align: right;"
                                                        onclick="this.className='input-text'; this.value='';" onblur="this.className='GrayText';if(this.value == '') this.value= 'نظر';"
                                                        class="CommentText" width="350" height="200"></textarea>
                                                </td>
                                                <td>
                                                    <div class="CommentFormLabel">
                                                        نام
                                                    </div>
                                                    <div class="TextContainer">
                                                        <input id="txtName" text="نام" onclick="this.className = 'input-text'; this.value = '';"
                                                            onblur="if(this.value == '') this.value= 'نام';" width="220" class="CommentText" />
                                                    </div>
                                                    <div class="CommentFormLabel">
                                                        ایمیل
                                                    </div>
                                                    <div class="TextContainer">
                                                        <input id="txtEmail" width="220" onclick="this.className = 'input-text'; this.value = '';"
                                                            title="ایمیل" style="text-align: right;" onblur="if(this.value == '') this.value= 'ایمیل';"
                                                            skinid="English" class="CommentText" />
                                                    </div>
                                                    <div style="text-align: right;">
                                                        <div class="divSendButton" id="btnSendComment" />
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>


                                </div>
                                <div class="Clear">
                                </div>
                            </div>
                            <script type="text/javascript" charset="utf-8">
                                $(document).ready(function () {


                                    //            $(window).scroll(function () {
                                    //                if ($(window).scrollTop() + $(window).height() == $(document).height()) {
                                    //                    LoadMoreNews();
                                    //                }
                                    //            });

                                });
                            </script>

                        </div>
                    </div>
                </div>
                
                <div class="Clear">
                </div>
            </div>
            <div class="Clear">
            </div>


            <div class="Clear">
            </div>
            <div id="Footer">
                <div class="Right">
                    <div class="LogoSmall">
                    </div>
                    <div class="CopyRight">
                        :.
                    کلیه حقوق برای چند ثانیه محفوظ است. نقل مطالب سایت تنها با ذکر منبع (www.chandsanieh.ir) مجاز است
                    .:
                    </div>
                </div>
                <div class="Left">
                    <ul class="FooterLinks">
                        <li>
                            <!-- Begin WebGozar.com Counter code -->
                            <script type="text/javascript" language="javascript" src="http://www.webgozar.ir/c.aspx?Code=3327297&amp;t=counter"></script>
                            <noscript>
                                <a href="http://www.webgozar.com/counter/stats.aspx?code=3327297" target="_blank">&#1570;&#1605;&#1575;&#1585;</a>
                            </noscript>
                            <!-- End WebGozar.com Counter code -->
                        </li>

                        <li>
                            <a id="hplBotHome" href="AboutUs.aspx">درباره ما</a></li>
                        <li>
                            <a id="hplBotAboutUs" href="#">نظرسنجی</a></li>
                        <li>
                            <a id="hplBotContactUs" href="#">پیوندها</a></li>
                        <li>
                            <a id="HyperLink2" href="mailto:info@channdsanieh.ir">تماس با ما</a></li>
                        <li>
                            <a id="HyperLink3" href="#">اشتراک خبرنامه</a></li>
                    </ul>
                </div>
                <div class="Clear">
                </div>
            </div>

        </div>

        <div class="aspNetHidden">

            <input type="hidden" name="__VIEWSTATEGENERATOR" id="__VIEWSTATEGENERATOR" value="CA0B0334" />
            <input type="hidden" name="__EVENTVALIDATION" id="__EVENTVALIDATION" value="/wEdAAOxQnM/iNJXHBJsvL6yNh4Z5cKi0XK5unSnLw0OVnUbaw+M2a8V/drjpciMdUshk0J8Y3PQsxI5kIjWHXJQA0fy6GY0Ig7LcZTgph1JtXG3XA==" />
        </div>
    </form>
    <div id="backtotop" style="display: block;">
        <a href="#">
            <img border="0" alt="Go to TOP" src="/images/back2up.png" />
        </a>
    </div>

    <!-- Visual Studio Browser Link -->
    <script type="application/json" id="__browserLink_initializationData">
    {"appName":"Firefox","requestId":"b3f68dd381824f5582cc6560df382654"}
    </script>
    <script type="text/javascript" src="http://localhost:2018/d6166e9ec0e84ae98eecb7754111b643/browserLink" async="async"></script>
    <!-- End Browser Link -->

</body>
</html>
