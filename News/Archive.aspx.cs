using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace AceNews.NewsFolder
{
    public partial class Archive : System.Web.UI.Page
    {
        public int CurYear = 1393;
        protected void Page_Load(object sender, EventArgs e)
        {
            string strYear = Request["y"];
            Int32.TryParse(strYear, out CurYear);
            if (CurYear == 0)
                CurYear = 1393;
            PersianCalendar1.CurYear = CurYear;
            PersianCalendar1.CurMonth = 1;

            PersianCalendar2.CurYear = CurYear;
            PersianCalendar2.CurMonth = 2;

            PersianCalendar3.CurYear = CurYear;
            PersianCalendar3.CurMonth = 3;

            PersianCalendar4.CurYear = CurYear;
            PersianCalendar4.CurMonth = 4;

            PersianCalendar5.CurYear = CurYear;
            PersianCalendar5.CurMonth = 5;

            PersianCalendar6.CurYear = CurYear;
            PersianCalendar6.CurMonth = 6;

            PersianCalendar7.CurYear = CurYear;
            PersianCalendar7.CurMonth = 7;

            PersianCalendar8.CurYear = CurYear;
            PersianCalendar8.CurMonth = 8;

            PersianCalendar9.CurYear = CurYear;
            PersianCalendar9.CurMonth = 9;

            PersianCalendar10.CurYear = CurYear;
            PersianCalendar10.CurMonth = 10;

            PersianCalendar11.CurYear = CurYear;
            PersianCalendar11.CurMonth = 11;

            PersianCalendar12.CurYear = CurYear;
            PersianCalendar12.CurMonth = 12;



            //DataTable tblMonths = new DataTable();
            //DataColumn dc = new DataColumn("Month", typeof(int));
            //tblMonths.Columns.Add(dc);

            //DataColumn dcYear = new DataColumn("Year", typeof(int));
            //tblMonths.Columns.Add(dcYear);
            
            //for (int i = 1; i <= 1; i++)
            //{
            //    DataRow dr = tblMonths.NewRow();
            //    dr["Month"] = i.ToString();
            //    dr["Year"] = CurYear;
            //    tblMonths.Rows.Add(dr);
            //}

            //rptMonths.DataSource = tblMonths;
            //rptMonths.DataBind();
        }
    }
}