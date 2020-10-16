using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class UserControls_SiteLog : System.Web.UI.UserControl
{

    protected int _langCode = 1;
    public int LangCode
    {
        get
        {
            return _langCode;
        }
        set
        {
            _langCode = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        

        BOLLogs LogsBOL = new BOLLogs();

        if (_langCode == 1)
        {

            lblTodayVisit.Text = LogsBOL.GetLogCountByDate(DateTime.Now);
            lblYesterdayVisit.Text = LogsBOL.GetLogCountByDate(DateTime.Now.AddDays(-1));
            lblTotalVisit.Text = LogsBOL.GetTotalCount();

            lblTodayVisit.Text = Tools.ChangeEnc(lblTodayVisit.Text);
            lblYesterdayVisit.Text = Tools.ChangeEnc(lblYesterdayVisit.Text);
            lblTotalVisit.Text = Tools.ChangeEnc(lblTotalVisit.Text);

        }
        else
        {
            lblTodayVisit.Text = LogsBOL.GetLogCountByDate(DateTime.Now);
            lblYesterdayVisit.Text = LogsBOL.GetLogCountByDate(DateTime.Now.AddDays(-1));
            lblTotalVisit.Text = LogsBOL.GetTotalCount();

            lblTodayVisitLabel.Text = "Today: ";
            lblTotalVisitLabel.Text = "Total visits: ";
            lblYesterdayVisitLabel.Text = "Yedterday: ";
        }

    }
}
