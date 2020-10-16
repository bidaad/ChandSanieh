using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASNoor.UserControls
{
    public partial class MostViewedNews : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int LangCode = Tools.GetLang();

            BOLNews NewsBOL = new BOLNews();
            rptItems.DataSource = NewsBOL.GetMostViewedNews(LangCode, 3);
            rptItems.DataBind();
        }
    }
}