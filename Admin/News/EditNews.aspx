<%@ Page Language="C#" AutoEventWireup="True" ValidateRequest="false" MasterPageFile="~/Admin/Main.master"
    CodeBehind="EditNews.aspx.cs" Inherits="News_EditNews" %>

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
                                                    <AKP:ExTextBox ID="txtNewsNumber" jas="1" MaxLength="100" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblNewsNumber" runat="server" Text="شماره خبر:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="cFieldRight">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:FarsiDate ID="dteNewsDate" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblNewsDate" runat="server" Text="تاريخ خبر:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="clear">
                        </div>
                        
                        <div>
                            <table class="cTblOneRow">
                                <tr>
                                    <td>
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:ExTextBox ID="txtTitle" jas="1" Width="475" MaxLength="500" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblTitle" runat="server" Text="عنوان:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div>
                            <table class="cTblOneRow">
                                <tr>
                                    <td>
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:ExTextBox ID="txtAbstract" jas="1" CssClass="cMultiLine" Width="475" TextMode="MultiLine"
                                                        MaxLength="4000" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblAbstract" runat="server" Text="متن خبر:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div>
                            <table class="cTblOneRow">
                                <tr>
                                    <td>
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:ExTextBox ID="txtKeywords" jas="1" Width="475" Height="80" TextMode="MultiLine" MaxLength="500" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="Label1" runat="server" Text="کلیدواژه ها: (با Enter از هم جدا شوند)"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="clear">
                        </div>
                        <div class="UploaderContainer">
                            <fieldset style="direction: rtl">
                                <legend>&nbsp;<asp:Label runat="server" Text="عکس" ID="lblPicFile2" />&nbsp;</legend>
                                <div>
                                    <table class="cTblOneRow2">
                                        <tr>
                                            <td class="cFieldLeft2">
                                                <AKP:ExRadUpload ID="uplPicFile2" jas="1" AutoSave="false" runat="server" AllowedFileExtensions=".gif,.jpg,.jpeg,.png,.bmp"
                                                    TargetFolder="~/Files/News/" Skin="Vista" MaxFileSize="99990000" ControlObjectsVisibility="None" />
                                                <br />
                                                <asp:CheckBox ID="chkDeletePicFile2" runat="server" Text="حذف فایل" />
                                            </td>
                                            <td class="cFieldRight2">
                                                <div class="cPic">
                                                    <asp:HyperLink rel="lightbox" Target="_blank" runat="server" ID="hplPicFile2" />
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </fieldset>
                        </div>
                        <div class="clear">
                        </div>
                        <div>
                            <table class="cTblOneRow">
                                <tr>
                                    <td class="cFieldLeft">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:ExCheckBox ID="chkShowInTelex" jas="1" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblShowInTelex" runat="server" Text="نمايش در تلکس:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="cFieldRight">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:ExCheckBox ID="chkSpecial" jas="1" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblSpecial" runat="server" Text="نمایش در برگزیده:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div>
                            <table class="cTblOneRow">
                                <tr>
                                    <td class="cFieldLeft">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:ExCheckBox ID="chkEditorChoice" jas="1" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="Label3" runat="server" Text="انتخاب سردبیر:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="cFieldRight">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:Combo ID="cboHCNewsTypeCode" AllowNull="false" jas="1" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="Label4" runat="server" Text="نوع:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div>
                            <table class="cTblOneRow">
                                <tr>
                                    <td class="cFieldLeft">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:Combo ID="cboPriorityTypeCode" AllowNull="false" runat="server">
                                                        <asp:ListItem Value="" Text=""></asp:ListItem>
                                                        <asp:ListItem Value="1" Text="خبر اول"></asp:ListItem>
                                                        <asp:ListItem Value="2" Text="خبر دوم"></asp:ListItem>
                                                        <asp:ListItem Value="3" Text="خبر سوم"></asp:ListItem>
                                                        <asp:ListItem Value="4" Text="خبر چهارم"></asp:ListItem>
                                                        <asp:ListItem Value="5" Text="خبر پنجم"></asp:ListItem>
                                                        <asp:ListItem Value="6" Text="خبر ششم"></asp:ListItem>
                                                        <asp:ListItem Value="7" Text="خبر هفتم"></asp:ListItem>
                                                        <asp:ListItem Value="8" Text="خبر هشتم"></asp:ListItem>
                                                        <asp:ListItem Value="9" Text="خبر نهم"></asp:ListItem>
                                                        <asp:ListItem Value="10" Text="سایر اخبار"></asp:ListItem>
                                                    </AKP:Combo>
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblHCNewsCatCode" runat="server" Text="اولویت خبر:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="cFieldRight">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:Combo ID="cboHCNewsCatCode" AllowNull="false" jas="1" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="Label2" runat="server" Text="گروه خبر:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        

                        <div>
                            <table class="cTblOneRow">
                                <tr>
                                    <td class="cFieldLeft">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:ExCheckBox ID="chkShowPic" runat="server">
                                                        
                                                    </AKP:ExCheckBox>
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="Label5" runat="server" Text="نمایش عکس خبر:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="cFieldRight">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    
                                                </td>
                                                <td class="cLabel">
                                                    
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
        <div class="cHorSep">
        </div>
        <div class="clear">
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
    <asp:HiddenField ID="hfPassword" runat="server" />
</asp:Content>
