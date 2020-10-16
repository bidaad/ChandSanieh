<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/EditPopup.master"
    AutoEventWireup="true" Codebehind="EditMultiMediaPictures.aspx.cs" Inherits="MultiMediaPictures_EditMultiMediaPictures"
    Title="MultiMediaPictures" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    <table cellpadding="0" cellspacing="0" align="center" width="100%">
        <tr>
            <td>
                <table cellpadding="0" cellspacing="0" width="90%" class="cMainEditTable">
                    <tr>
                        <td>
                            <AKP:MsgBox ID="msgBox" runat="server" CssClass="cError" />
                        </td>
                    </tr>
                    <div>
                        <table class="cTblOneRow">
                            <tr>
                                <td>
                                    <table class="cTblField">
                                        <tr>
                                            <td class="cCtrl">
                                                <AKP:ExTextBox ID="txtTitle" jas="1" Width="475" MaxLength="1000" runat="server" />
                                            </td>
                                            <td class="cLabel">
                                                <asp:Label ID="lblSoTitr" runat="server" Text="عنوان:"></asp:Label>
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
                                                TargetFolder="~/Files/MultiMedias/" Skin="Vista" MaxFileSize="99990000" ControlObjectsVisibility="None" />
                                            <br />
                                            <asp:CheckBox ID="chkDeletePicFile" runat="server" Text="حذف فایل" />
                                        </td>
                                        <td class="cFieldRight2">
                                            <div class="cPic">
                                                <asp:HyperLink rel="lightbox" EnableViewState="false" Target="_blank" runat="server"
                                                    ID="hplPicFile" />
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </fieldset>
                    </div>
                </table>
            </td>
        </tr>
        <tr>
            <td align="right" class="cPopupToolbar">
                <table cellpadding="5" align="right" border="0" cellspacing="2">
                    <tr>
                        <td>
                            <asp:ImageButton ID="imgBtnBack" SkinID="BackButton" runat="server" OnClientClick="window.close()" />
                        </td>
                        <td class="cVerBar1">
                        </td>
                        
                        <td>
                            <asp:ImageButton ID="imgBtnSave" SkinID="SaveButton" runat="server" OnClick="DoSave" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
