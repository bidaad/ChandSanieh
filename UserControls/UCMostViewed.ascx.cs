using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASNoor.UserControls
{
    public partial class UCMostViewed : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int LangCode = Tools.GetLang();
            if (LangCode == 1 || LangCode == 2)
            {
                ltrTitle.Text = Tools.Translate(LangCode, "Most Viewed");

            }

            BOLNews NewsBOL = new BOLNews();
            rptMostNews.DataSource = NewsBOL.GetMostViewedNews(LangCode, 10);
            rptMostNews.DataBind();

        }
    }
}