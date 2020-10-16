using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCTextPicNews : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BOLNews NewsBOL = new BOLNews();
            rptNews.DataSource = NewsBOL.GetLatestNews(15, 5);
            rptNews.DataBind();
        }
    }
}