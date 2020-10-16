using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using AceNews.Old_Code.DAL;

public class BOLEvents : BaseBOLEvents, IBaseBOL<Events>
{
    public IList CheckBusinessRules()
    {
        var messages = new List<string>();

        #region Business Rules
        //Example
        //if (string.IsNullOrEmpty(this.FirstName))
        //    messages.Add("Please fill FirstName.");

        #endregion
        return messages;
    }

    internal string GetTodayHeader()
    {
        string Result = "";
        IQueryable<Events> EventList = dataContext.Events.Where(p=>p.EventDate.Value.Month == DateTime.Now.Month && p.EventDate.Value.Date.Day == DateTime.Now.Day);
        if(EventList.Count() > 0)
        {
            Result =EventList.First().PicFile;
        }
        return Result;


    }

    internal bool SaveEventDate(int Code, DateTime? EventDate)
    {
        try
        {
            Events Curevent = dataContext.Events.SingleOrDefault(p => p.Code.Equals(Code));
            if (Curevent != null && EventDate != null)
            {
                Curevent.EventDate = EventDate;
                dataContext.SubmitChanges();
                return true;
            }
            else
                return false;
        }
        catch
        {
            return false;
        }
    }
}
