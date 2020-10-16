using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCNewspapers : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLNewspapers NewspapersBOL = new BOLNewspapers();
            rptNewspapers.DataSource = NewspapersBOL.GetLatest(10);
            rptNewspapers.DataBind();
        }
    }
}