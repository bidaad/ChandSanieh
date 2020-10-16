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

public class BOLCenterContacts : BaseBOLCenterContacts, IBaseBOL<CenterContacts>
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

    internal bool Insert(string Name, string Email, string Comment)
    {
        try
        {
            CenterContacts NewRecord = new CenterContacts();
            dataContext.CenterContacts.InsertOnSubmit(NewRecord);
            NewRecord.Name = Name;
            NewRecord.Email = Email;
            NewRecord.Comment = Comment;
            NewRecord.SendDate = DateTime.Now;
            dataContext.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
