<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/Main.master"
    AutoEventWireup="true" Inherits="DayPhotos_EditDayPhotos" Title="DayPhotos" CodeBehind="EditDayPhotos.aspx.cs" %>

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
                                                    <AKP:ExTextBox ID="txtTitle" jas="1" Width="200"  MaxLength="500"
                                                        runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblTitle" runat="server" Text="عنوان:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="cFieldRight">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <AKP:FarsiDate ID="dteDayDate" jas="1" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblDayDate" runat="server" Text="تاريخ ايجاد:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="UploaderContainer">
                            <fieldset style="direction: rtl">
                                <legend>&nbsp;<asp:Label runat="server" Text="عکس" ID="lblPicFile" />&nbsp;</legend>
                                <div>
                                    <table class="cTblOneRow2">
                                        <tr>
                                            <td class="cFieldLeft2">
                                                <AKP:ExRadUpload ID="uplPicFile" jas="1" AutoSave="false" runat="server" AllowedFileExtensions=".gif,.jpg,.jpeg,.png,.bmp"
                                                    TargetFolder="~/Files/DayPhotos/" Skin="Vista" MaxFileSize="99990000" ControlObjectsVisibility="None" />
                                                <br />
                                                <asp:CheckBox ID="chkDeletePicFile" runat="server" Text="حذف فایل" />
                                            </td>
                                            <td class="cFieldRight2">
                                                <div class="cPic">
                                                    <asp:HyperLink rel="lightbox" Target="_blank" runat="server" ID="hplPicFile" />
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
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
