using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;
using System.Web.UI.HtmlControls;
using System.IO;
using AceNews.UserControls;
using System.Globalization;

namespace ASNoor.NewsFolder
{
    public partial class ShowNews : System.Web.UI.Page
    {
        public string NewsCode;
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlGenericControl script = new HtmlGenericControl("script");
            script.Attributes.Add("src", this.ResolveClientUrl("~/Admin/Scripts/farsi.js"));
            script.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script);

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
                    //hplExportTpPDF.NavigateUrl = "~/Export.aspx?Type=PDF&Code=" + CurNews.Code;
                    Page.Title = lblTitle.Text = CurNews.Title;

                    string strCurrentMin = CurNews.NewsDate.Minute.ToString();
                    if (strCurrentMin.Length == 1)
                        strCurrentMin = "0" + strCurrentMin;

                    DateTimeMethods dtm = new DateTimeMethods();
                    string strDateTime = "";

                    strDateTime += Tools.ChageEnc(dtm.GetPersianLongDate(CurNews.NewsDate));
                    strDateTime += " ساعت: " + Tools.ChageEnc(CurNews.NewsDate.Hour + ":" + strCurrentMin);

                    lblDate.Text = strDateTime;


                    if (!string.IsNullOrEmpty(CurNews.PicFile1))
                    {
                        hplImage.ImageUrl = CurNews.PicFile2;
                    }
                    else
                        hplImage.ImageUrl = "~/images/Nopic.gif";

                    string Abstract = CurNews.Abstract;
                    Abstract = Abstract.Replace("<br />", "</p><p>");
                    Abstract = Abstract.Replace("font-family", "font-family1");
                    Abstract = Abstract.Replace("font-size", "font-size1");
                    Abstract = Abstract.Replace("line-height", "line-height1");

                    ltrNewsBody.Text = Tools.FormatText(Abstract);
                    BOLComments CommentsBOL = new BOLComments();
                    int CommentCount = CommentsBOL.GetCommentCount(CurNews.Code);

                    //if (!string.IsNullOrEmpty(CurNews.SourceLink))
                    //{
                    //    hplSourceLink.Text = CurNews.SourceLink;
                    //    hplSourceLink.NavigateUrl = CurNews.SourceLink;
                    //}

                    UCComments1.ItemCode = CurNews.Code;
                    BOLNewsKeywords NewsKeywordsBOL = new BOLNewsKeywords(1);
                    rptNewsKeywords.DataSource = NewsKeywordsBOL.GetKeywords(CurNews.Code);
                    rptNewsKeywords.DataBind();

                    if(CurNews.ShowPic != null)
                    {
                        pnlNewsPic.Visible = (bool)CurNews.ShowPic;
                    }

                }
            }
        }


    }
}