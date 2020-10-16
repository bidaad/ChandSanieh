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

public class BOLMultiMedias : BaseBOLMultiMedias, IBaseBOL<MultiMedias>
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

    internal MultiMedias GetLatestByType(int HCPicTypeCode)
    {
        IQueryable<MultiMedias> Result = dataContext.MultiMedias.Where(p => p.HCPicTypeCode.Equals(HCPicTypeCode)).OrderByDescending(p => p.Code).Take(1);
        if (Result.Count() > 0)
        {
            return Result.First();
        }
        else
            return null;
    }

    internal IQueryable<MultiMedias> GetListByType(int? HCPicTypeCode, int PageSize, int PageNo)
    {
        int SkipCount = (PageNo -1) * PageSize;
        IQueryable<MultiMedias> Result = dataContext.MultiMedias;
        if (HCPicTypeCode != null)
            Result = Result.Where(p => p.HCPicTypeCode.Equals(HCPicTypeCode));
        Result = Result.Skip(SkipCount).Take(PageSize).OrderByDescending(p => p.Code);

        return Result;
    }

    internal MultiMedias GetDetails(int Code)
    {
        return dataContext.MultiMedias.SingleOrDefault(p => p.Code.Equals(Code));
    }

    internal void ChangeSmallPic(int Code, string PicFile)
    {
        PicFile = PicFile.Replace("~/", "/");
        MultiMedias CurNews = dataContext.MultiMedias.SingleOrDefault(p => p.Code.Equals(Code));
        CurNews.PicFile = PicFile;
        dataContext.SubmitChanges();
    }

    internal object GetLatestByType(int PageNo, int TakeCount, int HCPicTypeCode)
    {
        int SkipCount = (PageNo - 1) * TakeCount;
        return dataContext.vMultiMedias.Where(p => p.HCPicTypeCode.Equals(HCPicTypeCode)).OrderByDescending(p => p.Code).Skip(SkipCount).Take(TakeCount);
    }
    internal int GetLatestByTypeCount(int HCPicTypeCode)
    {
        return dataContext.vMultiMedias.Where(p => p.HCPicTypeCode.Equals(HCPicTypeCode)).Count();
    }
}
