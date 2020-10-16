using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASNoor.UserControls
{
    public partial class UCLangSelector : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int LangCode = Tools.GetLang();

            if (LangCode == 1)
                hplAr.ForeColor = System.Drawing.Color.Red;
            if (LangCode == 2)
                hplFarsi.ForeColor = System.Drawing.Color.Red;
            if (LangCode == 3)
                hplEn.ForeColor = System.Drawing.Color.Red;
        }
    }
}