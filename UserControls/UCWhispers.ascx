<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCWhispers.ascx.cs" Inherits="AceNews.UserControls.UCWhispers" %>
<div class="Whispers">
    <div class="HeaderCont">
        <h3 class="Header">
            حرف‌های درگوشی
        </h3>
    </div>
    <div class="WhispersInfoCont">
        <asp:Repeater ID="rptWhispers" runat="server">
            <ItemTemplate>
                <div>
                    <%#Eval("Title") %>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>