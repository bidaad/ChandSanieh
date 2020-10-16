<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrintNews.aspx.cs" Inherits="ASNoor.NewsFolder.PrintNews" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link id="lnkMainCSS" runat="server" href="~/Styles/main.css" media="all" rel="stylesheet"
        type="text/css" />
    <title>الوقت</title>
    <meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
    <meta content="خبرگزاری آس" name="keywords" />
    <meta content="خبرگزاری آس" name="description" />
    <meta name="author" content=" «خبرگزاری آس»" />

</head>
<body style="background-image: none !important;">
    <form id="form1" runat="server">
    <div>
        <asp:Panel runat="server" CssClass="HomeWrapper NewsPrintCont" ID="pnlTextNews">
            <div class="Padder5">
                <div class="ShowNews">
                    <div>
                        <table style="width: 100%; direction: ltr; margin-bottom: 50px;">
                            <tr>
                                <td style="text-align: left;">
                                    <div class="NewsDate">
                                        <asp:Label ID="lblNewsCode" ClientIDMode="Static" runat="server"></asp:Label></div>
                                    
                                    <div class="NewsDate">
                                        <asp:Label ID="lblDate" ClientIDMode="Static" runat="server"></asp:Label></div>
                                </td>
                                <td style="text-align: right;">
                                    <asp:Image ID="Image1" ImageUrl="~/images/Logo.png" runat="server" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div>
                        <div class="SuTitr">
                            <asp:Label ID="lblSuTitr" ClientIDMode="Static" runat="server"></asp:Label></div>
                        <div class="FullNewsTitle">
                            <asp:Label ID="lblTitle" ClientIDMode="Static" runat="server"></asp:Label></div>
                        <div class="FullAbstract">
                            <asp:Label ID="lblAbstract" ClientIDMode="Static" runat="server"></asp:Label></div>
                    </div>
                </div>
            </div>
            <div class="Clear">
            </div>
            <div class="NewsBody">
                <asp:HyperLink ID="hplImage" CssClass="PrintPic" BorderWidth="1" BorderColor="Gray" runat="server"></asp:HyperLink>
                <asp:Literal ID="ltrNewsBody" runat="server"></asp:Literal>
            </div>
        </asp:Panel>
    </div>
    </form>
    <script type="text/javascript">
        window.print();
    </script>
</body>
</html>
