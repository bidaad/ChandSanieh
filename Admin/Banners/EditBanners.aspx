<%@ Page Language="C#" StylesheetTheme="Edit" ValidateRequest="false" MasterPageFile="~/Admin/Main.master"
    AutoEventWireup="True" Inherits="Banners_EditBanners" Title="Banners" CodeBehind="EditBanners.aspx.cs" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    <div class="cTblEdit">
        <div style="width: 700px; float: right; text-align: right; color: White;">
            <asp:Label runat="server" ID="lblSysName"></asp:Label></div>
        <div class="cTDEdit">
            <div class="cEditRight">
                <div class="cEditMain">
                    <div class="cEditMainData">
                        <div>
                            <div>
                                <AKP:MsgBox ID="msgBox" runat="server" CssClass="cError" />
                            </div>
                            <div class="UploaderContainer">
                                <fieldset style="direction: rtl">
                                    <legend>&nbsp;<asp:Label runat="server" Text="فایل" ID="lblBanFile" />&nbsp;</legend>
                                    <div>
                                        <table class="cTblOneRow2">
                                            <tr>
                                                <td class="cFieldLeft2">
                                                    <AKP:ExRadUpload ID="uplBanFile" jas="1" AutoSave="false" runat="server" AllowedFileExtensions=".gif,.jpg,.jpeg,.png,.bmp,.swf"
                                                        TargetFolder="~/Files/Banners/" Skin="Vista" MaxFileSize="99990000" ControlObjectsVisibility="None" />
                                                    <br />
                                                    <asp:CheckBox ID="chkDeleteBanFile" runat="server" Text="حذف فایل" />
                                                </td>
                                                <td class="cFieldRight2">
                                                    <div class="cPic">
                                                        <asp:HyperLink rel="lightbox" EnableViewState="false" Target="_blank" runat="server"
                                                            ID="hplBanFile" />
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </fieldset>
                            </div>
                            <div class="clear"></div>
                            <div>
                                <table class="cTblOneRow">
                                    <tr>
                                        <td class="cFieldLeft">
                                            <table class="cTblField">
                                                <tr>
                                                    <td class="cCtrl">
                                                        http://<AKP:ExTextBox ID="txtTargetUrl" SkinID="English" jas="1" MaxLength="200"
                                                            runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblTargetUrl" runat="server" Text="آدرس :"></asp:Label>
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
                                                        <AKP:ExTextBox ID="txtKeywords" jas="1" CssClass="cMultiLine" TextMode="MultiLine"
                                                            MaxLength="1000" runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblKeywords" runat="server" Text="کلمات کلیدی:"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td class="cFieldRight">
                                            <table class="cTblField">
                                                <tr>
                                                    <td class="cCtrl">
                                                        <AKP:ExTextBox ID="txtText" jas="1" CssClass="cMultiLine" TextMode="MultiLine" MaxLength="1000"
                                                            runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblText" runat="server" Text="متن:"></asp:Label>
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
                                                        <AKP:Combo ID="cboPositionCode" jas="1" runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblPositionCode" runat="server" Text="مکان نمایش:"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td class="cFieldRight">
                                            <table class="cTblField">
                                                <tr>
                                                    <td class="cCtrl">
                                                        <AKP:Combo ID="cboHCTypeCode" AllowNull="false" jas="1" BaseID="HCBannerTypes" runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblHCTypeCode" runat="server" Text="نوع:"></asp:Label>
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
                                                        <AKP:NumericTextBox ID="txtViewNum" jas="1" NumericType="IntType" runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblViewNum" runat="server" Text="تعداد نمایش:"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td class="cFieldRight">
                                            <table class="cTblField">
                                                <tr>
                                                    <td class="cCtrl">
                                                        <AKP:NumericTextBox ID="txtClickNum" jas="1" NumericType="IntType" runat="server" />
                                                    </td>
                                                    <td class="cLabel">
                                                        <asp:Label ID="lblClickNum" runat="server" Text="تعداد کلیک:"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="cHorSep">
        </div>
        <div class="clear">
        </div>
        <div style="text-align: right">
            <table class="tblEditButtons" cellpadding="2" cellspacing="4">
                <tr>
                    <td>
                        <a class="BlueButton" onclick="ChangeLang()">فارسی </a>
                    </td>
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
