using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCMemorialPic : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLMultiMedias MultiMediasBOL = new BOLMultiMedias();
            rptPics.DataSource = MultiMediasBOL.GetLatestByType(1,5, 3);
            rptPics.DataBind();
        }
    }
}