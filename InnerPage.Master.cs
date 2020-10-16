using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using AceNews.Old_Code.DAL;

namespace AceNews
{
    public partial class InnerPage : System.Web.UI.MasterPage
    {
        public string Header = "";
        public string strTypingNews = "";
        public string StartHour = "";
        public string StartMinute = "";
        public string StartSecond = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                BOLLogs LogsBOL = new BOLLogs();
                int? Result = 1;
                string UserCode = "";
                if (Session["UserCode"] != null)
                {
                    UserCode = Session["UserCode"].ToString();
                }
                bool HCReqTypeCode = false;
                if (Request.UserAgent == "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)" ||
                    Request.UserAgent == "Mozilla/5.0 (compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)" ||
                    Request.UserAgent == "msnbot/2.0b (+http://search.msn.com/msnbot.htm)._" ||
                    Request.UserAgent == "Mozilla/5.0 (compatible; bingbot/2.0; +http://www.bing.com/bingbot.htm)" ||
                    Request.UserAgent == "Mozilla/5.0 (en-us) AppleWebKit/525.13 (KHTML, like Gecko; Google Web Preview) Version/3.1 Safari/525.13" ||
                    Request.UserAgent == "Mozilla/5.0 (compatible; MJ12bot/v1.3.3; http://www.majestic12.co.uk/bot.php?+)"

                    )
                    HCReqTypeCode = true;

                Result = LogsBOL.InsertLog(Request.UserAgent, Request.QueryString.ToString(), UserCode, Request.UserHostAddress, Request.Url.AbsolutePath, Tools.GetIranDate(), Page.Request.ServerVariables["http_referer"], HCReqTypeCode, ref Result);
                if (Result == 0)
                    Response.End();

                //lblTodayVisitCount.Text = Tools.ChageEnc(LogsBOL.GetTodayLogs().ToString());


            }
            catch (Exception err)
            {
            }


            DateTime CurDT = DateTime.Now;
            StartHour = CurDT.Hour.ToString();
            StartMinute = CurDT.Minute.ToString();
            StartSecond = CurDT.Second.ToString();

            DateTimeMethods dtm = new DateTimeMethods();
            lblDate.Text = Tools.ChangeEnc(dtm.GetPersianLongDate(DateTime.Now));

            #region Load Scripts
            HtmlGenericControl script = new HtmlGenericControl("script");
            script.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/main.js"));
            script.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script);

            HtmlGenericControl script3 = new HtmlGenericControl("script");
            script3.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/scripts.min.js"));
            script3.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script3);

            HtmlGenericControl script2 = new HtmlGenericControl("script");
            script2.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery-ui-1.7.2.min.js"));
            script2.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script2);

            HtmlGenericControl script8 = new HtmlGenericControl("script");
            script8.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.orbit.js"));
            script8.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script8);


            HtmlGenericControl script4 = new HtmlGenericControl("script");
            script4.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jcarousellite_1.0.1c4.js"));
            script4.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script4);

            HtmlGenericControl scriptCycle = new HtmlGenericControl("script");
            scriptCycle.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.cycle.all.js"));
            scriptCycle.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(scriptCycle);

            HtmlGenericControl scriptTicker = new HtmlGenericControl("script");
            scriptTicker.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.ticker.js"));
            scriptTicker.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(scriptTicker);

            HtmlGenericControl scriptSequence = new HtmlGenericControl("script");
            scriptSequence.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.sequence-min.js"));
            scriptSequence.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(scriptSequence);



            //HtmlGenericControl script5 = new HtmlGenericControl("script");
            //script5.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.min.js"));
            //script5.Attributes.Add("type", "text/javascript");
            //Page.Header.Controls.Add(script5);


            #endregion


            BOLNews NewsBOL = new BOLNews();
            //                                 { text: 'لایحه موافقت‌نامه تجارت آزاد بین ایران و سوریه تقدیم مجلس شد', link: '/News/No/13209', title: 'شنبه, 28 خرداد 1390 13:22' },
            IQueryable<vNews> LatestTelexNews = NewsBOL.GetLatestTelexNews( 5, 1);
            foreach (var NewsItem in LatestTelexNews)
            {
                string CurTitle = NewsItem.Title.Replace("'", "").Replace("\"", "");
                DateTime? NewsDate = NewsItem.NewsDate;
                string PersianDate = "";
                if (NewsDate != null)
                {
                    PersianDate = dtm.GetPersianLongDate((DateTime)NewsDate);
                }
                strTypingNews += "{ text: '" + CurTitle + "', link: '/News/ShowNews.aspx?Code=" + NewsItem.Code + "', title: '" + PersianDate + "' },";
            }
            if (strTypingNews.Length > 0)
                strTypingNews = strTypingNews.Substring(0, strTypingNews.Length - 1);
        }

        protected void btnSearch_Click(object sender, ImageClickEventArgs e)
        {
            if (txtKeyword.Text.Trim() != "")
                Response.Redirect("~/News/?Keyword=" + txtKeyword.Text);
        }
    }
}