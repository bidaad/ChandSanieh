<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCNewsByType.ascx.cs"
    Inherits="AceNews.UserControls.UCNewsByType" %>
<div class="MayNotReads">
    <div class="HeaderCont">
        <h3 class="Header">
            <asp:HyperLink ID="hplArchive"  runat="server">
                <asp:Literal ID="ltrHeader" runat="server"></asp:Literal>
            </asp:HyperLink>
        </h3>
    </div>
    <div class="">
        <asp:Repeater ID="rptNews" runat="server">
            <ItemTemplate>
                <div class="SmallNews">
                    <div >
                        <asp:HyperLink runat="server" CssClass="SideTitle" Target="_blank" NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" +DataBinder.Eval(Container.DataItem, "Code")  %>'>
                    <%#Eval("Title") %>
                        </asp:HyperLink>
                    </div>
                    
                    <div class="Clear"></div>
                </div>
                
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
