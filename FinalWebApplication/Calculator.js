function checkAnswer() {
    var num1 = intParse(document.getElementById("num1").value); // 19007 107
    var num2 = intParse(document.getElementById("num2").value); // 79002 700|
    var result1 = intParse(document.getElementById("result1").value); // 19002 707
    // alert( the numbers are: $(numl) and $(num2) );
    if (result1 == num1 + num2)
        document.getElementById("msg").innerHTML = "Correct";
    else
        document.getElementById("msg").innerHTML = "Incorrect";
}

function getRandomNum(n) {
    var num;
    if (n == 1)
        num = parseInt(Math.random() * 10) + 1;
        // num = parseInt(Math.floor(Math.random() * 10) + 1);
    else
        num = parseInt(Math.random() * 10) + 10;
    return num;
}
var n1 = getRandomNum(1);
var n2 = getRandomNum(2);
document.getElementById("num1").value = n1;
document.getElementById("num2").value = n2;