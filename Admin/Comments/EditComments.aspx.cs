using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using AceNews.Old_Code.DAL;


public partial class Comments_EditComments : EditForm<Comments>
{
    private string BaseID = "Comments";
    IBaseBOL<Comments> BaseBOL;



    protected void Page_Load(object sender, EventArgs e)
    {
        #region Tab Pages
        //if (!NewMode)
        //     ShowDetails();
        //else
        //{
        //     RadMultiPage1.SelectedIndex = 0;
        //     tsComments.Tabs[0].Selected = true;
        //}
        #endregion
        BOLClass = new BOLComments();
        lblSysName.Text = BOLClass.PageLable;

        if ((Code == null) && (!NewMode)) return;
        if (!Page.IsPostBack)
        {
            //if (!NewMode) ShowDetails();


            #region Fill Combo
            cboHCCommentStatusCode.DataSource = new BOLHardCode().GetHCDataTable("HCCommentStatuses");
            cboHCSectionCode.DataSource = new BOLHardCode().GetHCDataTable("HCSections");
            cboHCLanguageCode.DataSource = new BOLHardCode().GetHCDataTable("HCLanguages");

            #endregion
            if (!NewMode)
            {
                LoadData((int)Code);
                BOLComments CommentsBOL = new BOLComments();
                Comments CurComment = CommentsBOL.GetData((int)Code);
                int HCSectionCode = CurComment.HCSectionCode;
                if (HCSectionCode == 1)//News
                {
                    BOLNews NewsBOL = new BOLNews();
                    News CurNews = NewsBOL.GetData((int)CurComment.ItemCode);
                    if (CurNews != null)
                    {
                        hplItem.Text = CurNews.Title;
                        hplItem.NavigateUrl = "~/Admin/News/EditNews.aspx?Code=" + CurComment.ItemCode;
                    }
                }
            }
        }


    }

    protected void DoSave(object sender, ImageClickEventArgs e)
    {
        try
        {
            int ReturnCode = SaveControls("~/Main/Default.aspx?BaseID=" + BaseID);
            if (NewMode && ReturnCode != -1)
            {
                NewMode = false;
                Code = ReturnCode;
            }
        }
        catch
        {
        }
    }
}
