<%@ Page Title="" Language="C#" MasterPageFile="~/WasteRecycling.Master" AutoEventWireup="true" CodeBehind="Login_form.aspx.cs" Inherits="FinalWebApplication.Login_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
<link rel="stylesheet" href="global.css" />
<link rel="stylesheet" href="index.css" />
<link rel="stylesheet" href="registration_form_design.css" />
<link rel="stylesheet" href="web_form_base.css" />
<link rel="stylesheet"
    href="https://fonts.googleapis.com/css2?family=Inter:wght@400&display=swap" />
<link rel="stylesheet"
    href="https://fonts.googleapis.com/css2?family=Montserrat:wght@400;500&display=swap" />
    <h1>Log in to your account on our website!</h1>
    <div class="container">
  <h2>Login Form</h2>
  <form method="post"  runat="server">
    <label for="username">Username:</label>
    <input type="text" id="username" name="username" required>

    <label for="email">Email:</label>
    <input type="email" id="email" name="email" required>

    <input type="submit" name="submit" value="Login">
  </form>
</div>
<h3>
    <%=msg %>
</h3>
</asp:Content>
