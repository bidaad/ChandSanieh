<%@ Page Language="C#" MasterPageFile="~/MainRoot.Master" AutoEventWireup="true"
    CodeBehind="ContactUs.aspx.cs" Inherits="AceNews.ContactUs" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <div class="InnerPage">
        <div class="GrayContent">
            <div class="ContentTop">
            </div>
            <div class="ContentInner">
                <div>
                    <AKP:MsgBox runat="server" ID="msgBox" />
                </div>
                <div>
                    <table class="tblContact">
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <div>
                                                <asp:Label ID="lblName" CssClass="clbl" runat="server" Text="الاسم: "></asp:Label>
                                            </div>
                                            <div>
                                                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                            </div>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div>
                                                <asp:Label ID="lblEmail" runat="server" Text="البرید الکترونیکی: "></asp:Label>
                                            </div>
                                            <div>
                                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                            </div>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div>
                                                <asp:Label ID="lblCaptcha" runat="server" Text="الرمز:"></asp:Label>
                                            </div>
                                            <div>
                                                <telerik:RadCaptcha ID="RadCaptcha1" ValidationGroup="ContactCenter" CssClass="Capt"
                                                    Width="200" CaptchaImage-ImageCssClass="CaptImg" CaptchaTextBoxCssClass="CaptText"
                                                    runat="server" ErrorMessage="" CaptchaTextBoxLabel="">
                                                </telerik:RadCaptcha>
                                            </div>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <div class="btnSendContact">
                                    <asp:ImageButton ImageUrl="~/images/btnUCSendComment.png" ID="btnSendComment" ValidationGroup="ContactCenter" CssClass="btnSendComment" Text="ارسال" 
                                        runat="server" OnClick="btnSend_Click"></asp:ImageButton>
                                </div>
                                            &nbsp;
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>
                                <div>
                                    <asp:Label ID="lblComment" runat="server" Text="النص: "></asp:Label>
                                </div>
                                <div>
                                    <asp:TextBox ID="txtComment" TextMode="MultiLine" Width="400" Height="225" runat="server"></asp:TextBox>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="Clear">
                </div>
            </div>
            <div class="ContentBot">
            </div>
        </div>
    </div>
    <div class="Clear">
    </div>
    
    <script type="text/javascript">
        $("#ToTop").click(function () {
            $("html, body").animate({ scrollTop: 0 }, "slow");
            return false;
        });
    </script>
</asp:Content>
