<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="SendTo.aspx.cs" Inherits="AceNews.NewsFolder.SendTo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ارسال خبر</title>
    <link id="Link1" runat="server" href="~/Styles/main.css" media="screen" rel="stylesheet"
        type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset class="SendForm">
        <legend>ارسال خبر</legend>
            <AKP:MsgBox runat="server" ID="msgBox"></AKP:MsgBox>
            <div class="Marginer1">
                <asp:Label ID="lblTitle" runat="server" ></asp:Label>
            </div>
            <asp:Panel runat="server" ID="pnlSendNewsForm">
            <table>
                <tr>
                    <td><AKP:ExTextBox runat="server" ID="txtYourName"></AKP:ExTextBox> </td>
                    <td>نام شما:</td>
                </tr>
                <%--<tr>
                    <td><AKP:ExTextBox runat="server" ID="txtYourEmail"></AKP:ExTextBox> </td>
                    <td>ایمیل شما:</td>
                </tr>--%>
                <tr>
                    <td><AKP:ExTextBox runat="server" ID="txtToName"></AKP:ExTextBox> </td>
                    <td>نام گیرنده:</td>
                </tr>
                <tr>
                    <td><AKP:ExTextBox runat="server" ID="txtToEmail"></AKP:ExTextBox> </td>
                    <td><span style="color:Red">*</span>ایمیل گیرنده:</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSend" runat="server" CssClass="btnSend" Text="ارسال" onclick="btnSend_Click" />
                    </td>
                </tr>
            </table>
            </asp:Panel>
        </fieldset>
    </div>
    </form>
</body>
</html>
