<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MainRoot.Master" CodeBehind="ShowGallery.aspx.cs" Inherits="AceNews.Galleries.ShowGallery" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">

    <div class="InnerHome">
        <div class="InnerPage">
            <div class="FullNewsBox">
                <div class="FullNewsTitle RTL Marginer3">
                    <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>

                </div>

                <div>
                <video width="400" controls>
                    <source src="<%=MediaFile%>" type="video/mp4">
                    <source src="mov_bbb.ogg" type="video/ogg">
                    Your browser does not support HTML5 video.
                </video>
                    </div>

            </div>
        </div>
        <div class="Clear">
        </div>


    </div>
    <div class="Clear">
    </div>

</asp:Content>
