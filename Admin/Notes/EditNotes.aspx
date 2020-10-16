<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/Main.master"
    AutoEventWireup="true" Inherits="Notes_EditNotes" Title="Notes" CodeBehind="EditNotes.aspx.cs" %>

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
                                    <td class="cFieldRight">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:ExTextBox ID="txtTitle" jas="1" MaxLength="500" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblTitle" runat="server" Text="عنوان:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="cFieldLeft">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:FarsiDate ID="dteSubjectDate" jas="1" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblSubjectDate" runat="server" Text="تاريخ ايجاد:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div>
                            <table class="cTblField">
                                <tr>
                                    <td class="cCtrl">
                                        <AKP:ExTextBox ID="txtDescription" jas="1" Width="500" Height="170" CssClass="cMultiLine"
                                            TextMode="MultiLine" MaxLength="4000" runat="server" />
                                    </td>
                                    <td class="cLabel">
                                        <asp:Label ID="lblDescription" runat="server" Text="متن :"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div>
                            <fieldset style="direction: rtl">
                                <legend>&nbsp;<asp:Label runat="server" Text="عکس" ID="lblLargePicFile" />&nbsp;</legend>
                                <table class="cTblOneRow">
                                    <tr>
                                        <td class="cFieldLeft">
                                            <div class="cPic">
                                                <AKP:ExRadUpload ID="uplLargePicFile" jas="1" runat="server" AllowedFileExtensions=".gif,.jpg,.jpeg,.png,.bmp"
                                                    TargetFolder="~/Files/Notes/" Skin="Vista" MaxFileSize="999999" ControlObjectsVisibility="None" />
                                                <br />
                                                <asp:CheckBox ID="chkDeleteLargePicFile" runat="server" Text="حذف عکس" />
                                            </div>
                                        </td>
                                        <td class="cFieldRight">
                                            <asp:HyperLink rel="lightbox" EnableViewState="false" Target="_blank" runat="server"
                                                ID="hplLargePicFile" />
                                        </td>
                                    </tr>
                                </table>
                            </fieldset>
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
    <asp:HiddenField ID="hfPassword" runat="server" />
</asp:Content>
