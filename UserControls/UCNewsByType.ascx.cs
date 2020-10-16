using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCNewsByType : System.Web.UI.UserControl
    {
        protected int _hCNewsTypeCode;
        public int HCNewsTypeCode
        {
            get
            {
                return _hCNewsTypeCode;
            }
            set
            {
                _hCNewsTypeCode = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (_hCNewsTypeCode)
            {
                case 1:
                    ltrHeader.Text = "خبر";
                    break;
                case 2:
                    ltrHeader.Text = "یادداشت";
                    break;
                case 3:
                    ltrHeader.Text = "گزارش";
                    break;
                case 4:
                    ltrHeader.Text = "گفتگو";
                    break;

                default:
                    break;
            }

            BOLNews NewsBOL = new BOLNews();
            rptNews.DataSource = NewsBOL.GetLatestNews(5, _hCNewsTypeCode);
            rptNews.DataBind();

            hplArchive.NavigateUrl = "~/News/?NTC=" + _hCNewsTypeCode;
        }
    }
}