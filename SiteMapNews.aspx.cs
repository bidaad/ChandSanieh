using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews
{
    public partial class SiteMapNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLNews NewsBOL = new BOLNews();
            rptNews.DataSource = NewsBOL.GetAllNews();
            rptNews.DataBind();
        }
    }
}