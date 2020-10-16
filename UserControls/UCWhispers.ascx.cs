using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCWhispers : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLWhispers WhispersBOL = new BOLWhispers();
            rptWhispers.DataSource = WhispersBOL.GetLatest(3);
            rptWhispers.DataBind();
        }
    }
}