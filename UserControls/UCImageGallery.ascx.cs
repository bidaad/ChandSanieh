using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCImageGallery : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            BOLNews NewsBOL = new BOLNews();
            rptImageGallery.DataSource = NewsBOL.GetImageGallery(5);
            rptImageGallery.DataBind();
        }
    }
}