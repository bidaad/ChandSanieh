using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;

namespace AceNews.Admin.News
{
    public partial class NewsPriorities : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            msgBox.Text = "";
            if (!Page.IsPostBack)
            {
                BOLNews NewsBOL = new BOLNews();
                rptLatestNews.DataSource = NewsBOL.GetLatestNewsList(null, new int[]{}, 20, 1, null, null, null);
                rptLatestNews.DataBind();
            }
        }
        protected void HandleRepeaterCommand(object source, RepeaterCommandEventArgs e)
        {

            if (e.CommandName == "SelectNews")
            {
                btnRemoveFromSelected.Visible = true;
                LinkButton btnNews = (LinkButton)e.Item.FindControl("btnNews");
                Panel pnlTitle = (Panel)e.Item.FindControl("pnlTitle");
                int NewsCode = Convert.ToInt32(btnNews.Attributes["NewsCode"]);

                int SelectedIndex = 0;
                for (int i = 0; i < rptLatestNews.Items.Count; i++)
                {
                    Panel CurPanel = (Panel)rptLatestNews.Items[i].FindControl("pnlTitle");
                    LinkButton btnCurNews = (LinkButton)rptLatestNews.Items[i].FindControl("btnNews");
                    int CurNewsCode = Convert.ToInt32(btnCurNews.Attributes["NewsCode"]);
                    CurPanel.CssClass = "UnSelected";
                    if (CurNewsCode == NewsCode)
                    {
                        SelectedIndex = i;
                    }
                }

                ShowHideButtons(SelectedIndex, rptLatestNews.Items.Count);
                pnlTitle.CssClass = "SelectedPanel";
                ViewState["SelectedCode"] = NewsCode.ToString();
            }
            if (e.CommandName == "SelectForDrop")
            {
                LinkButton btnNews = (LinkButton)e.Item.FindControl("btnNews");
                Panel pnlTitle = (Panel)e.Item.FindControl("pnlTitle");
                int NewsCode = Convert.ToInt32(btnNews.Attributes["NewsCode"]);

                int SelectedIndex = 0;
                for (int i = 0; i < rptSelectedNews.Items.Count; i++)
                {
                    Panel CurPanel = (Panel)rptSelectedNews.Items[i].FindControl("pnlTitle");
                    LinkButton btnCurNews = (LinkButton)rptSelectedNews.Items[i].FindControl("btnNews");
                    int CurNewsCode = Convert.ToInt32(btnCurNews.Attributes["NewsCode"]);
                    CurPanel.CssClass = "UnSelectedDrag";
                    if (CurNewsCode == NewsCode)
                    {
                        SelectedIndex = i;
                        ViewState["SelectedDragIndex"] = i;
                    }
                }
                btnMoveToSelected.Visible = true;

                pnlTitle.CssClass = "SelectedDragPanel";
                ViewState["SelectedDragCode"] = NewsCode.ToString();
            }
                

        }

        private void ShowHideButtons(int SelectedIndex,int ItemCount)
        {
            if (SelectedIndex == ItemCount - 1)
                btnDown.Visible = false;
            else
                btnDown.Visible = true;

            if (SelectedIndex == 0)
                btnUp.Visible = false;
            else
                btnUp.Visible = true;
        }

        protected void btnUp_Click(object sender, EventArgs e)
        {

            ManageUpDown(VerDirections.Up);
            
        }
        
        protected void btnDown_Click(object sender, EventArgs e)
        {
            ManageUpDown(VerDirections.Down);

            
        }

        private void ManageUpDown(VerDirections MoveDirection)
        {
            try
            {
                if (ViewState["SelectedCode"] == null)
                {
                    msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                    msgBox.Text = "لطفا یک خبر را انتخاب کنید";
                    return;
                }
                int NewsCode = Convert.ToInt32(ViewState["SelectedCode"]);
                int? NewsToBeReplaceCode = null;
                bool Flag = false;
                int SelectedIndex;


                if (MoveDirection == VerDirections.Down)
                {
                    SelectedIndex = 0;
                    for (int i = 0; i < rptLatestNews.Items.Count; i++)
                    {
                        Panel CurPanel = (Panel)rptLatestNews.Items[i].FindControl("pnlTitle");
                        LinkButton btnNews = (LinkButton)rptLatestNews.Items[i].FindControl("btnNews");
                        int CurNewsCode = Convert.ToInt32(btnNews.Attributes["NewsCode"]);
                        if (Flag)
                        {
                            NewsToBeReplaceCode = CurNewsCode;
                            break;
                        }
                        if (CurNewsCode == NewsCode)
                            Flag = true;
                    }
                }
                else
                {
                    SelectedIndex = rptLatestNews.Items.Count - 1;
                    for (int i = rptLatestNews.Items.Count - 1; i >= 0; i--)
                    {
                        Panel CurPanel = (Panel)rptLatestNews.Items[i].FindControl("pnlTitle");
                        LinkButton btnNews = (LinkButton)rptLatestNews.Items[i].FindControl("btnNews");
                        int CurNewsCode = Convert.ToInt32(btnNews.Attributes["NewsCode"]);
                        if (Flag)
                        {
                            NewsToBeReplaceCode = CurNewsCode;
                            break;
                        }
                        if (CurNewsCode == NewsCode)
                            Flag = true;
                    }
                }


                if (NewsToBeReplaceCode != null)
                {
                    BOLNews NewsBOL = new BOLNews();
                    bool Result = NewsBOL.ChangePririties(NewsCode, (int)NewsToBeReplaceCode);
                    if (Result)
                    {
                        if (ViewState["ItemFiltered"] != null)
                        {
                            FilterItems();
                        }
                        else
                        {
                            //int[] BulkArray = 
                            rptLatestNews.DataSource = NewsBOL.GetLatestNewsList(null, new int[] { }, 20, 1, null, null, null);
                            rptLatestNews.DataBind();
                        }
                        for (int i = 0; i < rptLatestNews.Items.Count; i++)
                        {
                            Panel CurPanel = (Panel)rptLatestNews.Items[i].FindControl("pnlTitle");
                            LinkButton btnCurNews = (LinkButton)rptLatestNews.Items[i].FindControl("btnNews");
                            int CurNewsCode = Convert.ToInt32(btnCurNews.Attributes["NewsCode"]);
                            CurPanel.CssClass = "UnSelected";
                            if (CurNewsCode == NewsCode)
                            {
                                CurPanel.CssClass = "SelectedPanel";
                                SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }
                ShowHideButtons(SelectedIndex, rptLatestNews.Items.Count);
            }
            catch(Exception err)
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = "بروز خطا : " + err.Message;
            }
        }
        protected void btnRemoveFromSelected_Click(object sender, EventArgs e)
        {
            if (ViewState["SelectedCode"] != null)
            {
                int NewsToRemoveCode = Convert.ToInt32(ViewState["SelectedCode"]);
                BOLNews NewsBOL = new BOLNews();
                int NewPririty = 0;
                NewsBOL.SetNewPriority(NewsToRemoveCode, NewPririty);
                rptLatestNews.DataSource = NewsBOL.GetLatestNewsList(null, new int[] { }, 20, 1, null, null, null);
                rptLatestNews.DataBind();
            }
        }

        protected void btnMoveToSelected_Click(object sender, EventArgs e)
        {
            if (ViewState["SelectedDragCode"] != null)
            {
                int NewstoDragCode = Convert.ToInt32(ViewState["SelectedDragCode"]);
                BOLNews NewsBOL = new BOLNews();
                int NewPririty = NewsBOL.GetLatestPriority(0) + 100;
                NewsBOL.SetNewPriority(NewstoDragCode, NewPririty);
                int SelectedDragIndex = Convert.ToInt32(ViewState["SelectedDragIndex"]);
                rptLatestNews.DataSource = NewsBOL.GetLatestNewsList(null,  new int[] { }, 20, 1, null, null, null);
                rptLatestNews.DataBind();
                //rptSelectedNews.Items
            }
            else
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = "بروز خطا";
            }

        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime? FromDate = dteFromDate.SelectedDateChristian;
            DateTime? ToDate = dteToDate.SelectedDateChristian;
            string strFromNewsNo = txtFromNewsno.Text;
            string strToNewsNo = txtToNewsNo.Text;
            string Keyword = txtKeyword.Text;

            int SearchType = 0;
            for (int i = 0; i < chkListSearchType.Items.Count; i++)
            {
                if (chkListSearchType.Items[i].Selected)
                    SearchType += Convert.ToInt32(chkListSearchType.Items[0].Value);
            }
            BOLNews NewsBOL = new BOLNews();
            IQueryable<vNews> SearchResults = NewsBOL.Search(FromDate, ToDate, strFromNewsNo, strToNewsNo, Keyword, SearchType, null);
            rptSelectedNews.DataSource = SearchResults.Take(10);
            rptSelectedNews.DataBind();

            if (rptSelectedNews.Items.Count > 0)
            {
                pnlSelectedNews.Visible = true;
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.OK;
                msgBox.Text = SearchResults.Count() + " خبر پیدا شد.";
                if (SearchResults.Count() > 10)
                    msgBox.Text += "10 خبر آخر نمایش داده میشوند.";
            }
            else
            {
                pnlSelectedNews.Visible = false;
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Warning;
                msgBox.Text = "هیج خبری با این مشخصات وجود ندارد.";
            }
        }

        private void FilterItems()
        {
            DateTime? FromDate = dteFromDate.SelectedDateChristian;
            DateTime? ToDate = dteFromDate.SelectedDateChristian;
            string strFromNewsNo = txtFromNewsno.Text;
            string strToNewsNo = txtToNewsNo.Text;
            string Keyword = txtKeyword.Text;

            int SearchType = 0;
            for (int i = 0; i < chkListSearchType.Items.Count; i++)
            {
                if (chkListSearchType.Items[i].Selected)
                    SearchType += Convert.ToInt32(chkListSearchType.Items[0].Value);
            }
            BOLNews NewsBOL = new BOLNews();
            rptLatestNews.DataSource = NewsBOL.Search(FromDate, ToDate, strFromNewsNo, strToNewsNo, Keyword, SearchType, null);
            rptLatestNews.DataBind();
            ViewState["ItemFiltered"] = true;
        }
    }

    public enum VerDirections
    {
        Up,
        Down
    }
}