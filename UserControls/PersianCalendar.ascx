<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_PersianCalendar"
    CodeBehind="PersianCalendar.ascx.cs" %>
<div class="CalBox">
    <fieldset >
        <div class="cDateHeader">
            <asp:Label ID="lblHeader" runat="server"></asp:Label></div>
        <div class="CalData">
            <table class="ctblDateHeader">
                <tr>
                    <td>
                        ش
                    </td>
                    <td>
                        ی
                    </td>
                    <td>
                        د
                    </td>
                    <td>
                        س
                    </td>
                    <td>
                        چ
                    </td>
                    <td>
                        پ
                    </td>
                    <td>
                        ج
                    </td>
                </tr>
            </table>
            <asp:DataList runat="server" EnableViewState="false" CssClass="ctblDate" ID="dtlDays"
                RepeatColumns="7" RepeatDirection="Horizontal">
                <ItemTemplate><%#ShowDay(DataBinder.Eval(Container.DataItem, "Day"))%></ItemTemplate>
            </asp:DataList>
        </div>
    </fieldset>
</div>
