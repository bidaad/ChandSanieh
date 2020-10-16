<%@ Page Language="C#" AutoEventWireup="true" Title="آرشیو عکس های خبری" CodeBehind="TextNewsArchive.aspx.cs" MasterPageFile="~/MainRoot.Master" Inherits="AceNews.NewsFolder.TextNewsArchive" %>

<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <div class="MainDataCont">
        <div >
            <asp:Repeater ID="rptItems" runat="server">
                <ItemTemplate>
                    <div class="TextPicNews">
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="SideTitle" Target="_blank"
                        NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" +DataBinder.Eval(Container.DataItem, "Code")  %>'>
                    <%#Eval("Title") %>
                    </asp:HyperLink>
                </div>
                <div class="Clear">
                </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <asp:Panel runat="server" ID="pnlPaging">
        <Tlb:PagerToolbar runat="server" ID="pgrToolbar" />
    </asp:Panel>
</asp:Content>
