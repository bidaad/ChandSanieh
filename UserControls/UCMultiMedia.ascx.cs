using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;

namespace ASNoor.UserControls
{
    public partial class UCMultiMedia : System.Web.UI.UserControl
    {
        protected int _hCPicTypeCode = 1;
        public int HCPicTypeCode
        {
            get
            {
                return _hCPicTypeCode;
            }
            set
            {
                _hCPicTypeCode = value;
            }
        }
        public string AudioFileName;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_hCPicTypeCode)
                {
                    case 1:
                        ltrHeader.Text = "چهره روز";
                        break;
                    case 2:
                        ltrHeader.Text = "کاریکاتور";
                        break;
                    default:
                        break;
                }

                BOLMultiMedias MultiMediasBOL = new BOLMultiMedias();
                MultiMedias LatestPic = MultiMediasBOL.GetLatestByType(_hCPicTypeCode);
                if (LatestPic != null)
                {
                    lblPicTitle.Text = LatestPic.Description;
                    imgPic.ImageUrl = "~/" + LatestPic.PicFile;
                    hplLargePic.NavigateUrl = LatestPic.LargePicFile;
                }

            }
            catch(Exception err)
            {

            }

            



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