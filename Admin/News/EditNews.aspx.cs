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
using System.Globalization;
using System.IO;
using Telerik.Web.UI;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

public partial class News_EditNews : EditForm<News>
{
    private string BaseID = "News";
    IBaseBOL<News> BaseBOL;

    protected void Page_Load(object sender, EventArgs e)
    {
        #region Tab Pages
        if (!NewMode)
        {
            if(!Page.IsPostBack)
                ShowDetails();
        }
        else
        {
            //RadMultiPage1.SelectedIndex = 0;
            //tsNews.Tabs[0].Selected = true;
        }
        #endregion
        BOLClass = new BOLNews();
        lblSysName.Text = BOLClass.PageLable;

        if ((Code == null) && (!NewMode)) return;
        if (!Page.IsPostBack)
        {

            if (!NewMode) 
                ShowDetails();
            else
                cboPriorityTypeCode.SelectedIndex = 1;


            #region Fill Combo
            //cboHCNewsCatCode.DataSource = new BOLHardCode().GetHCDataTable("HCNewsTypes");
            //cboHCContentTypeCode.DataSource = new BOLHardCode().GetHCDataTable("HCContentTypes");
            cboHCNewsCatCode.DataSource = new BOLHardCode().GetHCDataTable("HCNewsCats");
            cboHCNewsTypeCode.DataSource = new BOLHardCode().GetHCDataTable("HCNewsTypes");
            
            
            #endregion

            PersianCalendar pc = new PersianCalendar();
            DateTime thisTime = DateTime.Now;
            string UplPath = "~/Files/News/" + pc.GetYear(thisTime) + "-" + pc.GetMonth(thisTime) + "-" + pc.GetDayOfMonth(thisTime);
            if (!Directory.Exists(HttpContext.Current.Request.MapPath(UplPath)))
                Directory.CreateDirectory(HttpContext.Current.Request.MapPath(UplPath));
            uplPicFile2.TargetFolder = UplPath;

            if (!NewMode)
            {
                LoadData((int)Code);
                BOLNews NewsBOL = new BOLNews();
                News CurNews = ((IBaseBOL<News>)NewsBOL).GetDetails((int)Code);
                dteNewsDate.SelectedDateChristian = CurNews.NewsDate;
                //txtNewsBody.Text = CurNews.NewsBody;

            }
            else
            {
                chkShowInTelex.Checked = true;
                dteNewsDate.SelectedDateChristian = DateTime.Now;
            }
        }


    }





    protected void DoSave(object sender, ImageClickEventArgs e)
    {
        try
        {
            #region Validate Controls
            bool NewsTypeSelected = true;
            //for (int i = 0; i < treWorkGroups.Items.Count; i++)
            //{
            //    CheckBox CurCheckbox = (CheckBox)dlNewsTypes.Items[i].FindControl("chkNewsType");
            //    if (CurCheckbox.Checked)
            //    {
            //        NewsTypeSelected = true;
            //        break;
            //    }

            //}
            if (!NewsTypeSelected)
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = "لطفا حداقل یک گروه انتخاب کنید.";
                return;
            }

            if (NewMode && uplPicFile2.UploadedFiles.Count == 0)
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = "لطفا عکس خبر را انتخاب کنید.";
                return;
            }
            #endregion

            int ReturnCode = SaveControls("~/Main/Default.aspx?BaseID=" + BaseID);
            Code = ReturnCode;

