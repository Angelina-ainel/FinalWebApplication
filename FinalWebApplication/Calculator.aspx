<%@ Page Title="" Language="C#" MasterPageFile="~/WasteRecycling.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="FinalWebApplication.Calculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1> Calculator </h1>
    <div style="display:flex; flex-direction: row; justify-content: center; align-items: center">
        <input type="number" size="10" id="num1" disabled/>
        <p> + </p>
        <input type="number" size="10" id="num2" disabled/>
        <p> = </p>
        <input type="number" size="10" id="result1" />
    </div>
    <input type="button" value="check" onclick="checkAnswer();"/>
    <p id="msgCorrect"></p>
<script src="Calculator.js"></script>
</asp:Content>
