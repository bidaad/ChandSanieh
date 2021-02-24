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
using DataAccess;

public class BOLNews : BaseBOLNews, IBaseBOL<News>
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

    internal IQueryable<vNews> Search(DateTime? FromDate, DateTime? ToDate, string FromNewsNum, string ToNewsNum, string Keyword, int SearchType, int? HCNewsTypeCode)
    {
        IQueryable<vNews> Result = dataContext.vNews;
        if (FromDate != null)
            Result = Result.Where(p => p.NewsDate.CompareTo(FromDate) >= 0);
        if (ToDate != null)
            Result = Result.Where(p => p.NewsDate.CompareTo(ToDate) <= 0);
        if (!string.IsNullOrEmpty(FromNewsNum))
            Result = Result.Where(p => p.NewsNumber.CompareTo(FromNewsNum) >= 0);
        if (!string.IsNullOrEmpty(ToNewsNum))
            Result = Result.Where(p => p.NewsNumber.CompareTo(ToNewsNum) <= 0);
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));

        if (!string.IsNullOrEmpty(Keyword))
        {
            if (SearchType >= 1)
                Result = Result.Where(p => p.Title.Contains(Keyword));
            if (SearchType >= 2)
                Result = Result.Where(p => p.NewsBody.Contains(Keyword));
        }

        Result = Result.OrderByDescending(p => p.NewsDate).OrderByDescending(p => p.Priority);
        return Result;
    }

    internal object GetMostViewedNews(int? LangCode, int TakeCount)
    {
        //return dataContext.vMostViewedNews.Where(p => p.HCLanguageCode.Equals(LangCode)).OrderByDescending(p => p.VisitCount).Take(TakeCount);
        return null;
    }

    internal IQueryable<vNews> GetItems(int PageSize, int PageNo, int? HCNewsTypeCode)
    {
        int SkipCount = (PageNo - 1) * PageSize;
        IQueryable<vNews> Result = dataContext.vNews;
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));
        return Result.OrderByDescending(p => p.Code).Skip(SkipCount).Take(PageSize);
    }

    internal int SearchNewsCount(int? HCNewsTypeCode)
    {
        IQueryable<vNews> Result = dataContext.vNews;
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));
        return Result.Count();
    }

    internal IQueryable<vNews> GetLatestTelexNews(int TakeCount, int? HCNewsTypeCode)
    {
        IQueryable<vNews> Result = dataContext.vNews;
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));
        return Result.Where(p => p.ShowInTelex.Equals(true)).OrderByDescending(p => p.NewsDate).Take(TakeCount);
    }

    internal vNews GetLatestNews(int? HCNewsTypeCode)
    {
        IQueryable<vNews> Result = dataContext.vNews;
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));
        return Result.OrderByDescending(p => p.Priority).FirstOrDefault();
    }



    internal IQueryable<vNews> GetLatestNews(int TakeCount, int? HCNewsTypeCode)
    {
        IQueryable<vNews> Result = dataContext.vNews;
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));

        return Result.Take(TakeCount).OrderByDescending(p => p.Code);
    }


    internal IQueryable<vLatestNews> GetLatestNewsList(int? HCNewsCatCode, int[] ExcludeCodeArray, int PageSize, int PageNo, int? HCContentTypeCode, string strDate, int? HCNewsTypeCode)
    {
        int SkipCount = (PageNo - 1) * PageSize;
        IQueryable<vLatestNews> Result = dataContext.vLatestNews; //.Where(p => p.ShowInNews.Equals(true) && p.PicFile1 != null);

        if (ExcludeCodeArray != null)
            Result = Result.Where(p => !ExcludeCodeArray.Contains(p.Code));
        if (HCContentTypeCode != null)
            Result = Result.Where(p => p.HCContentTypeCode.Equals(HCContentTypeCode));
        if (HCNewsCatCode != null)
            Result = Result.Where(p => p.HCNewsCatCode.Equals(HCNewsCatCode));
        if (!string.IsNullOrEmpty(strDate))
            Result = Result.Where(p => p.NDate.Equals(strDate));
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));

        Result = Result.OrderByDescending(p => p.Priority).Skip(SkipCount).Take(PageSize);

        return Result;
    }

    internal int GetLatestNewsListCount(int? HCNewsCatCode, int[] ExcludeCodeArray, int PageSize, int PageNo, int? HCContentTypeCode, string strDate, int? HCNewsTypeCode)
    {
        int SkipCount = (PageNo - 1) * PageSize;
        IQueryable<vLatestNews> Result = dataContext.vLatestNews; //.Where(p => p.ShowInNews.Equals(true) && p.PicFile1 != null);

        if (ExcludeCodeArray != null)
            Result = Result.Where(p => !ExcludeCodeArray.Contains(p.Code));
        if (HCContentTypeCode != null)
            Result = Result.Where(p => p.HCContentTypeCode.Equals(HCContentTypeCode));
        if (HCNewsCatCode != null)
            Result = Result.Where(p => p.HCNewsCatCode.Equals(HCNewsCatCode));
        if (!string.IsNullOrEmpty(strDate))
            Result = Result.Where(p => p.NDate.Equals(strDate));
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));

        return Result.Count();
    }

    internal object GetNewsByContentType(int HCContentTypeCode, int TakeCount, int? HCNewsTypeCode)
    {
        IQueryable<vNews> Result = dataContext.vNews;
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));

        return Result.Where(p => p.HCContentTypeCode.Equals(HCContentTypeCode) && p.ShowInNews.Equals(true)).OrderByDescending(p => p.NewsDate).Take(TakeCount);
    }

    internal IQueryable<vNews> GetNewsByContentTypeCode(int HCContentTypeCode, int PageSize, int PageNo, int? HCNewsTypeCode)
    {
        int SkipCount = (PageNo - 1) * PageSize;
        IQueryable<vNews> Result = dataContext.vNews;
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));

        return Result.Where(p => p.ShowInNews.Equals(true) && p.HCContentTypeCode.Equals(HCContentTypeCode) && p.PicFile1 != null).OrderByDescending(p => p.NewsDate).Skip(SkipCount).Take(PageSize);
    }

    internal int GetNewsByContentTypeCodeCount(int HCContentTypeCode, int? HCNewsTypeCode)
    {
        IQueryable<vNews> Result = dataContext.vNews;
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));

        return Result.Where(p => p.ShowInNews.Equals(true) && p.HCContentTypeCode.Equals(HCContentTypeCode) && p.PicFile1 != null).OrderByDescending(p => p.NewsDate).Count();
    }

    internal object GetNewsByCatTypeCode(int HCNewsCatCode, int TakeCount, int? HCNewsTypeCode)
    {
        IQueryable<vNews> Result = dataContext.vNews;
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));
        return Result.Where(p => p.HCNewsCatCode.Equals(HCNewsCatCode)).OrderByDescending(p => p.NewsDate).Take(TakeCount);
    }

    internal object GetSmallNews(int TakeCount, int? HCNewsTypeCode)
    {
        IQueryable<vNews> Result = dataContext.vNews;
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));
        return Result.Where(p => p.Title.Length <= 40).OrderByDescending(p => p.NewsDate).Take(TakeCount);
    }

    internal IQueryable<vNews> GetNewsByCatCode(int HCNewsCatCode, int PageSize, int PageNo, int? HCContentTypeCode, int? HCNewsTypeCode)
    {
        int SkipCount = (PageNo - 1) * PageSize;
        IQueryable<vNews> Result;

        Result = dataContext.vNews.Where(p => p.HCNewsCatCode.Equals(HCNewsCatCode));

        if (HCContentTypeCode != null)
            Result = Result.Where(p => p.HCContentTypeCode.Equals(HCContentTypeCode));
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));

        Result = Result.OrderByDescending(p => p.NewsDate).Skip(SkipCount).Take(PageSize);
        return Result;
    }

    internal int GetNewsByCatCodeCount(int HCNewsCatCode, int? HCNewsTypeCode)
    {
        IQueryable<vNews> Result;

        Result = dataContext.vNews.Where(p => p.HCNewsCatCode.Equals(HCNewsCatCode));
        if (HCNewsTypeCode != null && HCNewsTypeCode != 0)
            Result = Result.Where(p => p.HCNewsTypeCode.Equals(HCNewsTypeCode));

        return Result.Count();
    }















    internal int GetLatestPriority(int SkipCount)
    {
        News LatestPriorityNews = dataContext.News.OrderByDescending(p => p.Priority).Skip(SkipCount).Take(1).SingleOrDefault();
        if (LatestPriorityNews == null)
            return 100;
        else
            return LatestPriorityNews.Priority;
    }

    internal void SetNewPriority(int Code, int NewPririty)
    {
        News CurNews = dataContext.News.SingleOrDefault(p => p.Code.Equals(Code));
        if (CurNews != null)
        {
            CurNews.Priority = NewPririty;
            dataContext.SubmitChanges();
        }
    }

    internal bool ChangePririties(int NewsCode1, int NewsCode2)
    {
        News News1 = dataContext.News.SingleOrDefault(p => p.Code.Equals(NewsCode1));
        News News2 = dataContext.News.SingleOrDefault(p => p.Code.Equals(NewsCode2));
        if (News1 != null && News2 != null)
        {
            int tmpPriority = News1.Priority;
            News1.Priority = News2.Priority;
            News2.Priority = tmpPriority;
            dataContext.SubmitChanges();
            return true;
        }
        return false;
    }

    internal DataTable SearchNews(int PageSize, int PageNo, string Keyword, out int ResultCount)
    {
        string WhereClause = Tools.MakeWhereClause(Keyword, "Title,Abstract");
        string cnStr = ConfigurationManager.ConnectionStrings["AceNewsConnectionString"].ConnectionString;
        SQLServer dal = new SQLServer(cnStr);

        // ************************************** Add SP Parameters *********************************************
        dal.AddParameter("@WhereClause", WhereClause, SQLServer.SQLDataType.SQLNVarchar, 500, ParameterDirection.Input);
        // ************************************** Add SP Parameters *********************************************

        DataSet ds = dal.runSPDataSet("dbo.spSearchNews", null);
        dal.ClearParameters();
        DataTable dt = ds.Tables[0];
        ResultCount = dt.Rows.Count;
        return dt;

        //int SkipCount = (PageNo - 1) * PageSize;
        //IQueryable<vNews> Result = dataContext.vNews.Where(p => p.Title.Contains(Keyword) || p.NewsBody.Contains(Keyword));
        //ResultCount = Result.Count();
        //Result = Result.Skip(SkipCount).Take(PageSize);
        //return Result;
    }



    internal object GetImageGallery(int TakeCount)
    {
        return dataContext.News.Where(p => p.HCContentTypeCode.Equals(6) && p.ShowInNews.Equals(true)).OrderByDescending(p => NewsDate).OrderByDescending(p => p.Priority).Take(TakeCount);
    }



    internal void SaveNewsDate(int Code, DateTime NewsDate)
    {
        News CurNews = dataContext.News.SingleOrDefault(p => p.Code.Equals(Code));
        if (CurNews != null)
        {
            CurNews.NewsDate = NewsDate;
            dataContext.SubmitChanges();
        }
    }





    internal void SaveNewsBody(int Code, string NewsBody)
    {
        News CurNews = dataContext.News.SingleOrDefault(p => p.Code.Equals(Code));
        if (CurNews != null)
        {
            CurNews.NewsBody = NewsBody;
            dataContext.SubmitChanges();
        }
    }

    internal int VerifyPriority(int CurPriority)
    {
        int Result = CurPriority;
        News CurNews;
        CurNews = dataContext.News.SingleOrDefault(p => p.Priority.Equals(CurPriority));
        while (CurNews != null)
        {
            CurPriority += 10;
            CurNews = dataContext.News.SingleOrDefault(p => p.Priority.Equals(CurPriority));
        }
        return CurPriority;
    }

    internal void MoveTopNews(int CurPririty)
    {
        var TopNewsList = dataContext.News.Where(p => p.Priority >= CurPririty).OrderBy(p => p.Priority);
        int NewTopPriority = CurPririty + 100;
        foreach (var CurNews in TopNewsList)
        {
            CurNews.Priority = NewTopPriority;
            NewTopPriority += 100;
        }
        dataContext.SubmitChanges();
    }

    internal IQueryable<vNews> GetMainCatItems(int[] ExcludeCodeArray, int PageSize, int PageNo, int HCCatTypeCode)
    {
        int SkipCount = (PageNo - 1) * PageSize;
        IQueryable<vNews> Result = dataContext.vNews.Where(p => p.ShowInNews.Equals(true) && p.PicFile1 != null && p.HCContentTypeCode.Equals(1));
        Result = Result.Where(p => !ExcludeCodeArray.Contains(p.Code));
        switch (HCCatTypeCode)
        {
            case 1:
                Result = Result.Where(p => p.HCNewsCatCode.Equals(1) || p.HCNewsCatCode.Equals(4) || p.HCNewsCatCode.Equals(12));
                break;
            case 2:
                Result = Result.Where(p => p.HCNewsCatCode.Equals(8));
                break;
            case 3:
                Result = Result.Where(p => p.HCNewsCatCode.Equals(6) || p.HCNewsCatCode.Equals(1));
                break;
            default:
                break;
        }
        Result = Result.Where(p => !ExcludeCodeArray.Contains(p.Code));
        return Result;
    }

    internal int GetMainCatItemsCount(int HCNewsCatCode)
    {
        IQueryable<vNews> Result = dataContext.vNews.Where(p => p.ShowInNews.Equals(true) && p.PicFile1 != null && p.HCContentTypeCode.Equals(1));
        switch (HCNewsCatCode)
        {
            case 1:
                Result = Result.Where(p => p.HCNewsCatCode.Equals(1) || p.HCNewsCatCode.Equals(4) || p.HCNewsCatCode.Equals(12));
                break;
            case 2:
                Result = Result.Where(p => p.HCNewsCatCode.Equals(8));
                break;
            case 3:
                Result = Result.Where(p => p.HCNewsCatCode.Equals(6) || p.HCNewsCatCode.Equals(1));
                break;
            default:
                break;
        }

        return Result.Count();
    }

    internal int GetPriorityByOrder(int SkipCount)
    {
        return dataContext.News.Where(p => p.ShowInNews.Equals(true)).OrderByDescending(p => p.Priority).Skip(SkipCount).Take(1).SingleOrDefault().Code;
    }

    internal IQueryable<News> GetImageGallery(int PageSize, int PageNo)
    {
        int SkipCount = (PageNo - 1) * PageSize;
        IQueryable<News> Result = dataContext.News.Where(p => p.HCContentTypeCode.Equals(6) && p.ShowInNews.Equals(true)).OrderByDescending(p => NewsDate).OrderByDescending(p => p.Priority).Skip(SkipCount).Take(PageSize);
        return Result;

    }

    internal int GetImageGalleryCount()
    {
        return dataContext.News.Where(p => p.HCContentTypeCode.Equals(6) && p.ShowInNews.Equals(true)).OrderByDescending(p => NewsDate).OrderByDescending(p => p.Priority).Count();
    }







    internal News GetData(int Code)
    {
        return dataContext.News.SingleOrDefault(p => p.Code.Equals(Code));
    }

    internal IQueryable<vNews> GetSepcialNews(int TakeCount)
    {
        return dataContext.vNews.Where(p => p.Special.Equals(true)).OrderByDescending(p => p.NewsDate).Take(TakeCount);
    }

    internal object GetRelatedNews(int Code, int TakeCount)
    {
        return dataContext.vNewsRelatedNews.Where(p => p.NewsCode.Equals(Code)).OrderByDescending(p => p.Code).Take(TakeCount);
    }

    internal void ChangeSmallPic(int Code, string PicFile1)
    {
        PicFile1 = PicFile1.Replace("~/", "/");
        News CurNews = dataContext.News.SingleOrDefault(p => p.Code.Equals(Code));
        CurNews.PicFile1 = PicFile1;
        dataContext.SubmitChanges();
    }

    internal object GetEditorChoice(int TakeCount)
    {
        return dataContext.News.Where(p => p.EditorChoice.Equals(true)).OrderByDescending(p => p.Code).Take(TakeCount);
    }

    internal object GetAllNews()
    {
        return dataContext.News.OrderByDescending(p => p.Code);
    }
}
