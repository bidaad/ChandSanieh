using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews.UserControls
{
    public partial class UCComments : System.Web.UI.UserControl
    {
        protected int _hcSectionCode;
        public int HCSectionCode
        {
            get
            {
                return _hcSectionCode;

            }
            set
            {
                _hcSectionCode = value;
                ViewState["HCSectionCode"] = value;
            }

        }

        protected int _itemCode;
        public int ItemCode
        {
            get
            {
                return _itemCode;

            }
            set
            {
                _itemCode = value;
                ViewState["ItemCode"] = value;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtComment.Attributes.Add("onblur", "this.className='CommentText';if(this.value == '') this.value = '" + "پیام" + "';");
                txtName.Attributes.Add("onblur", "this.className='CommentText';if(this.value == '') this.value = '" + "نام" + "';");
                txtEmail.Attributes.Add("onblur", "this.className='CommentText';if(this.value == '') this.value = '" + "نام خانوادگی" + "';");
            }

            BOLComments CommentsBOL = new BOLComments();
            rptComments.DataSource = CommentsBOL.GetCommentsByStatusCode(_itemCode, 2);
            rptComments.DataBind();

            if (rptComments.Items.Count == 0)
            {
                rptComments.Visible = false;
                PublishInfo.Visible = false;
            }

            int PublishedCount = CommentsBOL.GetCommentByStatusCodeCount(_itemCode, 2);
            int WillNotBePublishedCount = CommentsBOL.GetCommentByStatusCodeCount(_itemCode, 3);

            lblPublishedCount.Text ="منتشر شده"+ ": " + Tools.ChangeEnc(PublishedCount.ToString());
            lblWillNotBePublishedCount.Text = "منتشر نشده" + ": " + Tools.ChangeEnc(WillNotBePublishedCount.ToString());

        }

        public string PersianDate(Object obj)
        {
            try
            {
                if (obj != null)
                {
                    DateTimeMethods dtm = new DateTimeMethods();
                    DateTime objDate = Convert.ToDateTime(obj);

                    return Tools.ChangeEnc(objDate.ToShortTimeString().Replace("AM", "").Replace("PM", "") + " - " + dtm.GetPersianDate(objDate));
                }
                else
                    return "";

            }
            catch
            {
                return "";
            }
        }
        protected void btnSendComment_Click(object sender, EventArgs e)
        {

            if (!RadCaptcha1.IsValid)
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = "کد امنیتی اشتباه است";
                return;
            }

            msgBox.Text = "";
            string Name = txtName.Text.Trim();
            string Email = txtEmail.Text.Trim();
            string Comment = txtComment.Text.Trim();
            if (Comment == "")
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text =  "لطفا پیام را وارد کنید";
                return;
            }

            if (ViewState["ItemCode"] != null && ViewState["HCSectionCode"] != null)
            {
                int HCSectionCode = Convert.ToInt32(ViewState["HCSectionCode"]);
                int ItemCode = Convert.ToInt32(ViewState["ItemCode"]);
                BOLComments CommentsBOL = new BOLComments();
                bool Result = CommentsBOL.SaveComment(HCSectionCode, ItemCode, Name, Email, Comment);
                if (Result)
                {
                    msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.OK;
                    msgBox.Text ="نظر شما با موفقیت دریافت شد";
                    btnSendComment.Visible = false;
                }
                else
                {
                    msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                    msgBox.Text ="متاسفانه خطایی در ثبت نظر رخ داده است";
                }


            }
        }
    }
}