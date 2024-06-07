<%@ Page Title="" Language="C#" MasterPageFile="~/WasteRecycling.Master" AutoEventWireup="true" CodeBehind="Registration_form.aspx.cs" Inherits="FinalWebApplication.Registration_form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <link rel="stylesheet" href="global.css" />
    <link rel="stylesheet" href="index.css" />
    <link rel="stylesheet" href="registration_form_design.css" />
    <link rel="stylesheet" href="web_form_base.css" />
    <link
        rel="stylesheet"
        href="https://fonts.googleapis.com/css2?family=Inter:wght@400&display=swap" />
    <link
        rel="stylesheet"
        href="https://fonts.googleapis.com/css2?family=Montserrat:wght@400;500&display=swap" />
    <script src="JavaScript_registration.js"></script>
    <h1>Become a part of our community of responsible people! Register now on our website </h1>
    <div class="validation-message">
        <span id="invUsername"></span>
        <span id="invFirstName"></span>
        <span id="invLastName"></span>
        <span id="invPhone"></span>
    </div>
    <div class="container">
        <h2> Registration </h2>
        <form method="post" runat="server" onsubmit="return checkForm();">
            <label for="username">Username: <span aria-label="required">*</span></label>
            <input type="text" id="username" name="username" required>

            <label for="firstName">First Name:</label>
            <input type="text" id="firstName" name="firstName" required>

            <label for="lastName">Last Name:</label>
            <input type="text" id="lastName" name="lastName" required>

            <label for="email">Email:</label>
            <input type="email" id="email" name="email" required>

            <label for="birthYear">Year of Birth:</label>
            <input type="number" id="birthYear" name="birthYear" min="1900" max="2024" required>

            <label for="gender">Gender:</label>
            <select id="gender" name="gender" required>
                <option value="">Select Gender</option>
                <option value="male">Male</option>
                <option value="female">Female</option>
                <option value="other">Other</option>
            </select>

            <div class="phone-prefix-container">
                <label for="phonePrefix" class="phone-prefix-label">Phone Prefix:</label>
                <select id="phonePrefix" name="phonePrefix" class="phone-prefix-select">
                    <option value="50">050</option>
                    <option value="51">051</option>
                    <option value="52">052</option>
                    <option value="53">053</option>
                    <option value="54">054</option>
                    <option value="55">055</option>
                    <option value="56">056</option>
                    <option value="57">057</option>
                    <option value="58">058</option>
                    <option value="59">059</option>
                    <option value="60">060</option>
                </select>
            </div>

            <label for="phone">Phone:</label>
            <input type="text" id="phone" name="phone" required>

            <label for="hobby1">Hobby 1:</label>
            <input type="text" id="hobby1" name="hobby1">

            <label for="hobby2">Hobby 2:</label>
            <input type="text" id="hobby2" name="hobby2">

            <label for="hobby3">Hobby 3:</label>
            <input type="text" id="" name="hobby3">

            <label for="hobby4">Hobby 4:</label>
            <input type="text" id="hobby4" name="hobby4">

            <label for="city">City:</label>
            <input type="text" id="city" name="city" required>

            <label>Having Domestic Pets:</label>
            <div class="radio-container">
                <input type="radio" id="petsYes" name="pets" value="yes" required>
                <label for="petsYes">Yes</label>
                <input type="radio" id="petsNo" name="pets" value="no" required>
                <label for="petsNo">No</label>
            </div>

            <input type="submit" name="submit" value="Submit">
        </form>
    </div>
    <table class="user-table">
        <%=st %>
    </table>

</asp:Content>
