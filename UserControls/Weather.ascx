<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_Weather"
    CodeBehind="Weather.ascx.cs" %>
<div class="BlueBox1">
    <div class="Header">
        <h4>وضعیت آب و هوا</h4>
    </div>
    <div class="Content">
        <div class="Inner">
            <%=YahooWeather.Helper.BuildHTML() %>
        </div>
    </div>
</div>
