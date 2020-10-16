<%@ Page Language="C#" AutoEventWireup="true" Title="آرشیو شاید نخوانده باشید" MasterPageFile="~/MainRoot.Master"
    CodeBehind="Default.aspx.cs" Inherits="AceNews.MayNotReads.Default" %>

<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <div class="MainDataCont">
        <div >
            <asp:Repeater ID="rptItems" runat="server">
                <ItemTemplate>
                    <div>
                        <div class="MayNotReadTitle">
                            <%#Eval("Title")%>
                        </div>
                        <div class="ItemDate">
                            <%#Tools.ChangeEnc( Eval("SDate"))%>
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
