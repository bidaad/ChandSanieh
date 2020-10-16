<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MainRoot.Master" Title="آرشیو نکته ها" CodeBehind="Default.aspx.cs" Inherits="AceNews.Notes.Default" %>

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
                        <div class="Farsi Padder10">
                            <%#Eval("Description")%>
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