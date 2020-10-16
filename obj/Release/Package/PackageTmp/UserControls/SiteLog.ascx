<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_SiteLog"
    CodeBehind="SiteLog.ascx.cs" %>
<div class="GrayBox1">
    <div class="GrayBox1Top">
    </div>
    <div class="GrayBox1Content">
        <div class="GrayBox1ContentInner">
            <div class="GrayBox1Inner">
                <div class="StatCaption">
                </div>
                <div style="padding: 4px;">
                    <div class="Statistic">
                        <div class="Left">
                        </div>
                        <div class="Right">
                            <div>
                                <asp:Label ID="lblTodayVisitLabel" runat="server" Text="بازدید امروز"></asp:Label>
                                :&nbsp;<asp:Label ID="lblTodayVisit" runat="server" Text=""></asp:Label>
                            </div>
                            <div>
                                <asp:Label ID="lblYesterdayVisitLabel" runat="server" Text="بازدید دیروز"></asp:Label>
                                :&nbsp;<asp:Label ID="lblYesterdayVisit" runat="server" Text=""></asp:Label>
                            </div>
                            <div>
                                <asp:Label ID="lblTotalVisitLabel" runat="server" Text="بازدید کل"></asp:Label>
                                :&nbsp;<asp:Label ID="lblTotalVisit" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="GrayBox1Bot">
    </div>
</div>
