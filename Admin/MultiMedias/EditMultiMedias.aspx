<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/Main.master"
    AutoEventWireup="true" Inherits="MultiMedias_EditMultiMedias" Title="MultiMedias"
    CodeBehind="EditMultiMedias.aspx.cs" %>

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
                            <table class="cTblField">
                                <tr>
                                    <td class="cCtrl">
                                        <AKP:ExTextBox ID="txtTitle" jas="1" Width="600" MaxLength="200" runat="server" />
                                    </td>
                                    <td class="cLabel">
                                        <asp:Label ID="lblTitle" runat="server" Text="عنوان:"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div>
                            <table class="cTblField">
                                <tr>
                                    <td class="cCtrl">
                                        <AKP:ExTextBox ID="txtDescription" Width="600" jas="1" CssClass="cMultiLine" TextMode="MultiLine"
                                            runat="server" />
                                    </td>
                                    <td class="cLabel">
                                        <asp:Label ID="lblDescription" runat="server" Text="توضيحات:"></asp:Label>
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
                                                    TargetFolder="~/Files/MultiMedias/" Skin="Vista" MaxFileSize="999999" ControlObjectsVisibility="None" />
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
                        <div>
                            <table class="cTblOneRow">
                                <tr>
                                    <td class="cFieldLeft">
                                        <table class="cTblField">
                                            <tr>
                                                <td class="cCtrl">
                                                    <asp:Label ID="lblCreateDateVal" runat="server" Text=""></asp:Label>
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblCreateDate" runat="server" Text="تاريخ ايجاد:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="cFieldRight">
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
                                                    <AKP:Combo ID="cboHCPicTypeCode" AllowNull="false" jas="1" runat="server" />
                                                </td>
                                                <td class="cLabel">
                                                    <asp:Label ID="lblHCPicTypeCode" runat="server" Text="نوع:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="cFieldRight">
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
        <div class="TabHeaderData">
            <telerik:RadTabStrip Style="margin-right: 8px;" dir="rtl" ID="tsMultiMedias" runat="server"
                MultiPageID="RadMultiPage1" SelectedIndex="0" Skin="Vista" SkinsPath="~/RadControls/TabStrip/Skins">
                <Tabs>
                    <telerik:RadTab ID="Tab1" runat="server" Text="ضمائم تصویری">
                    </telerik:RadTab>
                    
                </Tabs>
            </telerik:RadTabStrip>
            <div class="cTabWrapper">
                <telerik:RadMultiPage ID="RadMultiPage1" SelectedIndex="0" runat="server">
                    <telerik:RadPageView ID="PageView1" runat="server">
                        <div class="cDivSep">
                        </div>
                        <div class="cBrowseArea" id="MultiMediaPictures">
                        </div>
                        <div class="cDivSep">
                        </div>
                        <div class="clear">
                        </div>
                    </telerik:RadPageView>
                    
                </telerik:RadMultiPage>
                <div class="clear">
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
