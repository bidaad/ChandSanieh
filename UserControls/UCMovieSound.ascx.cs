using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;

namespace AceNews.UserControls
{
    public partial class UCMovieSound : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLMultiMedias MultiMediasBOL = new BOLMultiMedias();

            rptMovies.DataSource = MultiMediasBOL.GetListByType( 2, 5, 1);
            rptMovies.DataBind();
            if (rptMovies.Items.Count == 0)
                pnlLatestMovies.Visible = false;

            rptSounds.DataSource = MultiMediasBOL.GetListByType( 3, 5, 1);
            rptSounds.DataBind();
        }
    }
}