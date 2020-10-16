using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceNews.Old_Code.DAL;

namespace AceNews.UserControls
{
    public partial class UCSelectedNews : System.Web.UI.UserControl
    {
        protected string _showedCode = "";
        public string ShowedCodes
        {
            get
            {
                return _showedCode;
            }
            set
            {
                _showedCode = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BOLNews NewsBOL = new BOLNews();
            //rptNews.DataSource = NewsBOL.GetNewsByContentType(9, 4);
            IQueryable<vNews> Result = NewsBOL.GetSepcialNews(5);
            rptNews.DataSource = Result;
            rptNews.DataBind();

            foreach (var item in Result)
            {
                if (_showedCode == "")
                    _showedCode = item.Code.ToString();
                else
                    _showedCode += "," + item.Code.ToString();
            }

        }

        public string GetSelectedCode()
        {

            BOLNews NewsBOL = new BOLNews();
            IQueryable<vNews> Result = NewsBOL.GetSepcialNews( 4);

            foreach (var item in Result)
            {
                if (_showedCode == "")
                    _showedCode = item.Code.ToString();
                else
                    _showedCode += "," + item.Code.ToString();
            }
            return _showedCode;

        }
    }
}