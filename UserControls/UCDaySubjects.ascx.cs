using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;

namespace AceNews.UserControls
{
    public partial class UCDaySubjects : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLDaySubjects DaySubjectsBOL = new BOLDaySubjects();
            vDaySubjects LatestItem = DaySubjectsBOL.GetLatestRecord();
            if (LatestItem != null)
            {
                lblTitle.Text = LatestItem.Title;
                lblDescription.Text = Tools.FormatString( LatestItem.Description);
            }
        }
    }
}