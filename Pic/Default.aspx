<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MainRoot.Master"
    Title="چند فریم عکس" CodeBehind="Default.aspx.cs" Inherits="AceNews.Pic.Default" %>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <asp:Panel runat="server" ID="pnlHeader" CssClass="NewsListHeader">
        <div class="HeaderText Photo VMenuItem">
            <asp:Literal ID="ltrHeader" Text="چند فریم عکس" runat="server"></asp:Literal>
        </div>
        <div class="Clear">
        </div>
    </asp:Panel>
    <div class="MainDataCont">
        <fieldset class="FSPicAttachs">
            <asp:Repeater ID="rptPics" EnableViewState="false" runat="server">
                <HeaderTemplate>
                    <ul class="Picgallery clearfix">
                </HeaderTemplate>
                <ItemTemplate>
                    <li>
                        <div class="PicFrameItem">
                            <div>
                                <a href="<%#".." + GetFile(Eval("LargePicFile"))  %>" rel="prettyPhoto[gallery2]"
                                    title="">
                                    <img src="<%#".." + GetFile(Eval("PicFile")) %>" height="80"
                                        alt="" /></a>
                            </div>
                            <div class="Title">
                                <%#Eval("Title") %></div>
                        </div>
                    </li>
                </ItemTemplate>
                <FooterTemplate>
                    </ul></FooterTemplate>
            </asp:Repeater>
        </fieldset>
        <script type="text/javascript" charset="utf-8">
            $(document).ready(function () {
                $("area[rel^='prettyPhoto']").prettyPhoto();

                $(".Picgallery:first a[rel^='prettyPhoto']").prettyPhoto({ animation_speed: 'normal', theme: 'light_square', slideshow: 3000, autoplay_slideshow: false });
                $(".Picgallery:gt(0) a[rel^='prettyPhoto']").prettyPhoto({ animation_speed: 'fast', slideshow: 10000, hideflash: true });

                $("#custom_content a[rel^='prettyPhoto']:first").prettyPhoto({
                    custom_markup: '<div id="map_canvas" style="width:260px; height:265px"></div>',
                    changepicturecallback: function () { initialize(); }
                });


            });
        </script>
    </div>
</asp:Content>
