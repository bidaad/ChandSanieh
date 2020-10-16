using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCGalleries : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLGalleries BOLGalleries = new BOLGalleries();
            rptGalleries.DataSource = BOLGalleries.GetGalleries(5);
            rptGalleries.DataBind();

        }
    }
}