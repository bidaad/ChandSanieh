<%@ Control Language="C#" AutoEventWireup="True" Inherits="AceNews.Web.UI.UserControls.NewsList"
    CodeBehind="UCNewsList.ascx.cs" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<div class="Padder551">
    <asp:Panel runat="server" ID="pnlHeader" CssClass="NewsListHeader">
        <div class="HeaderArchive">
            <asp:HyperLink ID="HyperLink1" CssClass="Farsi" NavigateUrl="~/News/Archive.aspx"
                runat="server">آرشیو</asp:HyperLink>
        </div>
        <div class="HeaderText <%=CaptionClass %> VMenuItem">
            <asp:Literal ID="ltrHeader" Text="آخرین اخبار" runat="server"></asp:Literal>
        </div>
        <div class="Clear">
        </div>
    </asp:Panel>
    <div class="Clear">
    </div>
    <div class="NewsList">
        <ul class="gallery clearfix">
            <asp:Repeater ID="rptNewsList" EnableViewState="false" runat="server">
                <ItemTemplate>
                    <li>
                        <div id="News<%#Eval("Code") %>" class="cNewsItem">
                            <div class="ItemLeft">
                                <%--<div class="CommentTools">
                                    <ul class="CTMenu">
                                        <li>
                                            <div class="LaodingArea" id="Loading<%#Eval("Code") %>">
                                            </div>
                                        </li>
                                        <li>
                                            <div class="ViewComment" onclick="GetNewsComment('<%#Eval("Code") %>', 'Loading<%#Eval("Code") %>', 'CommentArea<%#Eval("Code") %>')">
                                            </div>
                                        </li>
                                        
                                        <li>
                                            
                                            <div class="LikeIcon" onclick="SendLike('<%#Eval("Code") %>', 'Loading<%#Eval("Code") %>')">
                                                <span id="Like<%#Eval("Code") %>"><%#GetLikeCount( Eval("Code")) %></span>
                                            </div>
                                        </li>
                                    </ul>
                                </div>--%>
                                <div class="Title">
                                    <asp:HyperLink runat="server" CssClass="cTitle" Target="_blank" ToolTip='<%#DataBinder.Eval(Container.DataItem, "Title") + " " + FormatDateTime( Eval("NewsDate"))  %>'
                                        NavigateUrl='<%#"~/News/ShowNews.aspx?Code=" +DataBinder.Eval(Container.DataItem, "Code")  %>'><%#ShowAbstract(Eval("Code"), Eval("Title"), 400)%></asp:HyperLink>
                                    <%--&nbsp;<span class="NewsTime">
                                        <%#PersianDate(Eval("CreateDate"))%></span>--%>
                                </div>
                                <asp:Panel Visible=<%#IsNotArchive() %> runat="server" CssClass="Abstract">
                                    <%#ShowAbstract(Eval("Code"),  Eval("Abstract"), 1000) %>
                                </asp:Panel>
                            </div>
                            <asp:Panel Visible=<%#IsNotArchive() %> runat="server" class="ItemRight">
                                <div class="SmallPicCont">
                                    <a href="<%#Eval("PicFile2") %>" rel="prettyPhoto[gallery2]" title="">
                                        <div class="NewsPicCont" >
                                            <asp:Image runat="server" ImageUrl='<%#Eval("PicFile1") %>'  />
                                        </div>
                                    </a>
                                </div>
                            </asp:Panel>
                            <div class="Clear">
                            </div>
                        </div>
                        <div class="Hidden CommentArea" id="CommentArea<%#Eval("Code") %>">
                        </div>
                        <div class="Hidden CommentSendForm" id="SendForm<%#Eval("Code") %>">
                        </div>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
        <div id="LoadMoreArea<%=PageNo%>">
        </div>
        <AKP:MsgBox runat="server" ID="msgInfo" />
    </div>
</div>
<asp:Panel runat="server" ID="pnlPaging">
    <Tlb:PagerToolbar runat="server" ID="pgrToolbar" />
</asp:Panel>
<div id="CommentSendForm" class="Hidden CommentSendForm">
    <table class="tblComment">
        <tr>
            <td style="padding-right: 30px;">
                <div class="CommentFormLabel">
                    نظر
                </div>
                <textarea id="txtComment" rows="5" cols="100" text="نظر" style="text-align: right;"
                    onclick="this.className='input-text'; this.value='';" onblur="this.className='GrayText';if(this.value == '') this.value= 'نظر';"
                    class="CommentText" width="350" height="200"></textarea>
            </td>
            <td>
                <div class="CommentFormLabel">
                    نام
                </div>
                <div class="TextContainer">
                    <input id="txtName" text="نام" onclick="this.className='input-text';this.value='';"
                        onblur="if(this.value == '') this.value= 'نام';" width="220" class="CommentText" />
                </div>
                <div class="CommentFormLabel">
                    ایمیل
                </div>
                <div class="TextContainer">
                    <input id="txtEmail" width="220" onclick="this.className='input-text';this.value='';"
                        title="ایمیل" style="text-align: right;" onblur="if(this.value == '') this.value= 'ایمیل';"
                        skinid="English" class="CommentText" />
                </div>
                <div style="text-align: right;">
                    <div class="divSendButton" id="btnSendComment" />
                </div>
            </td>
        </tr>
    </table>
</div>
