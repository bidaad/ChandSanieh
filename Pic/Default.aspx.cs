using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.Pic
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int PageNo = 1;
            int PageSize = 24;

            BOLMultiMedias MultiMediasBOL = new BOLMultiMedias();
            rptPics.DataSource = MultiMediasBOL.GetListByType(null, PageSize, PageNo);
            rptPics.DataBind();
        }

        public string GetFile(Object obj)
        {
            if (obj != null)
                return obj.ToString().Replace("//", "/");
            else
                return "";
        }
    }
}