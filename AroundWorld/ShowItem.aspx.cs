using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;

namespace AceNews.AroundWorld
{
    public partial class ShowItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int PageNo = 1;
            int PageSize = 24;

            int Code = 0;
            string strCode = Request["Code"];
            Int32.TryParse(strCode, out Code);
            if (Code == 0)
                return;

            BOLMultiMedias MultiMediasBOL = new BOLMultiMedias();
            MultiMedias CurItem = MultiMediasBOL.GetDetails(Code);
            Page.Title = ltrTitle.Text = CurItem.Title;
            ltrDescription.Text = CurItem.Description;
            imgPic.ImageUrl = "~/" + CurItem.PicFile;

            BOLMultiMediaPictures MultiMediaPicturesBOL = new BOLMultiMediaPictures(1);
            rptPics.DataSource = MultiMediaPicturesBOL.GetPictures(Code);
            rptPics.DataBind();
        }
    }
}