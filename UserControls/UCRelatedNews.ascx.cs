using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCRelatedNews : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void GetRelatedNews(int Code)
        {
            BOLNews NewsBOL = new BOLNews();
            rptRelatedNews.DataSource = NewsBOL.GetRelatedNews(Code, 10);
            rptRelatedNews.DataBind();
            this.Visible = true;

        }
    }
}