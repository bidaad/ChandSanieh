<%@ Page Language="C#" MasterPageFile="~/MainRoot.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="AceNews.AboutUs" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    
    <div class="Padder20">
    <asp:Panel runat="server" ID="pnlHeader" CssClass="NewsListHeader">
        <div class="HeaderText">
            <asp:Literal ID="ltrHeader" Text="درباره ما" runat="server"></asp:Literal>
        </div>
        <div class="Clear">
        </div>
    </asp:Panel>
    
    <div class="Clear">
    </div>
    <div class="Farsi Padder10" >
        صاحب امتیاز و مدیر مسول: اکرم ذبیحیان<br />

آدرس:خیابان برادران باباخانلو-کوچه وهمنی_ پلاک 5-واحد10<br />
تلفن:77631444
        
    </div>
</div>
    

</asp:Content>