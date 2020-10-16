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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;


public partial class MultiMedias_EditMultiMedias : EditForm<MultiMedias>
{
    private string BaseID = "MultiMedias";
    IBaseBOL<MultiMedias> BaseBOL;

    protected void Page_Load(object sender, EventArgs e)
    {
        #region Tab Pages
        if (!NewMode)
            ShowDetails();
        else
        {
            RadMultiPage1.SelectedIndex = 0;
            tsMultiMedias.Tabs[0].Selected = true;
        }
        #endregion
        BOLClass = new BOLMultiMedias();
        lblSysName.Text = BOLClass.PageLable;

        if ((Code == null) && (!NewMode)) return;
        if (!Page.IsPostBack)
        {



            #region Fill Combo
            cboHCPicTypeCode.DataSource = new BOLHardCode().GetHCDataTable("HCPicTypes");

            #endregion
            if (!NewMode)
            {
                LoadData((int)Code);
                BOLMultiMedias MultiMediasBOL = new BOLMultiMedias();
                MultiMedias CurRecord = ((IBaseBOL<MultiMedias>)MultiMediasBOL).GetDetails((int)Code);
                DateTimeMethods dtm = new DateTimeMethods();
                lblCreateDateVal.Text = dtm.GetPersianDate((DateTime)CurRecord.CreateDate);
            }

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

            NewWidth = StaticVal;
            NewHeight = (StaticVal * height) / width;


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
            File.Copy(HttpContext.Current.Request.MapPath("~/") + FileName, HttpContext.Current.Request.MapPath("~/Files/MultiMedias/") + RandName);

    }

    private void ShowDetails()
    {
        string Tab1Click = "BrowseObj1.ShowDetail('MultiMediaPictures', '" + Code + "', true,'BrowseObj1');";

        Tab1.Attributes.Add("onclick", Tab1Click);
        Tools.SetClientScript(this, "ActiveTab1", Tab1Click);

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
                ShowDetails();
            }

            BOLMultiMedias MultiMediasBOL = new BOLMultiMedias();
            MultiMedias CurMultiMedia = MultiMediasBOL.GetDetails((int)Code);

            if (uplLargePicFile.UploadedFiles.Count > 0 || string.IsNullOrEmpty(CurMultiMedia.PicFile))
            {

                Guid newGd = Guid.NewGuid();
                string RandSmallPic = newGd.ToString().Replace("-", "") + ".jpg";

                DateTime thisTime = DateTime.Now;
                string UplPath = "~/Files/MultiMedias/";

                SavePic(CurMultiMedia.LargePicFile, RandSmallPic, HttpContext.Current.Request.MapPath(UplPath), 220);
                MultiMediasBOL.ChangeSmallPic(ReturnCode, UplPath + "/" + RandSmallPic);
            }
        }
        catch
        {
        }
    }

}
