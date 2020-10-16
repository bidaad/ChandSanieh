using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using AceNews.Old_Code.DAL;

namespace IONS.SiteUsers
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                #region Fill Combo
                cboHCGenderCode.DataSource = new BOLHardCode().GetHCDataTable("HCGenders");
                #endregion
            }
        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            msgMessage.Text = "";
            if (!RadCaptcha1.IsValid)
            {
                pnlMessage.Visible = true;
                msgMessage.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgMessage.Text = "کد امنیتی به درستی وارد نشده است.";
                return;
            }

            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Password = txtPassword.Text;
            int HCGenderCode = Convert.ToInt32(cboHCGenderCode.SelectedValue);
            string Gender = cboHCGenderCode.SelectedItem.Text;
            string Email = txtEmail.Text;
            string Tel = txtTel.Text;
            string CellPhone = txtCellPhone.Text;

            lblFirstName.Text = FirstName;
            lblLastName.Text = LastName;
            lblPassword.Text = Password;
            lblGender.Text = Gender;
            lblEmail.Text = Email;
            lblTel.Text = Tel;
            lblCellPhone.Text = CellPhone;
            if (rblAutoLogin.SelectedValue == "1")
                lblAutoLogin.Text = "بله";
            else
                lblAutoLogin.Text = "خیر";
            MVRegForm.SetActiveView(ViewFinal);


        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            MVRegForm.SetActiveView(ViewEdit);
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            pnlMessage.Visible = false;
            msgMessage.Text = "";

            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            int HCGenderCode = Convert.ToInt32(cboHCGenderCode.SelectedValue);
            string Email = txtEmail.Text;
            string Tel = txtTel.Text;
            string CellPhone = txtCellPhone.Text;

            if (Username.Length < 5)
            {
                pnlMessage.Visible = true;
                msgMessage.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgMessage.Text = "طول نام کاربری نباید کمتر از پنج کاراکتر باشد. ";
                return;
            }
            if (Password.Length < 5)
            {
                pnlMessage.Visible = true;
                msgMessage.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgMessage.Text = "طول کلمه عبور نباید کمتر از پنج کاراکتر باشد. ";
                return;
            }


            bool AutoLogin;

            if (rblAutoLogin.SelectedValue == "1")
                AutoLogin = true;
            else
                AutoLogin = false;
            bool Active = false;

            BOLUsers UsersBOL = new BOLUsers();
            Users ExistingUser = UsersBOL.GetDataByUsername(Username);
            if (ExistingUser != null)
            {
                pnlMessage.Visible = true;
                msgMessage.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgMessage.Text = "این نام کاربری قبلا ثبت شده است";
                return;
            }

            if (UsersBOL.EmailExists(Email))
            {
                pnlMessage.Visible = true;
                msgMessage.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgMessage.Text = "این ایمیل قبلا ثبت شده است";
                return;
            }

            string GenID = Tools.GetRandID();
            UsersBOL.ID = GenID;
            UsersBOL.FirstName = FirstName;
            UsersBOL.LastName = LastName;
            UsersBOL.Email = Email;
            UsersBOL.Username = Username;
            UsersBOL.Password = Tools.Encode(Password);
            UsersBOL.Email = Email;
            UsersBOL.Tel = Tel;
            UsersBOL.CellPhone = CellPhone;
            UsersBOL.AutoLogin = AutoLogin;
            UsersBOL.Active = Active;
            UsersBOL.HCGenderCode = HCGenderCode;

            UsersBOL.InsertRecord();
            pnlMessage.Visible = true;
            string GenderName = "";
            if (HCGenderCode == 1)
                GenderName = "آقای";
            else
                GenderName = "خانم";

            string MailBody = GenderName + " " + FirstName + " " + LastName + "<BR>";
            MailBody += "لطفا برای فعال کردن اکانت خود در سایت چند ثانیه روی لینک زیر کلیک کنید" + "<BR>";
            MailBody += "<a href=\"http://www.RooznameRasmi.ir/Users/Activate.aspx?Key=" + GenID + "\">http://www.RooznameRasmi.irUsers/Activate.aspx?Key=" + GenID + "</a>";
            BOLEmails EmailsBOL = new BOLEmails();
            EmailsBOL.Insert(Email, 6, "");

            Tools tools = new Tools();
            bool SendResult = tools.SendEmail(MailBody, "تکمیل عضویت ایران کیدز", "noreply@RooznameRasmi.ir", Email, "", "");
            if (SendResult)
            {
                msgMessage.MessageTextMode = AKP.Web.Controls.Common.MessageMode.OK;
                msgMessage.Text = "اطلاعات شما ثبت شد.لطفا برای تکمیل عضویت روی لینکی که به آدرس ایمیل شما فرستاده شده کلیک کنید." + "<br />" + "در صورتی که ایمیل مربوطه را دریافت نکردید قسمت Bulk یا Spam خود را نیز بررسی کنید.";
                pnlReg.Visible = false;
            }
            else
            {
                msgMessage.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgMessage.Text = "متاسفانه در ایجاد جساب کاربری شما خطایی رخ داده است.";
            }

        }
    }
}