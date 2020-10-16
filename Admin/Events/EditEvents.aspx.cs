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
using AceNews.Old_Code.DAL;
using System.Globalization;


public partial class Events_EditEvents : EditForm<Events>
{
    private string BaseID = "Events";
    IBaseBOL<Events> BaseBOL;



    protected void Page_Load(object sender, EventArgs e)
    {
        #region Tab Pages
        //if (!NewMode)
        //     ShowDetails();
        //else
        //{
        //     RadMultiPage1.SelectedIndex = 0;
        //     tsEvents.Tabs[0].Selected = true;
        //}
        #endregion
        BOLClass = new BOLEvents();
        lblSysName.Text = BOLClass.PageLable;

        if ((Code == null) && (!NewMode)) return;
        if (!Page.IsPostBack)
        {
            //if (!NewMode) ShowDetails();


            #region Fill Combo
            cboHCCalendarTypeCode.DataSource = new BOLHardCode().GetHCDataTable("HCCalendarTypes");

            #endregion
            if (!NewMode)
            {
                LoadData((int)Code);
            }
        }


    }

    protected void DoSave(object sender, ImageClickEventArgs e)
    {
        try
        {
            msgBox.Text = "";
            string strSelectedMonth = txtMonthNo.Text.ToString();
            string strSelectedDay = txtDayNo.Text.ToString();
            int SelectedMonth;
            int SelectedDay;
            Int32.TryParse(strSelectedMonth, out SelectedMonth);
            Int32.TryParse(strSelectedDay, out SelectedDay);
            if (SelectedMonth == 0 || SelectedMonth > 12)
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = "ماه معتبر نیست";
                return;
            }
            if (SelectedDay == 0 || SelectedDay > 31)
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = "روز معتبر نیست";
                return;
            }

            int ReturnCode = SaveControls("~/Main/Default.aspx?BaseID=" + BaseID);
            if (NewMode && ReturnCode != -1)
            {
                NewMode = false;
                Code = ReturnCode;
                ShowDetails();
            }
            if (ReturnCode != -1)
            {
                DateTime? EventDate = null;
                if (cboHCCalendarTypeCode.SelectedValue == "1")
                {
                    PersianCalendar PCalendar = new PersianCalendar();
                    EventDate = PCalendar.ToDateTime(1390, SelectedMonth, SelectedDay, 12, 1, 1, 1);
                }
                if (cboHCCalendarTypeCode.SelectedValue == "2")
                {
                    HijriCalendar HCalendar = new HijriCalendar();
                    EventDate = HCalendar.ToDateTime(1390, SelectedMonth, SelectedDay, 12, 1, 1, 1);
                }
                else
                    EventDate = new DateTime(2011, SelectedMonth, SelectedDay, 12, 1, 1, 1);

                BOLEvents EventsBOL = new BOLEvents();
                EventsBOL.SaveEventDate(ReturnCode, (DateTime)EventDate);
            }
        }
        catch
        {
        }
    }
    private void ShowDetails()
    {
        //string Tab1Click = "BrowseObj1.ShowDetail('CenterBoss', '" + Code
        //      + "', true,'BrowseObj1');BrowseObj2.ShowDetail('CenterResearchSectionManagers', '" + Code
        //      + "', true,'BrowseObj2');BrowseObj3.ShowDetail('CenterExecutiveManagers', '" + Code
        //      + "', true,'BrowseObj3')";


        //Tab1.Attributes.Add("onclick", Tab1Click);
        //Tools.SetClientScript(this, "ActiveTab1", Tab1Click);

        //#region HanldeSelectedTab
        //if (Request["SelectedTab"] != null)
        //{
        //    RadMultiPage1.SelectedIndex = Int32.Parse(Request["SelectedTab"]);
        //    SelectedTabIndex = Int32.Parse(Request["SelectedTab"]);
        //    switch (Int32.Parse(Request["SelectedTab"]))
        //    {
        //        case 0:
        //            Tools.SetClientScript(Page, "ClickTab", Tab1Click);
        //            RadMultiPage1.SelectedIndex = 0;
        //            tsEvents.SelectedIndex = 0;
        //            break;
        //        default:
        //            break;
        //    }
        //    tsEvents.Tabs[Int32.Parse(Request["SelectedTab"])].Selected = true;
        //}
        //else
        //{
        //    RadMultiPage1.SelectedIndex = 0;
        //    tsEvents.Tabs[0].Selected = true;
        // }
        //#endregion
    }
}
