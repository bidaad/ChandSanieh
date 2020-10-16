using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews
{
    public partial class SelectedNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLNews NewsBOL = new BOLNews();
            rptNews.DataSource = NewsBOL.GetNewsByContentType(9, 6, 1);
            rptNews.DataBind();
        }
    }
}