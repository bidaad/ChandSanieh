using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCTabContents : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLNews NewsBOL = new BOLNews();
            //rptInterviews.DataSource = NewsBOL.GetNewsByContentType(2, 4);
            //rptInterviews.DataBind();

            rptArticles.DataSource = NewsBOL.GetNewsByContentType(1, 4, 1);
            rptArticles.DataBind();

            rptNotes.DataSource = NewsBOL.GetNewsByContentType(4, 4, 1);
            rptNotes.DataBind();


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
                    return Page.ResolveUrl("~/images/NoPic.jpg" );
            }
            else
                return Page.ResolveUrl("~/images/NoPic.jpg");
        }
    }
}