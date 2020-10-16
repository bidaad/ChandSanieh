using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class SmallContentBox : System.Web.UI.UserControl
    {
        public SmallContentBox()
        {
        }
        public SmallContentBox(int HCContentTypeCode)
        {
            _hCContentTypeCode = HCContentTypeCode;
        }

        protected int _hCContentTypeCode;
        public int HCContentTypeCode
        {
            set
            {
                _hCContentTypeCode = value;
            }

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            BOLHardCode HardCodeBOL = new BOLHardCode();
            HardCodeBOL.TableOrViewName = "HCContentTypes";
            lblHeader.Text =  HardCodeBOL.GetNameByCode(_hCContentTypeCode);

            BOLNews NewsBOL = new BOLNews();
            int TakeCount = 4;
            if (_hCContentTypeCode == 5)//دیدگاه
                TakeCount = 2;
            if (_hCContentTypeCode == 8)//دیگر رسانه ها 
                TakeCount = 5;
            if (_hCContentTypeCode == 3)//گزارش 
                TakeCount = 3;
            if (_hCContentTypeCode == 2)//مصاحبه 
                TakeCount = 2;
            rptItems.DataSource = NewsBOL.GetNewsByContentType(_hCContentTypeCode, TakeCount, 1);
            rptItems.DataBind();
            hplMore.NavigateUrl = "~/News/?CT=" + _hCContentTypeCode;
        }
    }
}