<%@ Page Language="C#" AutoEventWireup="true" Title="عضویت در سایت چند ثانیه"
    MasterPageFile="~/Admin/Site.Master" CodeBehind="Register.aspx.cs" Inherits="IONS.SiteUsers.Register" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="MainLeftInner">
        <div class="Padder10">
            <table style="width: 95%; direction: ltr !important;" cellpadding="0" cellspacing="0">
                <tr>
                    <td class="WinThem1Corner1">
                        &nbsp;
                    </td>
                    <td class="WinThem1Mid">
                        عضویت در سایت چند ثانیه
                    </td>
                    <td class="WinThem1Corner2">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="WinThem1Left">
                        &nbsp;
                    </td>
                    <td style="direction: rtl; padding: 6px;">
                        <div class="Padder2">
                            <asp:Panel runat="server" ID="pnlMessage" Visible="false" CssClass="Message">
                                <div style="padding: 6px;">
                                    <AKP:MsgBox runat="server" ID="msgMessage">
                                    </AKP:MsgBox>
                                </div>
                            </asp:Panel>
                            <asp:Panel runat="server" ID="pnlReg" CssClass="Box3" Style="width: 500px;">
                                <asp:MultiView runat="server" ID="MVRegForm" ActiveViewIndex="0">
                                    <asp:View runat="server" ID="ViewEdit">
                                        
                                        <div style="text-align: right">
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <AKP:Combo ID="cboHCGenderCode" AllowNull="false" baseid="HCGenders" runat="server" />
                                                    
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label13" runat="server" Text="جنسیت:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <AKP:ExTextBox ID="txtFirstName" runat="server"></AKP:ExTextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="ValidateRegister" CssClass="cReq" Display="Dynamic" ControlToValidate="txtFirstName"
                                                        runat="server" ErrorMessage="نام را وارد کنید"></asp:RequiredFieldValidator>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label16" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    <asp:Label ID="Label1" runat="server" Text="نام:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <AKP:ExTextBox ID="txtLastName" runat="server"></AKP:ExTextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="Dynamic" ValidationGroup="ValidateRegister" CssClass="cReq" ControlToValidate="txtLastName"
                                                        runat="server" ErrorMessage="نام خانوادگی را وارد کنید"></asp:RequiredFieldValidator>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label17" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    <asp:Label ID="Label2" runat="server" Text="نام خانوادگی:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <AKP:ExTextBox ID="txtTel" runat="server"></AKP:ExTextBox>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label4" runat="server" Text="تلفن:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <AKP:ExTextBox ID="txtCellPhone" runat="server"></AKP:ExTextBox>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label11" runat="server" Text="همراه:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <AKP:ExTextBox ID="txtEmail" SkinID="English" runat="server"></AKP:ExTextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="cReq" ValidationGroup="ValidateRegister" ControlToValidate="txtEmail"
                                                        Display="Dynamic" runat="server" ErrorMessage="ایمیل را وارد کنید"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" CssClass="cReq" ValidationGroup="ValidateRegister" Display="Dynamic"
                                                        runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                                        ControlToValidate="txtEmail" ErrorMessage="ایمیل معتبر نیست"></asp:RegularExpressionValidator>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label18" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    <asp:Label ID="Label7" runat="server" Text="ایمیل:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <AKP:ExTextBox ID="txtUsername" SkinID="English" runat="server"></AKP:ExTextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="cReq" ValidationGroup="ValidateRegister" ControlToValidate="txtUsername"
                                                        runat="server" ErrorMessage="نام کاربری را وارد کنید"></asp:RequiredFieldValidator>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label29" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    <asp:Label ID="Label30" runat="server" Text="نام کاربری:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    
                                                    <AKP:ExTextBox ID="txtPassword" TextMode="Password"  SkinID="English" runat="server"></AKP:ExTextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="cReq" Display="Dynamic" ValidationGroup="ValidateRegister" ControlToValidate="txtPassword"
                                                        runat="server" ErrorMessage="کلمه عبور را وارد کنید"></asp:RequiredFieldValidator>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label20" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    <asp:Label ID="Label9" runat="server" Text="کلمه عبور:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    
                                                    <AKP:ExTextBox ID="txtConfirmPassword" TextMode="Password" SkinID="English" runat="server"></AKP:ExTextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="ValidateRegister" CssClass="cReq" ControlToValidate="txtConfirmPassword"
                                                        Display="Dynamic" runat="server" ErrorMessage="تایید کلمه عبور را وارد کنید"></asp:RequiredFieldValidator>
                                                    <asp:CompareValidator ID="CompareValidator1" ValidationGroup="ValidateRegister" Display="Dynamic" CssClass="cReq" runat="server" SetFocusOnError="true"
                                                        ControlToValidate="txtPassword" ControlToCompare="txtConfirmPassword" ErrorMessage="کلمه عبور و تایید کلمه عبور با هم تفاوت دارند"></asp:CompareValidator>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label3" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    <asp:Label ID="Label10" runat="server" Text="تایید کلمه عبور:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <asp:RadioButtonList ID="rblAutoLogin" RepeatDirection="Horizontal" CssClass="tblYesNo"
                                                        runat="server">
                                                        <asp:ListItem Value="1" Selected="True" Text="بله"></asp:ListItem>
                                                        <asp:ListItem Value="0" Text="خیر"></asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label5" runat="server" Text="ورود خودکار:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow" style="height: 100px;">
                                                <div class="FormCtrl" style="text-align: right">
                                                    <telerik:RadCaptcha ID="RadCaptcha1" CssClass="Capt" Width="300" CaptchaImage-ImageCssClass="CaptImg"
                                                        CaptchaTextBoxCssClass="CaptText" ValidationGroup="ValidateRegister" runat="server"
                                                        ErrorMessage="" CaptchaTextBoxLabel="">
                                                        <CaptchaImage TextChars="Numbers" />
                                                    </telerik:RadCaptcha>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label8" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    <asp:Label ID="Label6" runat="server" Text="کد امنیتی:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="Spacer1">
                                            </div>
                                            <div class="Clear">
                                            </div>
                                            <div class="BlueHeader" style="width: 100%; text-align: right; padding-top: 5px;">
                                                <asp:LinkButton ID="btnConfirm" ValidationGroup="ValidateRegister" CssClass="button2"
                                                    Text="تایید اطلاعات" runat="server" OnClick="btnConfirm_Click"></asp:LinkButton>
                                            </div>
                                        </div>
                                    </asp:View>
                                    <asp:View runat="server" ID="ViewFinal">
                                        <div style="text-align: right">
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <asp:Label ID="lblGender" runat="server"></asp:Label>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label12" runat="server" Text="جنسیت:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <asp:Label ID="lblFirstName" runat="server"></asp:Label>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label15" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    <asp:Label ID="Label19" runat="server" Text="نام:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <asp:Label ID="lblLastName" runat="server"></asp:Label>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label21" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    <asp:Label ID="Label22" runat="server" Text="نام خانوادگی:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <asp:Label ID="lblTel" runat="server"></asp:Label>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label23" runat="server" Text="تلفن:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <asp:Label ID="lblCellPhone" runat="server"></asp:Label>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label24" runat="server" Text="همراه:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label25" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    <asp:Label ID="Label26" runat="server" Text="ایمیل (نام کاربری):"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <asp:Label ID="lblPassword" runat="server"></asp:Label>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label27" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    <asp:Label ID="Label28" runat="server" Text="کلمه عبور:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="FormRow">
                                                <div class="FormCtrl">
                                                    <asp:Label ID="lblAutoLogin" runat="server"></asp:Label>
                                                </div>
                                                <div class="FormRight">
                                                    <asp:Label ID="Label32" runat="server" Text="ورود خودکار:"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="Spacer1">
                                            </div>
                                            <div class="Clear">
                                            </div>
                                            <div class="BlueHeader" style="width: 100%; text-align: right; padding-top: 5px;">
                                                <asp:LinkButton ID="btnSubmit" CssClass="button2" Text="تایید" runat="server" OnClick="btnSubmit_Click"></asp:LinkButton>
                                                <asp:LinkButton ID="btnEdit" ValidationGroup="ValidateRegister" CssClass="button2"
                                                    Text="اصلاح اطلاعات" runat="server" OnClick="btnEdit_Click"></asp:LinkButton>
                                            </div>
                                        </div>
                                    </asp:View>
                                </asp:MultiView>
                            </asp:Panel>
                        </div>
                    </td>
                    <td class="WinThem1Right">
                        &nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="WinThem1Corner3">
                        &nbsp;
                    </td>
                    <td class="WinThem1Bot">
                        &nbsp;
                    </td>
                    <td class="WinThem1Corner4">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
