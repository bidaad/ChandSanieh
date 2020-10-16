<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/InnerPage.Master"
    CodeBehind="ImageGalleryArchive.aspx.cs" Inherits="AceNews.ImageGalleryArchive" %>

<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="InnerPage">
        <asp:DataList ID="rptImageGallery" CssClass="tblImgGalList" RepeatColumns="4" RepeatDirection="Horizontal"
            EnableViewState="false" runat="server">
            <ItemTemplate>
                <asp:HyperLink runat="server" NavigateUrl='<%# "~/News/" + Eval("Code") + ".htm" %>'
                    Target="_blank">
                        <asp:Image runat="server" CssClass="SmallPic" ImageUrl='<%#Eval("PicFile1") %>' AlternateText='<%#Eval("Title") %>'
                            rel="rel1" />
                </asp:HyperLink>
                <span class='orbit-caption'>&nbsp;<%#Eval("Title") %>&nbsp;</span>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <div class="Clear">
    </div>
    <asp:Panel runat="server" ID="pnlPaging">
        <Tlb:pagertoolbar runat="server" id="pgrToolbar" />
    </asp:Panel>
</asp:Content>
