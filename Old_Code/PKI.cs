using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Text;
using Enums;
using System.Data;
using AceNews.Old_Code.DAL;
using App_Code.Cryptography;
using CAPICOM;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.WebControls;

[WebService(Namespace = "http://RooznamehRasmi.ir/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]

public class PKI : WebService
{

    public class Setting
    {
        public string MsgText { get; set; }
        public bool MsgVisible { get; set; }

        public bool CircleVisible { get; set; }

        public string CaptchaText { get; set; }
        public string CaptchaImageUrl { get; set; }
        public bool CaptchaVisible { get; set; }

        public string Tumbprint { get; set; }
        public bool NeedCert { get; set; }

        public string RawUrl { get; set; }
        public string UrlHost { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public DateTime ServerTime { get; set; }

    }

    readonly BOLUsers BOLUsers = new BOLUsers();

    [WebMethod(true)]
    public Setting CheckUserValidation(string userName, string Pass, string captcha, string RawUrl, string UrlHost)
    {
        Setting _setting = new Setting();
        _setting.CaptchaText = Session["captcha"] != null ? Session["captcha"].ToString() : "";
        _setting.MsgVisible = false;
        _setting.RawUrl = RawUrl;
        _setting.UrlHost = UrlHost;
        _setting.UserName = userName;
        _setting.Pass = Pass;

        BOLLogs BOLlogs = new BOLLogs();

        string strlogContent = "<login><UserName>" + userName + "</UserName><Password>" + Pass + "</Password></login>";

        if (!HttpContext.Current.Request.Browser.Browser.ToUpper().Contains("IE"))
        {
            _setting.MsgText = Messages.ShowMessage(MessagesEnum.IEOnly);
            _setting.MsgVisible = true;
            SetCaptcha(_setting);
            return _setting;
        }

        if (Session["captcha"] == null || Session["captcha"].ToString() != captcha)
        {
            _setting.MsgText = Messages.ShowMessage(MessagesEnum.InvalidCaptcha);
            _setting.MsgVisible = true;
            SetCaptcha(_setting);
            return _setting;
        }

        //====================================
        Users ValidUser = BOLUsers.GetDataByUsername(userName);
        if (ValidUser == null)
        {
            //BOLlogs.InsertIntoLogs((int)Enums.LogTypes.enm_InvalidLogin, 0, strlogContent, RawUrl, UrlHost);
            //_setting.MsgText = Messages.ShowMessage(MessagesEnum.InvalidUsernameORPassword);
            //_setting.MsgVisible = true;

            //SetCaptcha(_setting);
            return _setting;
        }
        else
        {
            Session["UserName"] = userName;
        }
        string HashedPass;
        string DBPassword = ValidUser.Password;

        //============Check username============

        if (ValidUser.Username != userName)
        {
            //BOLlogs.InsertIntoLogs((int)Enums.LogTypes.enm_InvalidLogin, ValidUser.Code, strlogContent, RawUrl, UrlHost);
            //_setting.MsgText = Messages.ShowMessage(MessagesEnum.InvalidUsernameORPassword);
            //_setting.MsgVisible = true;

            //SetCaptcha(_setting);
            return _setting;
        }

        //============Check pass================

        if ((bool)ValidUser.IsPasswordSHA1)
            HashedPass = Tools.EncryptSHA1(Pass);
        else
        {
            HashedPass = Tools.EncryptRIC(Pass).ToString();
            if (HashedPass == DBPassword)
                BOLUsers.ConvertRICtoSHA1(ValidUser.Code, Pass);
        }

        if (HashedPass != DBPassword)
        {
            //BOLlogs.InsertIntoLogs((int)Enums.LogTypes.enm_InvalidLogin, ValidUser.Code, strlogContent, RawUrl, UrlHost);
            _setting.MsgText = Messages.ShowMessage(MessagesEnum.InvalidUsernameORPassword);
            _setting.MsgVisible = true;

            SetCaptcha(_setting);
            return _setting;
        }

        //============Check Block================

        //if (!BOLUsers.IsUserBlocked(ValidUser.Code, ValidUser.HCUserBlockedCode, strlogContent,
        //                    Server.MapPath("~/Configuration.xml"), RawUrl, UrlHost))
        //{
        //    BOLlogs.InsertIntoLogs((int)Enums.LogTypes.enm_Blocked, ValidUser.Code, strlogContent, RawUrl, UrlHost);

        //    _setting.MsgText = Messages.ShowMessage(MessagesEnum.BlockedUser);
        //    _setting.MsgVisible = true;

        //    SetCaptcha(_setting);
        //    return _setting;
        //}

        ////===========Check LoginCount============

        //if (!BOLUsers.CheckForLoginTryCount(ValidUser.Code, ValidUser.HCUserBlockedCode, strlogContent,
        //             Server.MapPath("~/Configuration.xml"), RawUrl, UrlHost))
        //{
        //    BOLlogs.InsertIntoLogs((int)Enums.LogTypes.enm_InvalidLoginCount, ValidUser.Code, strlogContent, RawUrl, UrlHost);
        //    _setting.MsgText = Messages.ShowMessage(MessagesEnum.InvalidLoginCount);
        //    _setting.MsgVisible = true;

        //    SetCaptcha(_setting);
        //    return _setting;
        //}

        //===========Get NeetCert================

        _setting.NeedCert = ValidUser.NeedCert.HasValue ? ValidUser.NeedCert.Value : false;
        _setting.Tumbprint = ValidUser.ThumbPrint;

        return _setting;// Tools.CheckForCorrectionForm(prinipal, _setting, ValidUser);
    }

    [WebMethod(true)]
    public Setting Login(object setting)
    {
        Setting _setting = (setting) as Setting;
        if (_setting != null)
        {
            string RawUrl = _setting.RawUrl;
            string UrlHost = _setting.UrlHost;
            string Username = _setting.UserName;
            string Pass = _setting.Pass;

            //if (HttpContext.Current.Request.UrlReferrer != null)
            //    if (
            //        HttpContext.Current.Request.UserHostAddress != "127.0.0.1" && 
            //        !HttpContext.Current.Request.UrlReferrer.PathAndQuery.ToLower().Contains("iranamlaak.ir"))
            //    {
            //        SetCaptcha(ref _setting);
            //        return _setting;
            //    }

            if (!ValidateInputs(Username, Pass, ref _setting))
            {
                SetCaptcha(_setting);
                return _setting;
            }

            SetCaptcha(_setting);
            _setting.CaptchaVisible = true;
            BOLLogs logsBOL = new BOLLogs();

            _setting.CircleVisible = false;
            _setting.MsgVisible = false;

            if (string.IsNullOrEmpty(Username))
            {
                _setting.MsgVisible = true;
                _setting.MsgText = "کلمه عبور را وارد نمایید";
                SetCaptcha(_setting);
                return _setting;
            }
            if (string.IsNullOrEmpty(Pass))
            {
                _setting.MsgVisible = true;
                _setting.MsgText = "رمز عبور را وارد نمایید";

                SetCaptcha(_setting);
                return _setting;
            }

            string strlogContent = "<login><UserName>" + Username + "</UserName><Password>" + Pass + "</Password></login>";

            try
            {
                Users ValidUser = BOLUsers.GetDataByUsername(Username);

                if (ValidUser != null)
                {
                    Session["UserName"] = Username;
                    string HashedPass;
                    string DBPassword = ValidUser.Password;
                    if (ValidUser.Username != Username)
                    {
                        _setting.MsgText = Messages.ShowMessage(MessagesEnum.InvalidUsernameORPassword);
                        SetCaptcha(_setting);
                        return _setting;
                    }

                    //تعداد دفعات ورود به سیستم
                    //if (!BOLUsers.CheckForLoginTryCount(ValidUser.Code, ValidUser.HCUserBlockedCode, strlogContent,
                    //                                    Server.MapPath("~/Configuration.xml"), RawUrl, UrlHost))
                    //{
                    //    _setting.MsgText = Messages.ShowMessage(MessagesEnum.InvalidLoginCount);
                    //    _setting.MsgVisible = true;

                    //    logsBOL.InsertIntoLogs((int)Enums.LogTypes.enm_InvalidLoginCount, ValidUser.Code, strlogContent, RawUrl, UrlHost);
                    //    SetCaptcha(_setting);
                    //    return _setting;
                    //}

                    if ((bool)ValidUser.IsPasswordSHA1)
                        HashedPass = Tools.EncryptSHA1(Pass);
                    else
                    {
                        HashedPass = Tools.EncryptRIC(Pass).ToString();
                        if (HashedPass == DBPassword)
                        {
                            BOLUsers.ConvertRICtoSHA1(ValidUser.Code, Pass);
                        }
                    }

                    if (HashedPass == DBPassword)//اگر کلمه عبور وارد شده صحیح بود
                    {
                        GetGroupCode(ValidUser.Code);

                        //Login Successful

                        var UsersBOL = new BOLUsers();
                        Users CurUser = UsersBOL.GetDataByUsername(Username);


                        _setting.CircleVisible = true;
                        //  _setting.MsgText = "در حال ورود به سیستم";

                        GetGroupName(ValidUser.Code);
                        FillSessions(ValidUser.Code, Username);
 
                        //...
                        DateTimeMethods dtM = new DateTimeMethods();
                        string strCurrent_Date = dtM.GetPersianDateTime(DateTime.Now);

                        //...Fill User Info in Application["ActiveUsersLst"]
                        //...
                        bool blnCnt;
                        string strNewToCache = HttpContext.Current.Session.SessionID + "," + ValidUser.Code + "," + Session["FirstName"] + " " + Session["LastName"] + "," + Session["GroupName"] + "," + Session["ZoneName"] + "," + strCurrent_Date + "," + HttpContext.Current.Request.UserHostAddress + "";
                        string strNewApp = SetToCache(ValidUser.Code, strNewToCache, out blnCnt);

                        Application.Lock();
                        Application["ActiveUsersLst"] = strNewApp;

                        if (blnCnt)
                        {
                            Application["ActiveUsersCnt"] = Convert.ToInt32(Application["ActiveUsersCnt"]) + 1;
                        }

                        Application.UnLock();
                        //...

                        //logsBOL.InsertIntoLogs((int)Enums.LogTypes.enm_Login, ValidUser.Code, "<login><UserName>" + Username + "</UserName></login>", RawUrl, UrlHost);

                    }
                    else
                    {
                        _setting.MsgText = Messages.ShowMessage(MessagesEnum.InvalidLogin);
                        _setting.MsgVisible = true;
                        //logsBOL.InsertIntoLogs((int)Enums.LogTypes.enm_InvalidLogin, ValidUser.Code, strlogContent, RawUrl, UrlHost);
                    }
                }
                else
                {
                    _setting.MsgText = Messages.ShowMessage(MessagesEnum.InvalidLogin);
                    _setting.MsgVisible = true;
                    //logsBOL.InsertIntoLogs((int)Enums.LogTypes.enm_InvalidLogin, 0, strlogContent, RawUrl, UrlHost);
                }

            }
            catch (Exception ex)
            {
                ControlCollection cc = GetPageControls(Username, Pass);

                Tools.LogException(ex, cc);
                _setting.MsgText = "خطا در شبکه";
                _setting.MsgVisible = true;

                //if (Session["userCode"] != null)
                //    logsBOL.InsertIntoLogs((int)Enums.LogTypes.enm_ErrorInNetwork, Convert.ToInt32(Session["userCode"]), strlogContent, RawUrl, UrlHost);
                //else
                //    logsBOL.InsertIntoLogs((int)Enums.LogTypes.enm_ErrorInNetwork, 0, strlogContent, RawUrl, UrlHost);
            }
        }


        SetCaptcha(_setting);
        return _setting;
    }

    [WebMethod(true)]
    public Setting GetServerTime(object setting)
    {
        Setting _setting = setting as Setting;
        _setting.ServerTime = DateTime.Now;
        return _setting;
    }

    [WebMethod(true)]
    public Setting HashAndcheckval(object setting, string signature)
    {
        X509Chain chain = new X509Chain();
        chain.ChainPolicy.RevocationMode = X509RevocationMode.Offline;



        Setting _setting = setting as Setting;
        BOLLogs BOLlogs = new BOLLogs();
        Users ValidUser = BOLUsers.GetDataByUsername(_setting.UserName);

        string hashData = DoHash(_setting.Pass);
        hashData = "<login><Password>" + hashData + "</Password><UserName>" + _setting.UserName + "</UserName><Captcha>" +
            _setting.CaptchaText + "</Captcha></login>";


        string strlogContent = "<login><UserName>" + _setting.UserName + "</UserName><Password>" + _setting.Pass + "</Password></login>";

        SignedData mySD = new SignedData();

        try
        {
            mySD.Verify(signature, false, CAPICOM_SIGNED_DATA_VERIFY_FLAG.CAPICOM_VERIFY_SIGNATURE_ONLY);

            if (mySD.Content != hashData)
            {
                _setting.MsgText = "محتوای امضا تغییر یافته است";
                _setting.MsgVisible = true;
                //BOLlogs.InsertIntoLogs((int)Enums.LogTypes.enm_ErrorInVerify, ValidUser.Code, strlogContent, _setting.RawUrl, _setting.UrlHost);

                return _setting;
            }

            int count = mySD.Certificates.Count;

            string thump;
            Boolean IsValidThump = false;
            for (int i = 1; i <= count; i++)
            {
                Certificate cr = (Certificate)mySD.Certificates[i];
                thump = cr.Thumbprint;
                if (!IsValidThump)
                    if (_setting.Tumbprint.ToUpper() == thump)
                        IsValidThump = true;
            }
            if (IsValidThump)
                Login(setting);
            else
            {
                _setting.MsgText = " با گواهی مربوطه امضا نشده است";
                _setting.MsgVisible = true;
                //BOLlogs.InsertIntoLogs((int)Enums.LogTypes.enm_SignedWithAnotherCertificate, ValidUser.Code, strlogContent, _setting.RawUrl, _setting.UrlHost);
            }

        }
        catch (Exception e)
        {
            //_setting.MsgText = "امضا نامعتبر است";
            //_setting.MsgVisible = true;
            //BOLlogs.InsertIntoLogs((int)Enums.LogTypes.enm_InvalidSign, ValidUser.Code, strlogContent, _setting.RawUrl, _setting.UrlHost);
        }

        SetCaptcha(_setting);
        return _setting;
    }


    ////////////////////////////////////////////////////////////////////
    bool ValidateInputs(string UserName, string Pass, ref Setting setting)
    {
        if (!IsSuccess(ref setting))
        {
            SetCaptcha(setting);
            return false;
        }

        Dictionary<string, string> controls = new Dictionary<string, string>();
        Tools.GetControlValues(GetPageControls(UserName, Pass), true, ref controls);
        foreach (KeyValuePair<string, string> entry in controls)
            if (Tools.ContainsIllegalCharacter(entry.Value))
            {
                setting.MsgVisible = true;
                setting.MsgText = "به دلیل استفاده از کاراکترهای غیر مجاز ، مجاز به ورود به سامانه نمی باشید.";
                return false;
            }



        return true;
    }

    private bool IsSuccess(ref Setting setting)
    {
        if (Session["captcha"] != null && setting.CaptchaText != "" && setting.CaptchaText.ToLower() == Session["captcha"].ToString())
        {
            // success ();
            return true;
        }
        else
        {
            setting.CaptchaText = "";
            SetCaptcha(setting);
            setting.MsgVisible = true;
            setting.MsgText = Messages.ShowMessage(MessagesEnum.InvalidCaptcha);
            return false;
        }
    }
    
    

    void GetGroupName(int userCode)
    {
        BOLUserGroups UserGroupBOL = new BOLUserGroups(userCode);
        DataTable dt = UserGroupBOL.GetGroupNameByUserCode(userCode);

        if (dt.Rows.Count > 0)
        {
            Session["GroupName"] = dt.Rows[0]["GroupName"];
        }
    }

    //LoginUser
    void FillSessions(int userCode, string txtUserName)
    {
        IQueryable<vUserAccess> AccessList = BOLUsers.GetUserAccess(userCode);

        Session["Username"] = txtUserName;

        foreach (var item in AccessList)
        {
            Session["FirstName"] = item.FirstName;
            Session["LastName"] = item.LastName;
        }

        Session["userCode"] = userCode;
    }

    void GetGroupCode(int userCode)
    {
        BOLUserGroups UserGroupBOL = new BOLUserGroups(userCode);
        DataTable dt = ((IBaseBOL<UserGroups>)UserGroupBOL).GetDataSource(new SearchFilterCollection(), "Code", 10, 1);

        string GroupCode = "";
        foreach (DataRow dr in dt.Rows)
            GroupCode = dr["GroupCode"].ToString();
        Session["GroupCode"] = GroupCode;
    }

    string SetToCache(int userCode, string strNewToCache, out bool blnCnt)
    {
        string strAppContent = Application["ActiveUsersLst"].ToString();

        if (strAppContent == "")
        {
            strAppContent = "[" + strNewToCache + "]" + strAppContent;
            blnCnt = true;
            return (strAppContent);
        }

        int intStart = 0;
        int intComma = 0;
        bool blnFlag = false;

        string strOld = "";
        string strUserCode = "";

        //...for recognising increase Application["ActiveUsersCnt"] or not
        blnCnt = true;

        for (int intTemp = 0; intTemp <= strAppContent.Length - 1; intTemp++)
        {
            if (strAppContent[intTemp].ToString() == "[")
            {
                intStart = intTemp;
                intComma = 0;
                strOld = "";

                continue;
            }

            if (strAppContent[intTemp].ToString() == ",")
            {
                if (intComma == 1 && strUserCode == userCode.ToString())
                    blnFlag = true;

                intComma = intComma + 1;
                strOld = strOld + strAppContent[intTemp];
            }
            else
            {
                if (strAppContent[intTemp].ToString() == "]")
                {
                    int intEnd = intTemp;

                    if (blnFlag)
                    {
                        strAppContent = strAppContent.Remove(intStart, intEnd - intStart + 1);
                        blnCnt = false;
                        break;
                    }
                    strUserCode = "";
                }
                else
                {
                    if (intComma == 1)
                        strUserCode = strUserCode + strAppContent[intTemp];
                    strOld = strOld + strAppContent[intTemp];
                }
            }
        } //...for

        //If this is the first time this user login
        if (!blnFlag)
        {
            //strAppContent = "[" + strNewToCache + "]" + strAppContent;
            blnCnt = true;
        }
        strAppContent = "[" + strNewToCache + "]" + strAppContent;

        return strAppContent;
    }

    ControlCollection GetPageControls(string Username, string Pass)
    {
        ControlCollection cc = new ControlCollection(new Page());

        TextBox txtusername = new TextBox();
        txtusername.Text = Username;

        TextBox txtpass = new TextBox();
        txtpass.Text = Pass;
        return cc;
    }

    void SetCaptcha(Setting setting)
    {
        string ens;
        string s;
        do
        {
            s = RandomText.Generate();
            ens = Encryptor.Encrypt(s, "srgerg$%^bg", Convert.FromBase64String("srfjuoxp"));
        }
        while (CheckPermissionHttpModule.QueryStringContainsIllegalCharacters(ens));

        Session["captcha"] = s.ToLower();

        setting.CaptchaText = "";
        setting.CaptchaImageUrl = "../HttpHandler/Captcha.ashx?w=185&h=92&c=" + ens + "&bc=" + "#ff87691";
    }

    public string DoHash(string val)
    {
        HashedData hashed = new HashedData();
        hashed.Algorithm = CAPICOM_HASH_ALGORITHM.CAPICOM_HASH_ALGORITHM_SHA1;
        hashed.Hash(val);
        return hashed.Value;
    }

}