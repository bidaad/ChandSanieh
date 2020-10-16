using AceNews.Old_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.Galleries
{
    public partial class ShowGallery : System.Web.UI.Page
    {
        public string MediaFile;
        protected void Page_Load(object sender, EventArgs e)
        {
            string strCode = Request["Code"];
            int Code;
            Int32.TryParse(strCode, out Code);

            if (Code != 0)
            {
                BOLGalleries BOLGalleries = new BOLGalleries();
                AceNews.Old_Code.DAL.Galleries CurGallery = BOLGalleries.GetDetails(Code);
                MediaFile = CurGallery.MediaFile;
                lblTitle.Text = CurGallery.Title;
            }
        }
    }
}