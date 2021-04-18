using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;
using AceNews.Old_Code.BOL.Likes;

namespace AceNews.Web.UI.UserControls
{
    public partial class NewsList : System.Web.UI.UserControl
    {
        protected TimeFormats _timeFormat = TimeFormats.TimeAgo;
        public TimeFormats TimeFormat
        {
            get
            {
                return _timeFormat;
            }
            set
            {
                _timeFormat = value;
            }
        }

        protected bool _showHeader = true;
        public bool ShowHeader
        {
            get
            {
                return _showHeader;
            }
            set
            {
                _showHeader = value;
            }
        }
        public string CaptionClass = "Latest";
        public string CurrentKeywrod
        {
            set
            {
                _keyword = value;
            }
            get
            {
                return _keyword;
            }
        }
        protected string _keyword = null;
        public bool ShowTime = false;
        public string strPageNo;
        public int PageNo = 1;
        int _pageSize = 15;
        string ConcatUrl;
        protected bool _showPaging;
        public bool ShowPaging
        {
            set
            {
                pnlPaging.Visible = value;
            }
        }

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public string GetLikeCount(object obj)
        {
            if (obj != null)
            {
                int NewsCode = Convert.ToInt32(obj);
                BOLLikes LikesBOL = new BOLLikes();
                int LikeCount = LikesBOL.GetCount(1, NewsCode);
                return  LikeCount.ToString();
            }
            else
                return "";
        }

        public string PersianDate(Object obj)
        {
            try
            {
                if (obj != null)
                {
                    DateTimeMethods dtm = new DateTimeMethods();
                    DateTime objDate = Convert.ToDateTime(obj);

                    //return Tools.ChangeEnc(objDate.ToShortTimeString().Replace("AM", "").Replace("PM", "") + " - " + dtm.GetPersianDate(objDate));
                    if (_timeFormat == TimeFormats.PerfectTime)
                        return Tools.ChangeEnc(objDate.ToString("H:mm:ss") + " - " + dtm.GetPersianDate(objDate));
                    else
                    {
                        return Tools.GetPrettyPersianDate2(objDate);
                    }
                }
                else
                    return "";

            }
            catch
            {
                return "";
            }
        }

        public string ShowItemLeftClass()
        {
            return "";
        }

        public bool IsNotArchive()
        {
            return true;
        }

        public string FormatDate(Object obj)
        {
            string Result = "";
            try
            {
                if (obj != null)
                {
                    DateTime CurDT = Convert.ToDateTime(obj);
                    DateTimeMethods dtm = new DateTimeMethods();
                    Result = Tools.ChageEnc(dtm.GetPersianDate(CurDT));
                    if (ShowTime)
                    {
                        string strCurrentMin = CurDT.Minute.ToString();
                        if (strCurrentMin.Length == 1)
                            strCurrentMin = "0" + strCurrentMin;
                        Result += " ساعت: " + Tools.ChageEnc(CurDT.Hour + ":" + strCurrentMin);
                    }
                }
                return Result;

            }
            catch
            {
                return "";
            }

        }

        public string FormatDateTime(Object obj)
        {
            string Result = "";
            try
            {
                if (obj != null)
                {
                    DateTime CurDT = Convert.ToDateTime(obj);
                    DateTimeMethods dtm = new DateTimeMethods();
                    Result = Tools.ChageEnc(dtm.GetPersianDate(CurDT));

                    string strCurrentMin = CurDT.Minute.ToString();
                    if (strCurrentMin.Length == 1)
                        strCurrentMin = "0" + strCurrentMin;
                    Result += " ساعت: " + Tools.ChageEnc(CurDT.Hour + ":" + strCurrentMin);


                }
                return Result;

            }
            catch
            {
                return "";
            }

        }

        public string ShowPic(object Title, object PicName)
        {
            string Result = "";
            if (PicName != null && PicName != "")
                //Result = "<img class=\"cPicSmall\" alt=\"" + Title + "\" src=\"" + PicName + "\" />";
                Result = "<img class=\"cPicSmall\" alt=\"" + Title + "\" src=\"" + PicName + "\" />";
            return Result;
        }

        public void SearchNews(string Keyword)
        {
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
            }
            catch
            {
            }
            if (PageNo == 0)
                PageNo = 1;



            int ResultCount = 0;
            BOLNews NewsBOL = new BOLNews();
            rptNewsList.DataSource = NewsBOL.SearchNews(_pageSize, PageNo, Keyword, out ResultCount);
            rptNewsList.DataBind();

