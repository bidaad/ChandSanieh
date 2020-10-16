using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;

namespace AceNews.MultiMedia
{
    public partial class Default : System.Web.UI.Page
    {
        public string MusicsFileName;
        public string MovieFileName;

        protected void Page_Load(object sender, EventArgs e)
        {
            string strCode = Request["Code"];
            int Code;
            Int32.TryParse(strCode, out Code);

            BOLMultiMedias MultiMediasBOL = new BOLMultiMedias();

            if (Code != 0)
            {
                MultiMedias CurMedia = MultiMediasBOL.GetDetails(Code);
                if (CurMedia != null)
                {

                    UCComments1.ItemCode = CurMedia.Code;

                    lblTitle.Text = CurMedia.Title;
                    //ltrDescription.Text = CurMedia.Description;


                }
            }


        }
    }
}