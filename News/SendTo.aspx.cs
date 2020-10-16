using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;

namespace AceNews.NewsFolder
{
    public partial class SendTo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strCode = Request["Code"];
            int Code;
            Int32.TryParse(strCode, out Code);
            if (Code == 0)
                return;
            ViewState["Code"] = Code;
            BOLNews NewsBOL = new BOLNews();
            AceNews.Old_Code.DAL.News CurNews = ((IBaseBOL<AceNews.Old_Code.DAL.News>)NewsBOL).GetDetails(Code);
            if (CurNews != null)
                lblTitle.Text = CurNews.Title;

        
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                msgBox.Text = "";
                if (ViewState["Code"] == null)
                    return;

                msgBox.Text = "";

                string YourName = txtYourName.Text;
                //string YourEmail = txtYourEmail.Text;
                string ToName = txtToName.Text;
                string ToEmail = txtToEmail.Text;

                if (ToEmail == "")
                {
                    msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                    msgBox.Text = "ایمیل گیرنده نباید خالی باشد.";
                    return;
                }
                int Code = Convert.ToInt32(ViewState["Code"]);

                BOLNews NewsBOL = new BOLNews();
                AceNews.Old_Code.DAL.News CurNews = ((IBaseBOL<AceNews.Old_Code.DAL.News>)NewsBOL).GetDetails(Code);

                Tools tools = new Tools();
                string MailBody = "";
                MailBody += YourName + " :نام فرستنده" + "<br />";
                MailBody += ToName + " :برای" + "<br />";
                MailBody += CurNews.Title + "<br />" + CurNews.NewsBody + "<br />";

                bool SendResult = tools.SendEmail(MailBody, "نظر سنجی  ", ToEmail, "", "", "");
                if (SendResult)
                {
                    btnSend.Visible = false;
                    msgBox.Text = "خبر با موفقیت ارسال شد.";
                    pnlSendNewsForm.Visible = false;
                }
            }
            catch
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = "متاسفانه در ارسال ایمیل خطایی رخ داده است.";
                
            }

        }
    }
}