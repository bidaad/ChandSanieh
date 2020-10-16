using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.PostBack
{
    public partial class MoreNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int PageSize = 20;
            int PageNo = 1;
            int? HCNewsCatCode = null;

            string strPageNo = Request["PageNo"];
            string strHCNewsCatCode = Request["CatCode"];

            Int32.TryParse(strPageNo, out PageNo);
            if (!string.IsNullOrEmpty(strHCNewsCatCode))
                HCNewsCatCode = Convert.ToInt32(strHCNewsCatCode);

            NewsList1.ShowLatestNews(HCNewsCatCode, PageSize, new int[] { }, null, PageNo, false, null, 1);
        }
    }
}