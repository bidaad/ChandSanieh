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
using System.Globalization;

public partial class UserControls_PersianCalendar : System.Web.UI.UserControl
{
    protected int StartDay;
    protected int DaysOfMonth;
    protected int _curMonth;
    public int CurMonth
    {
        get
        {
            return _curMonth;
        }
        set
        {
            _curMonth = value;
            PersianCalendar pc = new PersianCalendar();
            DateTime CurrentDT = DateTime.Now;
            if (_curYear == 0)
                _curYear = pc.GetYear(CurrentDT);
            if (_curMonth == 0)
                _curMonth = pc.GetMonth(CurrentDT);

            DataTable tblDays = new DataTable();
            DataColumn dc = new DataColumn("Day");
            tblDays.Columns.Add(dc);
            for (int i = 1; i < 42; i++)
            {
                DataRow dr = tblDays.NewRow();
                dr["Day"] = i.ToString();
                tblDays.Rows.Add(dr);
            }

            lblHeader.Text = GetPersianMonthName(_curMonth) + " " + Tools.ChangeEnc(_curYear.ToString());
            DateTime dt = pc.ToDateTime(_curYear, _curMonth, 1, 0, 0, 0, 0);
            DaysOfMonth = pc.GetDaysInMonth(_curYear, _curMonth);
            StartDay = GetPersianStartDay(Convert.ToInt32(dt.DayOfWeek));
            dtlDays.DataSource = tblDays;
            dtlDays.DataBind();
        }
    }
    protected int _curYear;
    public int CurYear
    {
        get
        {
            return _curYear;
        }
        set
        {
            _curYear = value;
        }
    }
    int Counter = 0;
    int DayCounter = 1;
    public string ShowDay(object obj)
    {
        string Result = "";
        Counter++;
        if (Counter < StartDay || DayCounter > DaysOfMonth)
            Result = "";
        else
        {
            Result = GetDay(DayCounter);
            DayCounter++;
        }
        return Result;

    }
    protected string GetDay(int DayIndex)
    {
        //if (_dayEvents == null)
        //{
        //    return "<div>" + DayIndex.ToString() + "</div>";
        //}
        //for (int i = 0; i < _dayEvents.Count; i++)
        //{
        //    if (Convert.ToInt32(((string[])_dayEvents[i])[0]) == DayIndex)
        //        return "<div class='cEventDay'><a target=\"_blank\" href=\"" + ((string[])_dayEvents[i])[1] + "\" title=\"" + ((string[])_dayEvents[i])[2].Replace("\"", "").Replace("'", "") + "\" >" + Tools.ChangeEnc(DayIndex.ToString()) + "</a></div>";

        //}

        string strDay = DayIndex.ToString();
        string strMonth = CurMonth.ToString();
        string strYear = CurYear.ToString();
        if (strDay.Length == 1) strDay = "0" + strDay;
        if (strMonth.Length == 1) strMonth = "0" + strMonth;

        return "<a target=\"_blank\" href=\"/News/?d=" + strYear + "/" + strMonth + "/" + strDay + "\" title=\"" + DayIndex + "\" >" + Tools.ChangeEnc(DayIndex.ToString()) + "</a>";
    }
    protected ArrayList _dayEvents;
    public ArrayList DayEvents
    {
        get
        {
            return _dayEvents;
        }
        set
        {
            _dayEvents = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected int GetPersianStartDay(int GStartDay)
    {
        switch (GStartDay)
        {
            case 1:
                return 3;
            case 2:
                return 4;
            case 3:
                return 5;
            case 4:
                return 6;
            case 5:
                return 7;
            case 6:
                return 1;
            case 7:
                return 2;
            default:
                return 0;
        }
    }
    public string GetPersianMonthName(int MonthNumber)
    {
        string MonthName;
        switch (MonthNumber)
        {
            case 1:
                MonthName = "فروردین";
                break;
            case 2:
                MonthName = "اردیبهشت";
                break;
            case 3:
                MonthName = "خرداد";
                break;
            case 4:
                MonthName = "تیر";
                break;
            case 5:
                MonthName = "مرداد";
                break;
            case 6:
                MonthName = "شهریور";
                break;
            case 7:
                MonthName = "مهر";
                break;
            case 8:
                MonthName = "آبان";
                break;
            case 9:
                MonthName = "آذر";
                break;
            case 10:
                MonthName = "دی";
                break;
            case 11:
                MonthName = "بهمن";
                break;
            case 12:
                MonthName = "اسفند";
                break;
            default:
                MonthName = "نامشخص";
                break;
        }
        return MonthName;
    }

}
