using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;

namespace AceNews.UserControls
{
    public partial class UCMultiMedia : System.Web.UI.UserControl
    {
        public string AudioFileName;

        protected void Page_Load(object sender, EventArgs e)
        {
            BOLMultiMedias MultiMediasBOL = new BOLMultiMedias();

            rptPics.DataSource = MultiMediasBOL.GetListByType(1, 5, 1);
            rptPics.DataBind();

            if (rptPics.Items.Count == 0)
                pnlLatestPics.Visible = false;

        }
        public string ShowPic(Object obj)
        {
            if (obj != null)
            {
                if (!string.IsNullOrEmpty(obj.ToString()))
                {
                    return Page.ResolveUrl("~/" + obj.ToString());
                }
                else
                    return Page.ResolveUrl("~/images/NoPic.jpg");
            }
            else
                return Page.ResolveUrl("~/images/NoPic.jpg");
        }
    }
}