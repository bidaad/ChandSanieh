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

public class BOLDaySubjects : BaseBOLDaySubjects, IBaseBOL<DaySubjects>
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

    internal vDaySubjects GetLatestRecord()
    {
        var Result = dataContext.vDaySubjects.OrderByDescending(p => p.Code).Take(1);
        if (Result.Count() == 1)
            return Result.First();
        else
            return null;

      
    }

    internal object GetList(int PageNo, int PageSize)
    {
        int SkipCount = (PageNo - 1) * PageSize;
        return dataContext.vDaySubjects.Skip(SkipCount).Take(PageSize);
    }

    internal int GetListCount()
    {
        return dataContext.vDaySubjects.Count();
    }
}
