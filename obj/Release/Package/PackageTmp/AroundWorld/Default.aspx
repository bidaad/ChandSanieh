<%@ Page Language="C#" AutoEventWireup="true" Title="دور دنیا در چند ثانیه" MasterPageFile="~/MainRoot.Master" CodeBehind="Default.aspx.cs" Inherits="AceNews.HistorPics.Default" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <asp:Panel runat="server" ID="pnlHeader" CssClass="NewsListHeader">
        <div class="HeaderText Photo VMenuItem">
            <asp:Literal ID="ltrHeader" Text="آرشیو دور دنیا در چند ثانیه" runat="server"></asp:Literal>
        </div>
        <div class="Clear">
        </div>
    </asp:Panel>
        <div class="MainDataCont">
        <div >
            <asp:Repeater ID="rptItems" runat="server">
                <ItemTemplate>
                    <div>
                        <div class="AroundWorldTitle">
                            <asp:HyperLink ID="HyperLink1" ToolTip='<%#Eval("Title") %>' CssClass="NewsManHeader"
                        NavigateUrl='<%#"~/AroundWorld/ShowItem.aspx?Code=" + Eval("Code") %>' runat="server">
                                        <%#Eval("Title") %>&nbsp;<%#Tools.ChangeEnc( Eval("CDate")) %>
                    </asp:HyperLink>
                        </div>
                        
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

        <asp:Panel runat="server" ID="pnlPaging">
        <Tlb:PagerToolbar runat="server" ID="pgrToolbar" />
    </asp:Panel>
</asp:Content>