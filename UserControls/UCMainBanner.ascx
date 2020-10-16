<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCMainBanner.ascx.cs" Inherits="AceNews.UserControls.UCMainBanner" %>
<%@ Register Src="~/UserControls/Banner.ascx" TagName="Banner" TagPrefix="UCBan" %>

<div class="BoxNoor1" style="margin-top: 5px;">
    <table style="width: 100%;" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td class="BoxNoor1TopLeft">
            </td>
            <td class="BoxNoor1Top">
            </td>
            <td class="BoxNoor1TopRight">
            </td>
        </tr>
        <tr>
            <td class="BoxNoor1_Left">
            </td>
            <td class="BoxNoor1_Content">
                <table>
                        <tr>
                            <td><UCBan:Banner ID="Banner1" runat="server" PositionCode="1" /> </td>
                            <td><UCBan:Banner ID="Banner2" runat="server" PositionCode="2" /></td>
                        </tr>
                    </table>
                
                <div class="Clear">
                </div>
            </td>
            <td class="BoxNoor1_Right">
            </td>
        </tr>
        <tr>
            <td class="BoxNoor1BotLeft">
            </td>
            <td class="BoxNoor1_Bot">
            </td>
            <td class="BoxNoor1BotRight">
            </td>
        </tr>
    </table>
</div>