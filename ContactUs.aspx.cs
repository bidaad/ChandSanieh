using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AceNews
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
  
            }

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {

            string Name = txtName.Text;
            string Email = txtEmail.Text;
            string Comment = txtComment.Text;

            if (!RadCaptcha1.IsValid)
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = "کد امنیتی صحیح نیست";
                return;
            }


            if (string.IsNullOrEmpty(Name))
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text =  "لطفا نام را وارد کنید";
                return;
            }
            if (string.IsNullOrEmpty(Email))
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = "لطفا نام خانوادگی را وارد کنید";
                return;
            }
            if (string.IsNullOrEmpty(Comment))
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = "لطفا پیغام را وارد کنید";
                return;
            }

            BOLCenterContacts CenterContactsBOL = new BOLCenterContacts();
            CenterContactsBOL.Insert(Name, Email, Comment);
            msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.OK;
            msgBox.Text = "اطلاعات با موفقیت دریافت شد";

        }
    }
}