using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace ASNoor
{
    public partial class MyTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                LoadTinyMCE();
        }

        private void LoadTinyMCE()
        {



        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {


        }
    }
}