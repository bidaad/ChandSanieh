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

public class BOLEnLinks : BaseBOLEnLinks, IBaseBOL<EnLinks>
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
    public object GetRandLinks(int TakeCount)
    {
        return dataContext.vRandEnLinks.Take(TakeCount);
    }

    public object GetLinksByCat(int CatCode)
    {
        return dataContext.EnLinks.Where(p => p.HCEnLinkCatCode.Equals(CatCode));
    }
}
