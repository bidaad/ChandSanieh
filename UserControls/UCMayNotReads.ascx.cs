using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCMayNotReads : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLMayNotReads MayNotReadsBOL = new BOLMayNotReads();
            rptMayNotReads.DataSource = MayNotReadsBOL.GetLatest(3);
            rptMayNotReads.DataBind();
        }
    }
}