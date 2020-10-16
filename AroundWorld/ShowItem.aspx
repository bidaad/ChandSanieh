<%@ Page Language="C#" AutoEventWireup="true" Title="دور دنیا در چند ثانیه" MasterPageFile="~/MainRoot.Master" CodeBehind="ShowItem.aspx.cs" Inherits="AceNews.AroundWorld.ShowItem" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <asp:Panel runat="server" ID="pnlHeader" CssClass="NewsListHeader">
        <div class="HeaderText Photo VMenuItem">
            <asp:Literal ID="ltrHeader" Text="دور دنیا در چند ثانیه" runat="server"></asp:Literal>
        </div>
        <div class="Clear">
        </div>
    </asp:Panel>
    <div class="Farsi Padder5">
        <asp:Literal ID="ltrTitle" runat="server"></asp:Literal>
    </div>
    <div class="Farsi Justify Padder5">
        <asp:Literal ID="ltrDescription" runat="server"></asp:Literal>
    </div>
    <div>
        <asp:Image ID="imgPic" runat="server" />
    </div>
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
                                <a href="<%#".." + Eval("PicFile").ToString().Replace("//", "/") %>" rel="prettyPhoto[gallery2]"
                                    title="">
                                    <img src="<%#".." + Eval("PicFile").ToString().Replace("//", "/") %>" height="80"
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