using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;
using System.Globalization;

namespace ASNoor.NewsFolder
{
    public partial class PrintNews : System.Web.UI.Page
    {
        public string NewsCode;
        protected void Page_Load(object sender, EventArgs e)
        {
            //HtmlGenericControl script = new HtmlGenericControl("script");
            //script.Attributes.Add("src", this.ResolveClientUrl("~/Admin/Scripts/farsi.js"));
            //script.Attributes.Add("type", "text/javascript");
            //Page.Header.Controls.Add(script);

            if (!Page.IsPostBack)
            {


                int Code = 0;
                string strCode = Request["Code"];
                Int32.TryParse(strCode, out Code);
                BOLNews NewsBOL = new BOLNews();
                News CurNews = ((IBaseBOL<News>)NewsBOL).GetDetails(Code);
                if (CurNews != null)
                {
                    NewsCode = Code.ToString();
                    ViewState["Code"] = CurNews.Code;

                    lblSuTitr.Text = CurNews.SoTitr;
                    Page.Title = lblTitle.Text = CurNews.Title;

                    DateTimeMethods dtm = new DateTimeMethods();
                    string strDateTime = "";
                    string strCurrentMin = CurNews.NewsDate.Minute.ToString();


                        strDateTime += Tools.ChageEnc(dtm.GetPersianLongDate(CurNews.NewsDate));
                        strDateTime += " ساعت: " + Tools.ChageEnc(CurNews.NewsDate.Hour + ":" + strCurrentMin);

                    lblDate.Text = strDateTime;

                    lblNewsCode.Text = " کد : " + Tools.ChageEnc( CurNews.Code.ToString());

                    if (!string.IsNullOrEmpty(CurNews.PicFile1))
                    {
                        hplImage.ImageUrl = CurNews.PicFile1;
                        hplImage.NavigateUrl = CurNews.PicFile1;
                    }
                    else
                        hplImage.ImageUrl = "~/images/Nopic.gif";

                    string Abstract = CurNews.Abstract;
                    Abstract = Abstract.Replace("style=", "style1=");
                    Abstract = Abstract.Replace("<br />", "</p><p>");
                    //NewBody = NewBody.Replace("<div", "<p");


                    ltrNewsBody.Text = Tools.FormatText(Abstract);
                    BOLComments CommentsBOL = new BOLComments();
                    int CommentCount = CommentsBOL.GetCommentCount(CurNews.Code);

                    lblAbstract.Text = Tools.FormatText(CurNews.Abstract);

                }
            }
        }
    }
}