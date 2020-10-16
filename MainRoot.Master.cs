using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using AceNews.Old_Code.DAL;
using System.Reflection;
using System.Globalization;

namespace AceNews
{
    public partial class RootSecond : System.Web.UI.MasterPage
    {
        public string Header = "";
        public string strTypingNews = "";
        public string StartHour = "";
        public string StartMinute = "";
        public string StartSecond = "";
        public string SearchCaption = "جستجو";


        protected void Page_Load(object sender, EventArgs e)
        {

            DateTimeMethods dtm = new DateTimeMethods();
            try
            {
                //Page.Form.Attributes.Add("enctype", "multipart/form-data");
                //ScriptManager.GetCurrent(this.Page).RegisterPostBackControl(this.btnSend);
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


            }
            catch
            {
            }


            if (!Page.IsPostBack)
            {
                //this.form1.DefaultButton = btnSearch.UniqueID;

                txtKeyword.Attributes.Add("onblur", "this.className='Keyword';if(this.value == '') this.value = '" + "جستجو" + "';");

                DateTime CurDT = DateTime.Now;
                StartHour = CurDT.Hour.ToString();
                StartMinute = CurDT.Minute.ToString();
                StartSecond = CurDT.Second.ToString();


                lblPersianDate.Text = "امروز " + Tools.ChangeEnc(dtm.GetPersianLongDate(DateTime.Now));
                lblArabicDate.Text = Tools.ChangeEncArabic(DateTime.Now.ToString("d MMM yyyy", new CultureInfo("ar")));
                lblGerigorianDate.Text = DateTime.Now.ToString("ddd d MMM yyyy", CultureInfo.CreateSpecificCulture("en-US"));

            }


            #region Load Scripts
            HtmlGenericControl scriptJQuery = new HtmlGenericControl("script");
            scriptJQuery.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.min1.7.2.js"));
            scriptJQuery.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(scriptJQuery);


            HtmlGenericControl scriptBootstrap = new HtmlGenericControl("script");
            scriptBootstrap.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/bootstrap.min.js"));
            scriptBootstrap.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(scriptBootstrap);


            HtmlGenericControl script = new HtmlGenericControl("script");
            script.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/main.js"));
            script.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script);


            //HtmlGenericControl script2 = new HtmlGenericControl("script");
            //script2.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery-ui.js"));
            //script2.Attributes.Add("type", "text/javascript");
            //Page.Header.Controls.Add(script2);

            HtmlGenericControl scriptCycle = new HtmlGenericControl("script");
            scriptCycle.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.cycle.all.js"));
            scriptCycle.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(scriptCycle);


            //HtmlGenericControl script8 = new HtmlGenericControl("script");
            //script8.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.orbit.js"));
            //script8.Attributes.Add("type", "text/javascript");
            //Page.Header.Controls.Add(script8);

            //HtmlGenericControl script4 = new HtmlGenericControl("script");
            //script4.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jcarousellite_1.0.1c4.js"));
            //script4.Attributes.Add("type", "text/javascript");
            //Page.Header.Controls.Add(script4);

            //HtmlGenericControl scriptRotate = new HtmlGenericControl("script");
            //scriptRotate.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jQueryRotate.js"));
            //scriptRotate.Attributes.Add("type", "text/javascript");
            //Page.Header.Controls.Add(scriptRotate);


            HtmlGenericControl scriptTicker = new HtmlGenericControl("script");
            scriptTicker.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.ticker.js"));
            scriptTicker.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(scriptTicker);

            HtmlGenericControl scriptFarsi = new HtmlGenericControl("script");
            scriptFarsi.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/farsi.js"));
            scriptFarsi.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(scriptFarsi);

            HtmlGenericControl scriptprettyPhoto = new HtmlGenericControl("script");
            scriptprettyPhoto.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.prettyPhoto.js"));
            scriptprettyPhoto.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(scriptprettyPhoto);

            //HtmlGenericControl script3 = new HtmlGenericControl("script");
            //script3.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/scripts.min.js"));
            //script3.Attributes.Add("type", "text/javascript");
            //Page.Header.Controls.Add(script3);


            //HtmlGenericControl script5 = new HtmlGenericControl("script");
            //script5.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.min.js"));
            //script5.Attributes.Add("type", "text/javascript");
            //Page.Header.Controls.Add(script5);


            #endregion


            BOLNews NewsBOL = new BOLNews();
            rptNewsTicker.DataSource = NewsBOL.GetLatestTelexNews(5, null);
            rptNewsTicker.DataBind();

        }
        public string FormatDate(Object obj)
        {
            string Result = "";
            try
            {
                if (obj != null)
                {
                    DateTime CurDT = Convert.ToDateTime(obj);
                    DateTimeMethods dtm = new DateTimeMethods();
                    Result = Tools.ChageEnc(dtm.GetPersianLongDate(CurDT));
                }
                return Result;

            }
            catch
            {
                return "";
            }

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text.Trim() != "")
                Response.Redirect("~/News/?Keyword=" + txtKeyword.Text);
        }


    }
}