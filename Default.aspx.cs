using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using AceNews.Old_Code.DAL;
using System.Reflection;
using AceNews.UserControls;

namespace AceNews
{
    public partial class _Default : System.Web.UI.Page
    {
        public string StartHour = "";
        public string StartMinute = "";
        public string StartSecond = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int PageNo = 1;
                string strPageNo = Request["PageNo"];
                if (!string.IsNullOrEmpty(strPageNo))
                    Int32.TryParse(strPageNo, out PageNo);
                if (PageNo == 0)
                    PageNo = 1;

                int? HCNewsCatCode = null;

                string strCatCode = Request["CatCode"];
                if (!string.IsNullOrEmpty(strCatCode))
                {
                    int CatCode = 0;
                    Int32.TryParse(strCatCode, out CatCode);
                    if(CatCode != 0)
                        HCNewsCatCode = CatCode;
                }
                //DateTimeMethods dtm = new DateTimeMethods();
                //BOLNews NewsBOL = new BOLNews();
                //vNews LatestNews = NewsBOL.GetLatestNews(1);

                NewsList1.ShowLatestNews(HCNewsCatCode, 15, null, null, PageNo, true, null, 1);

            }


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
        public string ShowPic(object Title, object PicName)
        {
            string Result = "";
            if (PicName != null && PicName != "")
                Result = "<img class=\"cPicXSmall\" alt=\"" + Title + "\" src=\"" + PicName + "\" />";
            return Result;
        }
       

    }
}
