﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCComments.ascx.cs"
    Inherits="AceNews.UserControls.UCComments" %>
<div class="NewsCommentContainer hidden-sm hidden-xs">
    <div class="NewsComments">
        <div class="CommentFooter">
            <div class="FooterLabel">
                <asp:Literal ID="ltrTitle" runat="server">نظرات</asp:Literal>
            </div>
        </div>
        <asp:Panel ID="PublishInfo" runat="server" CssClass="CommentHeader">
            <div class="MainLabel">
                
            </div>
            <div class="PublishedCount">
                <asp:Label ID="lblPublishedCount" runat="server" Text=""></asp:Label>
            </div>
            <div class="WillNotBePublishedCount">
                <asp:Label ID="lblWillNotBePublishedCount" runat="server" Text=""></asp:Label>
            </div>
        </asp:Panel>
        <div class="Clear"></div>
        <div>
            <asp:Repeater ID="rptComments" runat="server">
                <ItemTemplate>
                    <div class="CommentReplyHeader">
                        <div class="Name">
                            <%#Eval("Name") %>
                        </div>
                        <div class="SendDate">
                            <%#Eval("SDate") %>
                        </div>
                    </div>
                    <div class="Clear"></div>
                    <div class="Comment">
                        <img alt="" src="/images/site/comments.gif" style="padding-left: 3px;">
                        <%#Eval("TextComment") %>
                    </div>
                    <div class="Clear"></div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div style="margin-top: 5px;">
                        <AKP:MsgBox runat="server" ID="msgBox">
                        </AKP:MsgBox>
                    </div>
                    <div class="tblComment">
                        <div>
                            <div class="col-lg-6 col-sm-12 col-xs-12">
                                <AKP:ExTextBox ID="txtComment" Text="نظر" style="text-align:right;" onclick="this.className='input-text'; this.value='';" onblur="this.className='GrayText';if(this.value == '') this.value= 'نظر';" CssClass="CommentText" TextMode="MultiLine" Width="100%"
                                    Height="200" runat="server"></AKP:ExTextBox>
                            </div>
                            <div class="col-lg-6 col-sm-12 col-xs-12">
                                <div class="TextContainer">
                                    <AKP:ExTextBox ID="txtName" Text="نام" onclick="this.className='input-text';this.value='';" onblur="if(this.value == '') this.value= 'نام';" Width="220" CssClass="CommentText" runat="server"></AKP:ExTextBox>
                                </div>
                                <div class="TextContainer">
                                    <AKP:ExTextBox ID="txtEmail" Width="220" onclick="this.className='input-text';this.value='';" Text="ایمیل" style="text-align:right;" onblur="if(this.value == '') this.value= 'ایمیل';" SkinID="English"  CssClass="CommentText" runat="server"></AKP:ExTextBox>
                                </div>
                                <div class="TextContainer">
                                    <asp:Label ID="lblCaptcha" runat="server" Text="کد امنیتی را وارد کنید"></asp:Label>
                                </div>
                                <div>
                                    <telerik:RadCaptcha ID="RadCaptcha1" ValidationGroup="SendComment" CssClass="Capt"
                                        Width="200" CaptchaImage-ImageCssClass="CaptImg" CaptchaTextBoxCssClass="CaptText"
                                        runat="server" ErrorMessage="" CaptchaTextBoxLabel="">
                                    </telerik:RadCaptcha>
                                </div>
                                <div class="btnSendCommentCont">
                                    <asp:ImageButton ImageUrl="~/images/btnUCSendComment.png"  ValidationGroup="SendComment" ID="btnSendComment" CssClass="btnSendComment" Text="ارسال" 
                                        runat="server" OnClick="btnSendComment_Click"></asp:ImageButton>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="Clear"></div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</div>
