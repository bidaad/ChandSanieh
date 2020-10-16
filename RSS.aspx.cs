using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class News_RSS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.ContentType = "text/xml";
        BOLNews NewsBOL = new BOLNews();
        rptNews.DataSource = NewsBOL.GetLatestNewsList(null, new int[] {}, 10,1, null, null, null);
        rptNews.DataBind();
    }
}