<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCMultiMedia.ascx.cs"
    Inherits="ASNoor.UserControls.UCMultiMedia" %>
<div>
    <div class="DayPicCaption">
        <asp:Literal ID="ltrHeader" runat="server"></asp:Literal>
    </div>
    <div id="LatestNewspapersBox1">
        <ul class="gallery clearfix"><li>
        <asp:HyperLink ID="hplLargePic" rel="prettyPhoto[gallery1]" runat="server">
            <asp:Image ID="imgPic" CssClass="DayPic" runat="server" />
        </asp:HyperLink>
        </li></ul>
    </div>
    <div class="Farsi Padder5 Justify">
        <asp:Label ID="lblPicTitle" runat="server" Text=""></asp:Label>
    </div>
</div>
