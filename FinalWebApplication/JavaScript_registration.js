﻿function checkForm() {
    var username = document.getElementById("username").value;
    var firstName = document.getElementById("firstName").value;
    var lastName = document.getElementById("lastName").value;
    var phone = document.getElementById("phone").value;

    document.getElementById("invUsername").innerHTML = "";
    document.getElementById("invFirstName").innerHTML = "";
    document.getElementById("invLastName").innerHTML = "";
    document.getElementById("invPhone").innerHTML = "";

    var isValid = true;

    if (username.length < 2 || username.length > 30) {
        document.getElementById("invUsername").innerHTML = "Username is too short or long or not valid.";
        isValid = false;
    }
    if (firstName.length < 2 || firstName.length > 30) {
        document.getElementById("invFirstName").innerHTML = "First name is too short or long or not valid.";
        isValid = false;
    }
    if (lastName.length < 2 || lastName.length > 30) {
        document.getElementById("invLastName").innerHTML = "Last name is too short or long or not valid.";
        isValid = false;
    }
    if (!/^\d{7}$/.test(phone)) {
        document.getElementById("invPhone").innerHTML = "There must be exactly 7 digits in the phone number.";
        isValid = false;
    }

    return isValid;
}