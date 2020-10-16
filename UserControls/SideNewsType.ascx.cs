using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class SideNewsType : System.Web.UI.UserControl
    {
        public SideNewsType()
        {
        }
        public SideNewsType(int HCNewsCatCode)
        {
            _HCNewsCatCode = HCNewsCatCode;
        }

        protected int _HCNewsCatCode;
        public int HCNewsCatCode
        {
            set
            {
                _HCNewsCatCode = value;
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BOLHardCode HardCodeBOL = new BOLHardCode();
            HardCodeBOL.TableOrViewName = "HCNewsTypes";
            lblHeader.Text = HardCodeBOL.GetNameByCode(_HCNewsCatCode);

            int TakeCount = 5;
            if (_HCNewsCatCode == 3)
                TakeCount = 4;

            BOLNews NewsBOL = new BOLNews();
            rptItems.DataSource = NewsBOL.GetNewsByCatCode(_HCNewsCatCode, TakeCount, 1, 7, 1);
            rptItems.DataBind();
            hplMore.NavigateUrl = "~/News/?NT=" + _HCNewsCatCode;
        }
    }
}