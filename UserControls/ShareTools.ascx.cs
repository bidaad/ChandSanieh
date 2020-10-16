using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IranKids.UserControls
{
    public partial class ShareTools : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CurUrl = Request.Url.AbsoluteUri;

            hplGoolgePlus.NavigateUrl = "https://plus.google.com/share?url=" + CurUrl;
            hplTwitter.NavigateUrl = "http://twitter.com/intent/tweet?url=" + CurUrl + "&source=sharethiscom&related=sharethis&via=sharethis";
            hplFaceBook.NavigateUrl = "http://www.facebook.com/sharer.php?u=" + CurUrl;
        }
    }
}