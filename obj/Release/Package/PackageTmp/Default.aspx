<%@ Page Language="C#" MasterPageFile="~/MainRoot.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="AceNews._Default" %>

<%@ Register Src="~/UserControls/UCPicNewsVer.ascx" TagName="UCPicNewsVer" TagPrefix="UCPNV" %>
<%@ Register Src="~/UserControls/UCNewsList.ascx" TagName="NewsList" TagPrefix="UCNewsList" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <div class="MainDataCont">
        
        <div id="PageNews">
            
            <UCNewsList:NewsList id="NewsList1" TimeFormat="TimeAgo" runat="server" />
            
        </div>
        <div class="Clear">
        </div>
    </div>
    <script type="text/javascript" charset="utf-8">
        $(document).ready(function () {


//            $(window).scroll(function () {
//                if ($(window).scrollTop() + $(window).height() == $(document).height()) {
//                    LoadMoreNews();
//                }
//            });

        });
			</script>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CP2">
</asp:Content>
