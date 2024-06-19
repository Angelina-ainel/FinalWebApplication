function generateRandomNumbers() {
document.getElementById('add1').value = Math.floor(Math.random() * 100);
document.getElementById('add2').value = Math.floor(Math.random() * 100);
document.getElementById('sub1').value = Math.floor(Math.random() * 100);
document.getElementById('sub2').value = Math.floor(Math.random() * 100);
document.getElementById('mul1').value = Math.floor(Math.random() * 10 + 1);
document.getElementById('mul2').value = Math.floor(Math.random() * 10 + 1);
document.getElementById('div1').value = Math.floor(Math.random() * 100 + 1);
document.getElementById('div2').value = Math.floor(Math.random() * 10 + 1);
}

function checkResults() {
    // Addition
    const add1 = parseFloat(document.getElementById('add1').value);
    const add2 = parseFloat(document.getElementById('add2').value);
    const addResult = parseFloat(document.getElementById('addResult').value);
    const addCheck = document.getElementById('addCheck');
    if (add1 + add2 === addResult) {
        addCheck.textContent = '✔';
        addCheck.classList.add('correct');
        addCheck.classList.remove('incorrect');
    } else {
        addCheck.textContent = '✘';
        addCheck.classList.add('incorrect');
        addCheck.classList.remove('correct');
    }

    // Subtraction
    const sub1 = parseFloat(document.getElementById('sub1').value);
    const sub2 = parseFloat(document.getElementById('sub2').value);
    const subResult = parseFloat(document.getElementById('subResult').value);
    const subCheck = document.getElementById('subCheck');
    if (sub1 - sub2 === subResult) {
        subCheck.textContent = '✔';
        subCheck.classList.add('correct');
        subCheck.classList.remove('incorrect');
    } else {
        subCheck.textContent = '✘';
        subCheck.classList.add('incorrect');
        subCheck.classList.remove('correct');
    }

    // Multiplication
    const mul1 = parseFloat(document.getElementById('mul1').value);
    const mul2 = parseFloat(document.getElementById('mul2').value);
    const mulResult = parseFloat(document.getElementById('mulResult').value);
    const mulCheck = document.getElementById('mulCheck');
    if (mul1 * mul2 === mulResult) {
        mulCheck.textContent = '✔';
        mulCheck.classList.add('correct');
        mulCheck.classList.remove('incorrect');
    } else {
        mulCheck.textContent = '✘';
        mulCheck.classList.add('incorrect');
        mulCheck.classList.remove('correct');
    }

    // Division
    const div1 = parseFloat(document.getElementById('div1').value);
    const div2 = parseFloat(document.getElementById('div2').value);
    const divResult = parseFloat(document.getElementById('divResult').value);
    const divCheck = document.getElementById('divCheck');
    if (div1 / div2 === divResult) {
        divCheck.textContent = '✔';
        divCheck.classList.add('correct');
        divCheck.classList.remove('incorrect');
    } else {
        divCheck.textContent = '✘';
        divCheck.classList.add('incorrect');
        divCheck.classList.remove('correct');
    }
}
