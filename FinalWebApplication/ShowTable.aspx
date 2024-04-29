<%@ Page Title="" Language="C#" MasterPageFile="~/WasteRecycling.Master" AutoEventWireup="true" CodeBehind="ShowTable.aspx.cs" Inherits="FinalWebApplication.ShowTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
<link rel="stylesheet" href="./global.css" />
<link rel="stylesheet" href="./index.css" />
<link
    rel="stylesheet"
    href="https://fonts.googleapis.com/css2?family=Inter:wght@400&display=swap"
/>
<link
    rel="stylesheet"
    href="https://fonts.googleapis.com/css2?family=Montserrat:wght@400;500&display=swap"
/>

<h1>  ... </h1>
<h2 class="headings" padding-top="200px"> <%= sqlSelect %></h2>
<table class="user-table" border="1">
    <%=st %>
</table>
<h3> <%=msg %></h3>
</asp:Content>