            if (ResultCount > 0)
            {

                int PageCount = (int)ResultCount / _pageSize;
                if (ResultCount % _pageSize > 0)
                    PageCount++;

                ConcatUrl += "&Keyword=" + Keyword;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            else
            {
                msgInfo.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Info;
                msgInfo.Text = "هیچ نتیجه ای پیدا نشد";
            }
        }

        public int[] ShowLatestNews(int? HCNewsCatCode, int PageSize, int[] ExcludeCodeArray, int? HCContentTypeCode, int? paramPageNo, bool ShowPager, string strDate, int HCNewsTypeCode)
        {
            if (!_showHeader)
                pnlHeader.Visible = false;
            //if(ExcludeCodeArray.Length > 0)
            //    ShowTime = true;
            _pageSize = PageSize;
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
            }
            catch
            {
            }
            if (PageNo == 0)
                PageNo = 1;

            if (paramPageNo != null)
                PageNo = (int)paramPageNo;

            BOLNews NewsBOL = new BOLNews();
            IQueryable<vLatestNews> ItemList = NewsBOL.GetLatestNewsList(HCNewsCatCode, ExcludeCodeArray, _pageSize, PageNo, HCContentTypeCode, strDate, HCNewsTypeCode);
            rptNewsList.DataSource = ItemList;
            rptNewsList.DataBind();

            int[] NewCodeArray = new int[50];
            if (ExcludeCodeArray != null)
            {
                if(ExcludeCodeArray.Length > 0)
                    NewCodeArray[0] = ExcludeCodeArray[0];
            }

            int Counter = 1;
            foreach (var item in ItemList)
            {
                NewCodeArray[Counter] = item.Code;
                Counter++;
            }

            string MainHeader = "";
            if (HCNewsTypeCode != 0)
            {
                switch (HCNewsTypeCode)
                {
                    case 1:
                        ltrHeader.Text = "آخرین اخبار";
                        break;
                    case 2:
                        ltrHeader.Text = "یادداشت";
                        break;
                    case 3:
                        ltrHeader.Text = "گزارش";
                        break;
                    case 4:
                        ltrHeader.Text = "گفتگو";
                        break;

                    default:
                        break;
                }
            }

            if (HCNewsCatCode != null)
            {
                BOLHardCode HardCodeBOL = new BOLHardCode();
                HardCodeBOL.TableOrViewName = "HCNewsCats";
                ltrHeader.Text = HardCodeBOL.GetNameByCode((int)HCNewsCatCode);
                switch (HCNewsCatCode)
                {
                    case 0:
                        CaptionClass = "Latest";
                        break;
                    case 1:
                        CaptionClass = "Politics";
                        break;
                    case 2:
                        CaptionClass = "Socity";
                        break;
                    case 3:
                        CaptionClass = "Sport";
                        break;
                    case 4:
                        CaptionClass = "Event";
                        break;
                    case 5:
                        CaptionClass = "Tech";
                        break;
                    case 6:
                        CaptionClass = "Culture";
                        break;
                    case 7:
                        CaptionClass = "Reading";
                        break;
                    default:
                        CaptionClass = "Latest";
                        break;
                }
            }
            if (!string.IsNullOrEmpty(strDate))
            {
                ltrHeader.Text = "اخبار تاریخ " + Tools.ChageEnc( strDate);
                ConcatUrl += "&d=" + Request["d"];
            }


            if (ShowPager)
            {
                string CatCode = Request["CatCode"];
                if (!string.IsNullOrEmpty(CatCode))
                    ConcatUrl += "&CatCode=" + CatCode;

                int ResultCount = NewsBOL.GetLatestNewsListCount(HCNewsCatCode, ExcludeCodeArray, _pageSize, PageNo, HCContentTypeCode, strDate, HCNewsTypeCode);
                int PageCount = ResultCount / _pageSize;
                if (ResultCount % _pageSize > 0)
                    PageCount++;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            else
                pgrToolbar.Visible = false;

            return NewCodeArray;
        }
        
        public void ShowNewsByContentTypeCode(int CatCode)
        {
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
            }
            catch
            {
            }
            if (PageNo == 0)
                PageNo = 1;