            BOLNews NewsBOL = new BOLNews();
            if (ReturnCode != -1)
            {
                DateTime dtNewsDate;
                News CurNews = ((IBaseBOL<News>)NewsBOL).GetDetails(ReturnCode);
                #region Save News Date
                if (NewMode)
                {
                    dtNewsDate = (DateTime)dteNewsDate.SelectedDateChristian;
                    dtNewsDate = new DateTime(dtNewsDate.Year, dtNewsDate.Month, dtNewsDate.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                }
                else
                {
                    dtNewsDate = (DateTime)dteNewsDate.SelectedDateChristian;
                    dtNewsDate = new DateTime(dtNewsDate.Year, dtNewsDate.Month, dtNewsDate.Day, CurNews.NewsDate.Hour, CurNews.NewsDate.Minute, CurNews.NewsDate.Second);
                }
                NewsBOL.SaveNewsDate(ReturnCode, dtNewsDate);
                #endregion

                if (uplPicFile2.UploadedFiles.Count > 0 || string.IsNullOrEmpty(CurNews.PicFile1))
                {
                    Guid newGd = Guid.NewGuid();
                    string RandSmallPic = newGd.ToString().Replace("-", "") + ".jpg";

                    PersianCalendar pc = new PersianCalendar();
                    DateTime thisTime = DateTime.Now;
                    string UplPath = "~/Files/News/" + pc.GetYear(thisTime) + "-" + pc.GetMonth(thisTime) + "-" + pc.GetDayOfMonth(thisTime);
                    if (!Directory.Exists(HttpContext.Current.Request.MapPath(UplPath)))
                        Directory.CreateDirectory(HttpContext.Current.Request.MapPath(UplPath));


                    SavePic(CurNews.PicFile2, RandSmallPic, HttpContext.Current.Request.MapPath(UplPath), 100);
                    NewsBOL.ChangeSmallPic(ReturnCode, UplPath + "/" + RandSmallPic);
                }

                #region Save Keywords
                    string Keywords = txtKeywords.Text;
                    Keywords = Keywords.Trim();
                    while (Keywords.IndexOf("  ") != -1)
                    {
                        Keywords = Keywords.Replace("  ", " ");
                    }
                    while (Keywords.IndexOf("\n\n") != -1)
                    {
                        Keywords = Keywords.Replace("\n\n", "\n");
                    }
                    string[] KeywordsArray = Keywords.Split('\n');
                    BOLNewsKeywords NewsKeywordsBOL = new BOLNewsKeywords(1);
                    NewsKeywordsBOL.DeleteAllKeywords((int)Code);
                    for (int i = 0; i < KeywordsArray.Length; i++)
                    {
                        if(KeywordsArray[i].Trim() != "")
                            NewsKeywordsBOL.Insert((int)Code, KeywordsArray[i]);
                    }
                #endregion

                ShowDetails();

            }
            if (cboPriorityTypeCode.SelectedIndex != 0 && ReturnCode != -1)
            {
                News CurNews = ((IBaseBOL<News>)NewsBOL).GetDetails(ReturnCode);

                if (NewMode)
                {
                    int PriorityTypeCode = Convert.ToInt32(cboPriorityTypeCode.SelectedValue);
                    int NewPririty = 0;
                    NewPririty = NewsBOL.GetLatestPriority(PriorityTypeCode - 1) + 100;
                    if (PriorityTypeCode > 1)
                        NewsBOL.MoveTopNews(NewPririty);

                    NewsBOL.SetNewPriority(ReturnCode, NewPririty);
                }
                else
                {
                    int NewsToBeReplaceCode = NewsBOL.GetPriorityByOrder(cboPriorityTypeCode.SelectedIndex - 1);
                    if(NewsToBeReplaceCode != ReturnCode)
                        NewsBOL.ChangePririties(ReturnCode, NewsToBeReplaceCode);

                }

                txtNewsNumber.Text = CurNews.NewsNumber;
                NewMode = false;
                Code = ReturnCode;
                ShowDetails();
            }



        }
        catch
        {
        }
    }

    public void SavePic(string FileName, string RandName, string SavePath, int MaxAllowWidth)
    {
        string FirstChar = RandName.Substring(0, 1);
        int StaticVal = MaxAllowWidth;
        int NewWidth;
        int NewHeight;
        Graphics oGraphics;

        System.Drawing.Image image = new Bitmap(HttpContext.Current.Request.MapPath("~/") + FileName);
        if (image.Width > MaxAllowWidth)
        {
            int width = image.Width;
            int height = image.Height;
            //if (width > height)
            //{
            NewWidth = StaticVal;
            NewHeight = (StaticVal * height) / width;
            //}
            //else
            //{
            //    NewHeight = StaticVal;
            //    NewWidth = (StaticVal * width) / height;
            //}

            System.Drawing.Image BulkBmp = new Bitmap(NewWidth, NewHeight);
            oGraphics = Graphics.FromImage(BulkBmp);

            oGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            oGraphics.DrawImage(
                image,
                new Rectangle(0, 0, NewWidth, NewHeight),
                // destination rectangle 
                0,
                0,           // upper-left corner of source rectangle
                width,       // width of source rectangle
                height,      // height of source rectangle
                GraphicsUnit.Pixel);

            BulkBmp.Save(SavePath + "\\" + RandName, ImageFormat.Jpeg);
            oGraphics.Dispose();
        }
        else
            File.Copy(HttpContext.Current.Request.MapPath("~/Files/News/") + FileName, HttpContext.Current.Request.MapPath("~/Files/News/") + RandName);

    }

    private void ShowDetails()
    {
        //string Tab1Click = "BrowseObj2.ShowDetail('NewsComments', '" + Code + "', true,'BrowseObj2');";
                           


        //Tab1.Attributes.Add("onclick", Tab1Click);
        //Tools.SetClientScript(this, "ActiveTab1", Tab1Click);

        //#region HanldeSelectedTab
        //if (Request["SelectedTab"] != null)
        //{
        //    RadMultiPage1.SelectedIndex = Int32.Parse(Request["SelectedTab"]);
        //    SelectedTabIndex = Int32.Parse(Request["SelectedTab"]);
        //    switch (Int32.Parse(Request["SelectedTab"]))
        //    {
        //        case 0:
        //            Tools.SetClientScript(Page, "ClickTab", Tab1Click);
        //            RadMultiPage1.SelectedIndex = 0;
        //            tsNews.SelectedIndex = 0;
        //            break;
        //        default:
        //            break;
        //    }
        //    tsNews.Tabs[Int32.Parse(Request["SelectedTab"])].Selected = true;
        //}
        //else
        //{
        //    RadMultiPage1.SelectedIndex = 0;
        //    tsNews.Tabs[0].Selected = true;
        //}
        //#endregion
    }
}
