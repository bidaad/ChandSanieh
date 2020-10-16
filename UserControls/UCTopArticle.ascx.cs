using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCTopArticle : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLNews NewsBOL = new BOLNews();
            rptTopArticles.DataSource = NewsBOL.GetNewsByContentType(1, 1, 1);
            rptTopArticles.DataBind();

        }
    }
}