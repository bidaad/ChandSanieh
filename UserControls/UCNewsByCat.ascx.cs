using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCNewsByCat : System.Web.UI.UserControl
    {
        protected int _hCNewsCatCode;

        public int HCNewsCatCode
        {
            get
            {
                return _hCNewsCatCode;
            }
            set
            {
                _hCNewsCatCode = value;
            }
        }

        protected int _newsCount;

        public int NewsCount
        {
            get
            {
                return _newsCount;
            }
            set
            {
                _newsCount = value;
            }
        }


        
        protected void Page_Load(object sender, EventArgs e)
        {

            BOLHardCode HardCodeBOL = new BOLHardCode();
            HardCodeBOL.TableOrViewName = "HCNewsCats";
            ltrHeader.Text = HardCodeBOL.GetNameByCode(_hCNewsCatCode);
            hplArchive.NavigateUrl = "~/?CatCode=" + _hCNewsCatCode + "&Archive=1";


            BOLNews NewsBOL = new BOLNews();
            rptNews.DataSource = NewsBOL.GetLatestNewsList(_hCNewsCatCode, null, _newsCount, 1, null, "", null);
            rptNews.DataBind();
        }
    }
}