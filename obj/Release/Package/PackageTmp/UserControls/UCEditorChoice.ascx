<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCEditorChoice.ascx.cs" Inherits="AceNews.UserControls.UCEditorChoice" %>
<div class="EditorChoice">
    <div class="HeaderCont">
        <h3 class="Header">
            پیشنهاد سردبیر
        </h3>
    </div>
    <div class="MayNotReadsInfoCont">
        <asp:Repeater ID="rptNews" runat="server">
            <ItemTemplate>
                <div>
                    <asp:HyperLink ID="HyperLink1" NavigateUrl=<%#"~/News/ShowNews.aspx?Code=" + Eval("Code") %> runat="server">
                    <%#Eval("Title") %>
                    </asp:HyperLink>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>