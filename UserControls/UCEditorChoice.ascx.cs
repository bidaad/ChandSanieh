﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCEditorChoice : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLNews NewsBOL = new BOLNews();
            rptNews.DataSource = NewsBOL.GetEditorChoice(10);
            rptNews.DataBind();
        }
    }
}