<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCGalleries.ascx.cs" Inherits="AceNews.UserControls.UCGalleries" %>
<div class="">
    <div class="MultimediaCaption">
    </div>
    <div id="LatestGalleryBox">
        <ul>
            <asp:Repeater ID="rptGalleries" runat="server">
                <ItemTemplate>
                    <li>
                        <div class="LatestGalleries">
                            <asp:HyperLink Target="_blank" ToolTip='<%#Eval("Title") %>' rel="prettyPhoto" CssClass="NewsManHeader"
                                NavigateUrl='<%#"~/Galleries/ShowGallery.aspx?Code=" + Eval("Code") %>' runat="server">
                                            <%#Eval("Title") %>
                            </asp:HyperLink>
                        </div>
                    </li>
                    
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>

</div>
<br class="clearfloat" />
