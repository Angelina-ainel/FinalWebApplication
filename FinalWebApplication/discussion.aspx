<%@ Page Title="" Language="C#" MasterPageFile="~/WasteRecycling.Master" AutoEventWireup="true" CodeBehind="discussion.aspx.cs" Inherits="FinalWebApplication.discussion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
<link rel="stylesheet" href="./global.css" />
<link rel="stylesheet" href="./index.css" />
<link rel="stylesheet" href="./web_form_base.css" />
<link
  rel="stylesheet"
  href="https://fonts.googleapis.com/css2?family=Inter:wght@400&display=swap"
/>
<link
  rel="stylesheet"
  href="https://fonts.googleapis.com/css2?family=Montserrat:wght@400;500&display=swap"
/>
    <script src="Calculator.js" defer></script>
    <h1>Math Calculator</h1>
<section>
    <div class="calculator-container">

    <form id="calculator-form">
        <div class="calc-row">
            <input type="number" id="add1" readonly>
            <span>+</span>
            <input type="number" id="add2" readonly>
            <span>=</span>
            <input type="number" id="addResult" placeholder="Result">
            <span id="addCheck"></span>
        </div>
        <div class="calc-row">
            <input type="number" id="sub1" readonly>
            <span>-</span>
            <input type="number" id="sub2" readonly>
            <span>=</span>
            <input type="number" id="subResult" placeholder="Result">
            <span id="subCheck"></span>
        </div>
        <div class="calc-row">
            <input type="number" id="mul1" readonly>
            <span>*</span>
            <input type="number" id="mul2" readonly>
            <span>=</span>
            <input type="number" id="mulResult" placeholder="Result">
            <span id="mulCheck"></span>
        </div>
        <div class="calc-row">
            <input type="number" id="div1" readonly>
            <span>/</span>
            <input type="number" id="div2" readonly>
            <span>=</span>
            <input type="number" id="divResult" placeholder="Result">
            <span id="divCheck"></span>
        </div>
        <button type="button" onclick="checkResults()">Check Results</button>
    </form>
    </div>
</section>
</asp:Content>
