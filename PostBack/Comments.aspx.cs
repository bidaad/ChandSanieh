using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using AceNews.Old_Code.BOL.Likes;

namespace AceNews.PostBack
{
    public class op_result
    {
        private string _result;
        private int _status;
        public string result
        {
            set
            {
                _result = value;
            }
            get
            {
                return _result;
            }
        }
        public int status
        {
            set
            {
                _status = value;
            }
            get
            {
                return _status;
            }
        }
    }

    public partial class Comments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Url = Request.Url.Host.Trim().ToLower();
            string HTTP_REFERER = Request.ServerVariables["HTTP_REFERER"];
            if (HTTP_REFERER != null && HTTP_REFERER.IndexOf(Url) != -1)
            {
                string ActionType = Request.Form["ActionType"];
                switch (ActionType)
                {
                    case "1":
                        GetNewsComments();
                        break;
                    case "2":
                        SendComment();
                        break;
                    case "3":
                        SendLike();
                        break;

                }
            }
        }

        private void SendLike()
        {
            string NewsLikes = "";
            if (Request.Cookies["AceNewsDB"] != null)
            {
                NewsLikes = Request.Cookies["AceNewsDB"]["NewsLikes"];
            }

            
            op_result _op_result = new op_result();

            int HCSectionCode = 1;
            int ItemCode;
            string strNewsCode = Request.Form["NewsCode"];
            Int32.TryParse(strNewsCode, out ItemCode);

            if (NewsLikes == null)
                NewsLikes = "";

            string[] NewsLikesArray = NewsLikes.Split(',');
            if (!NewsLikesArray.Contains(strNewsCode))
            {
                if (ItemCode != 0)
                {
                    BOLLikes LikesBOL = new BOLLikes();
                    bool Result = LikesBOL.InsertLike(HCSectionCode, ItemCode);
                    if (Result)
                    {
                        _op_result.result = "OK";
                        if (NewsLikes == "")
                            NewsLikes = strNewsCode;
                        else
                            NewsLikes = NewsLikes + "," + strNewsCode;
                    }
                    else
                        _op_result.result = "NOK";
                }
                else
                    _op_result.result = "NOK";
            }
            else
                _op_result.result = "NOK";


            

            Response.Cookies["AceNewsDB"].Expires = DateTime.Now.AddDays(30);
            Response.Cookies["AceNewsDB"]["NewsLikes"] = NewsLikes;

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = serializer.Serialize((object)_op_result);
            Response.Write(json);
            Response.End();

        }

        private void SendComment()
        {
            string strNewsCode = Request.Form["NewsCode"];
            string Name = Request.Form["Name"];
            string Email = Request.Form["Email"];
            string Comment = Request.Form["Comment"];

            int HCSectionCode = 1;
            int ItemCode;
            Int32.TryParse(strNewsCode, out ItemCode);

            BOLComments CommentsBOL = new BOLComments();
            bool Result = CommentsBOL.SaveComment(HCSectionCode, ItemCode, Name, Email, Comment);

            op_result _op_result = new op_result();

            if (Result)
            {
                _op_result.result = "نظر با موفقیت ثبت شد";
                //msgBox.Text = "نظر شما با موفقیت دریافت شد";
            }
            else
            {
                _op_result.result = "متاسفانه خطایی در ثبت نظر رخ داده است";
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = serializer.Serialize((object)_op_result);
            Response.Write(json);
            Response.End();
        }

        private void GetNewsComments()
        {
            string strNewsCode = Request.Form["NewsCode"];
            int NewsCode;
            Int32.TryParse(strNewsCode, out NewsCode);
            if (NewsCode == 0)
                return;

            BOLComments CommentsBOL = new BOLComments();
            var Result = CommentsBOL.GetCommentsByStatusCode(NewsCode, 2);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = serializer.Serialize((object)Result);
            Response.Write(json);
            Response.End();
        }
    }
}