            BOLNews NewsBOL = new BOLNews();
            IQueryable<vNews> ItemList = NewsBOL.GetNewsByContentTypeCode(CatCode, _pageSize, PageNo, 1);
            int ResultCount = NewsBOL.GetNewsByContentTypeCodeCount(CatCode, 1);
            rptNewsList.DataSource = ItemList;
            rptNewsList.DataBind();

            ConcatUrl = "&Code=" + CatCode;
            int PageCount = ResultCount / _pageSize;
            if (ResultCount % _pageSize > 0)
                PageCount++;
            pgrToolbar.PageNo = PageNo;
            pgrToolbar.PageCount = PageCount;
            pgrToolbar.ConcatUrl = ConcatUrl;
            pgrToolbar.PageBind();
        }

        public void ShowNewsByNewsTypeCode(int HCNewsCatCode, int HCNewsTypeCode)
        {
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
            }
            catch
            {
            }
            if (PageNo == 0)
                PageNo = 1;

            BOLNews NewsBOL = new BOLNews();
            IQueryable<vNews> ItemList = NewsBOL.GetNewsByCatCode(HCNewsCatCode, PageSize, PageNo, null, HCNewsTypeCode);
            int ResultCount = NewsBOL.GetNewsByCatCodeCount(HCNewsCatCode, HCNewsTypeCode);
            rptNewsList.DataSource = ItemList;
            rptNewsList.DataBind();

            ConcatUrl = "&Code=" + HCNewsCatCode + "&NT=" + HCNewsCatCode;
            int PageCount = ResultCount / _pageSize;
            if (ResultCount % _pageSize > 0)
                PageCount++;
            pgrToolbar.PageNo = PageNo;
            pgrToolbar.PageCount = PageCount;
            pgrToolbar.ConcatUrl = ConcatUrl;
            pgrToolbar.PageBind();
        }

        public string ShowContentType(object objContentType)
        {

            return objContentType.ToString().Replace(" ", "");
        }

        public string ShowAbstract(object objCode, object objAbstract, int MaxLen)
        {
            try
            {
                if (objAbstract == null)
                    return "";
                string strAbstract = objAbstract.ToString();
                if (MaxLen > strAbstract.Length)
                    return strAbstract;

                string CutAbstract = Tools.ShowBriefText(strAbstract, MaxLen);
                if (_keyword != null)
                {
                    CutAbstract = CutAbstract.Replace(_keyword, "<span style=\"font-weight:bold;background-color:Yellow\">" + _keyword + "</span>");
                }
                else
                {
                    if (CutAbstract.Length > 300)
                    {
                        int Code = Convert.ToInt32(objCode);
                        int CutIndex = CutAbstract.IndexOf(" ", 400);
                        if (CutIndex != -1)
                        {
                            CutAbstract = CutAbstract.Substring(0, CutIndex) + "<div onclick=\"ShowMore('More" + Code + "')\" class=\"SeeMore\">ادامه...</div><div id=\"More" + Code + "\" class=\"Hidden\">" + CutAbstract.Substring(CutIndex, CutAbstract.Length - CutIndex) + "</div>";
                        }
                    }
                }
                return CutAbstract;
            }
            catch
            {
                return objAbstract.ToString();
            }
        }

        internal void LoadMainCats(int MCat)
        {
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
            }
            catch
            {
            }
            if (PageNo == 0)
                PageNo = 1;

            BOLNews NewsBOL = new BOLNews();
            int SkipCount = (PageNo - 1) * PageSize;
            var ItemList = NewsBOL.GetMainCatItems(new int[] { }, PageSize, PageNo, MCat).Select(t => new { t.Code, t.Title, t.Priority, t.SoTitr, t.NewsDate, t.Abstract, t.PicFile1 }).Distinct().OrderByDescending(p => p.Priority).Skip(SkipCount).Take(PageSize); ;
            int ResultCount = NewsBOL.GetMainCatItemsCount(MCat);
            rptNewsList.DataSource = ItemList;
            rptNewsList.DataBind();

            ConcatUrl = "&MCat=" + MCat;
            int PageCount = ResultCount / _pageSize;
            if (ResultCount % _pageSize > 0)
                PageCount++;
            pgrToolbar.PageNo = PageNo;
            pgrToolbar.PageCount = PageCount;
            pgrToolbar.ConcatUrl = ConcatUrl;
            pgrToolbar.PageBind();
        }

    }

    public enum TimeFormats
    {
        TimeAgo,
        PerfectTime
    }

}