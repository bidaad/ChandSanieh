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

public class BOLGalleries : BaseBOLGalleries, IBaseBOL<Galleries>
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

    internal AceNews.Old_Code.DAL.Galleries GetDetails(int Code)
    {
        return dataContext.Galleries.SingleOrDefault(p => p.Code.Equals(Code));
    }

    public object GetGalleries(int TakeCount)
    {

        IQueryable<vGalleries> Result = dataContext.vGalleries.OrderByDescending(p=> p.Code).Take(TakeCount);
        return Result;
    }

    
}
