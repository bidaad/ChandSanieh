<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin/Main.master"
    CodeBehind="NewsPriorities.aspx.cs" Inherits="AceNews.Admin.News.NewsPriorities" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    <div class="cTblEdit">
        <div style="width: 700px; float: right; text-align: right; color: White;">
            <asp:Label runat="server" Text="تغییر اولویت اخبار" ID="lblSysName"></asp:Label></div>
        <div class="cTDEdit">
            <div class="cEditRight">
                <div class="cEditMain">
                    <div class="cEditMainData">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div>
                                    <AKP:MsgBox ID="msgBox" runat="server" CssClass="cError" />
                                </div>
                                <div style="text-align: center;border:solid 1px #DDDDDD;background-color:#EEEEEE;">
                                    <table class="tblNewsPrio">
                                        <tr>
                                            <td>
                                                <AKP:FarsiDate runat="server" ID="dteToDate" />
                                            </td>
                                            <td class="lbl">
                                                <asp:Label ID="Label2" runat="server" Text="تا تاریخ:"></asp:Label>
                                            </td>
                                            <td>
                                                <AKP:FarsiDate runat="server" ID="dteFromDate" />
                                            </td>
                                            <td class="lbl">
                                                <asp:Label ID="Label1" runat="server" Text="از تاریخ:"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <AKP:ExRadNumericTextBox runat="server" Width="80" Height="10" ID="txtToNewsNo" />
                                            </td>
                                            <td class="lbl">
                                                <asp:Label ID="Label3" runat="server" Text="تا شماره خبر:"></asp:Label>
                                            </td>
                                            <td>
                                                <AKP:ExRadNumericTextBox runat="server" Width="80" Height="10" ID="txtFromNewsno" />
                                            </td>
                                            <td class="lbl">
                                                <asp:Label ID="Label4" runat="server" Text="از شماره خبر:"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBoxList ID="chkListSearchType" CssClass="tblSearchType" RepeatDirection="Horizontal"
                                                    runat="server">
                                                    <asp:ListItem Text="متن" Value="2"></asp:ListItem>
                                                    <asp:ListItem Text="عنوان" Selected="True" Value="1"></asp:ListItem>
                                                </asp:CheckBoxList>
                                            </td>
                                            <td class="lbl">
                                                <asp:Label ID="Label5" runat="server" Text="جستجو در:"></asp:Label>
                                            </td>
                                            <td>
                                                <AKP:ExTextBox runat="server" Width="80" Height="10" ID="txtKeyword" />
                                            </td>
                                            <td class="lbl">
                                                <asp:Label ID="Label6" runat="server" Text="کلمه جستجو:"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="4">
                                                <asp:Button ID="btnSearch" Width="100" Height="30" runat="server" Text="جستجو" OnClick="btnSearch_Click">
                                                </asp:Button>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div class="clear">
                                </div>
                                <asp:Panel runat="server" ID="pnlSelectedNews" Visible="false">
                                    <div class="BlueHeader">
                                        <div>
                                        نتایج جستجو
                                        </div>
                                    </div>
                                    <div class="SelectedNewsList">
                                        <asp:Repeater ID="rptSelectedNews" OnItemCommand="HandleRepeaterCommand" runat="server">
                                            <ItemTemplate>
                                                <asp:Panel runat="server" CssClass="UnSelectedDrag" ID="pnlTitle">
                                                    <div>
                                                        <asp:LinkButton runat="server" ID="btnNews" CommandName="SelectForDrop" NewsCode='<%#Eval("Code")%>'
                                                            Text='<%#Eval("Title")%>'></asp:LinkButton></div>
                                                </asp:Panel>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                    <div style="text-align: center;">
                                        <table style="text-align: center;">
                                            <tr>
                                                <td>
                                                    <div>
                                                        <asp:Button ID="btnRemoveFromSelected" CssClass="UpArrow" Visible="false" runat="server" OnClick="btnRemoveFromSelected_Click" /></div>
                                                </td>
                                                <td>
                                                    <div>
                                                        <asp:Button ID="btnMoveToSelected" CssClass="DownArrow" Visible="false" runat="server" OnClick="btnMoveToSelected_Click" /></div>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </asp:Panel>
                                <div class="BlueHeader">
                                        <div>
                                        بیست خبر آخر
                                        </div>
                                    </div>
                                <div style="text-align: center;">
                                    <table class="tbChangePrio">
                                        <tr>
                                            <td>
                                                <div>
                                                    <asp:Button ID="btnUp" CssClass="UpArrow" runat="server" OnClick="btnUp_Click" /></div>
                                                <div style="height: 10px;">
                                                </div>
                                                <div>
                                                    <asp:Button ID="btnDown" CssClass="DownArrow" runat="server" OnClick="btnDown_Click" /></div>
                                            </td>
                                            <td style="padding: 6px;">
                                                <div class="SimpleNewsList">
                                                    <asp:Repeater ID="rptLatestNews" OnItemCommand="HandleRepeaterCommand" runat="server">
                                                        <ItemTemplate>
                                                            <asp:Panel runat="server" CssClass="UnSelected" ID="pnlTitle">
                                                                <div>
                                                                    <asp:LinkButton runat="server" ID="btnNews" CommandName="SelectNews" NewsCode='<%#Eval("Code")%>'
                                                                        Text='<%#Eval("Title")%>'></asp:LinkButton></div>
                                                            </asp:Panel>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
        <div class="cHorSep">
        </div>
    </div>
</asp:Content>
