using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;

namespace AceNews
{
    public partial class ImageGalleryArchive : System.Web.UI.Page
    {
        public string strPageNo;
        int PageNo = 1;
        int PageSize = 20;
        string ConcatUrl;

        protected void Page_Load(object sender, EventArgs e)
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

            IQueryable<News> ItemList = NewsBOL.GetImageGallery(PageSize, PageNo);
            int ResultCount = NewsBOL.GetImageGalleryCount();
            rptImageGallery.DataSource = ItemList;
            rptImageGallery.DataBind();

            ConcatUrl = "";
            int PageCount = ResultCount / PageSize;
            if (ResultCount % PageSize > 0)
                PageCount++;
            pgrToolbar.PageNo = PageNo;
            pgrToolbar.PageCount = PageCount;
            pgrToolbar.ConcatUrl = ConcatUrl;
            pgrToolbar.PageBind();

        }
    }
}