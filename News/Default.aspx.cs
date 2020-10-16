using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;

namespace AceNews.NewsFolder
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                int HCContentTypeCode = 0;
                string strHCContentTypeCode = Request["CT"];
                string strCaseCode = Request["CaseCode"];
                string strDate = Request["d"];
                string strNewsTypeCode = Request["NTC"];

                Int32.TryParse(strHCContentTypeCode, out HCContentTypeCode);
                string Keyword = Request["Keyword"];
                string strMCat = Request["MCat"];
                int MCat;
                int CaseCode;
                int NewsTypeCode;

                Int32.TryParse(strCaseCode, out CaseCode);
                Int32.TryParse(strMCat, out MCat);
                Int32.TryParse(strNewsTypeCode, out NewsTypeCode);

                int WorkGroupCode = 0;
                string strWorkGroupCode = Request["WG"];
                Int32.TryParse(strWorkGroupCode, out WorkGroupCode);

                if (HCContentTypeCode != 0)
                {
                    BOLHardCode HardCodeBOL = new BOLHardCode();
                    HardCodeBOL.TableOrViewName = "HCContentTypes";
                    //lblHeader.Text = HardCodeBOL.GetNameByCode(HCContentTypeCode);

                    //BOLNews NewsBOL = new BOLNews();
                    //vNews LatestNews = NewsBOL.GetLatestNews(1);
                    NewsList1.ShowNewsByContentTypeCode(HCContentTypeCode);
                }
                else if (MCat != 0)
                {
                    BOLNews NewsBOL = new BOLNews();
                    NewsList1.LoadMainCats(MCat);
                }
                else if (!string.IsNullOrEmpty(Keyword))
                {
                    //BOLNews NewsBOL = new BOLNews();
                    //vNews LatestNews = NewsBOL.GetLatestNews(1);
                    NewsList1.PageSize = 10;
                    NewsList1.CurrentKeywrod = Keyword;
                    NewsList1.SearchNews(Keyword);

                }
                else if (!string.IsNullOrEmpty( strDate))
                    NewsList1.ShowLatestNews(null, 10, new int[] { }, null, null, true, strDate, NewsTypeCode);
                else
                    NewsList1.ShowLatestNews(null, 10, new int[] { }, null, null, true, null, NewsTypeCode);
            }

        }
    }
}