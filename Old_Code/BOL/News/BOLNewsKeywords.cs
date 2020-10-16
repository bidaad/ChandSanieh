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
  
public class BOLNewsKeywords : BaseBOLNewsKeywords, IBaseBOL<NewsKeywords>
{
    public BOLNewsKeywords(params int[] MCodes): base(MCodes)
    {
        
    }
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

    internal void Insert(int Code, string Keyword)
    {
        try
        {
            NewsKeywords NewRecord = new NewsKeywords();
            NewRecord.NewsCode = Code;
            NewRecord.Keyword = Keyword.Trim();

            dataContext.NewsKeywords.InsertOnSubmit(NewRecord);
            dataContext.SubmitChanges();
        }
        catch
        {
        }

    }

    internal void DeleteAllKeywords(int Code)
    {
        try
        {
            var Result = dataContext.NewsKeywords.Where(p => p.NewsCode.Equals(Code));
            dataContext.NewsKeywords.DeleteAllOnSubmit(Result);
            dataContext.SubmitChanges();
        }
        catch
        {
        }
    }

    internal object GetKeywords(int Code)
    {
        return dataContext.NewsKeywords.Where(p => p.NewsCode.Equals(Code));
    }
}
