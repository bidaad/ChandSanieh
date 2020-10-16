<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/Main.master"
    AutoEventWireup="true" Inherits="Comments_EditComments" Title="Comments" CodeBehind="EditComments.aspx.cs" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    <div class="cTblEdit">
        <div style="width: 700px; float: right; text-align: right; color: White;">
            <asp:Label runat="server" ID="lblSysName"></asp:Label></div>
        <div class="cTDEdit">
            <div class="cEditRight">
                <div class="cEditMain">
                    <div class="cEditMainData">
                        <div>
                            <AKP:MsgBox ID="msgBox" runat="server" CssClass="cError" />
                        </div>
                        <div>
                            <table class="cTblOneRow">
                                <tr>
                                    <td class="cFieldLeft">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:Combo ID="cboHCLanguageCode" jas="1" Width="480" AllowNull="false" MaxLength="100" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="Label2" runat="server" Text="زبان:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    
                                </tr>
                            </table>
                        </div>
                        <div class="CommentItem">
                            <asp:HyperLink ID="hplItem" Font-Bold="true" ForeColor="#990000" Target="_blank"
                                runat="server"></asp:HyperLink>
                        </div>
                        <div class="CommentBox">
                            <table>
                                <tr>
                                    <td>
                                        <div class="clear">
                                        </div>
                                        <div style="margin-right: 20px; margin-left: 40px;">
                                            <table>
                                                <tr>
                                                    <td>
                                                        <AKP:ExTextBox ID="txtTextComment" jas="1" Width="363" Height="140" CssClass="cMultiLine"
                                                            TextMode="MultiLine" MaxLength="4000" runat="server" />
                                                    </td>
                                                    <td style="vertical-align: top; white-space: nowrap;" class="cLabel">
                                                        <asp:Label ID="Label1" runat="server" Text="نظر کاربر:"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </td>
                                    <td>
                                        <div >
                                            <table>
                                                <tr>
                                                    <td class="cCtrl2">
                                                        <AKP:ExTextBox ID="txtName" jas="1" MaxLength="500" runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblName" runat="server" Text="نام:"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="cCtrl2">
                                                        <AKP:ExTextBox ID="txtEmail" jas="1" MaxLength="50" runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblEmail" runat="server" Text="ايميل:"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="cCtrl2">
                                                        <AKP:Combo ID="cboHCCommentStatusCode" Width="140" AllowNull="false" jas="1" runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblHCCommentStatusCode" runat="server" Text="وضعيت:"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="cCtrl2">
                                                        <AKP:Combo ID="cboHCSectionCode" Width="140" AllowNull="false" jas="1" runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblHCSectionCode" runat="server" Text="نوع:"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="cCtrl2">
                                                        <AKP:FarsiDate ID="dteSendDate" jas="1" runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblSendDate" runat="server" Text="تاريخ ارسال:"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                        <div class="clear">
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="clear">
        </div>
        <div style="text-align: right">
            <table class="tblEditButtons" cellpadding="2" cellspacing="4">
                <tr>
                    <td>
                        <asp:ImageButton ID="imgBtnBack" Text=" بازگشت " SkinID="BackButton" OnClick="GoToList"
                            runat="server" />
                    </td>
                    <td>
                        <asp:ImageButton ID="imgBtnSave" Text=" ذخیره " SkinID="SaveButton" OnClick="DoSave"
                            runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
