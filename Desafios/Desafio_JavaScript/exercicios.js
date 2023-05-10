function toggleParagraph() {
  var toggle = document.getElementById("ex4");
  var misterm = document.getElementById("misterm");
  if (toggle.style.display === "none") {
    toggle.style.display = "block";
    misterm.style.display = "block"
  } else {
    toggle.style.display = "none";
    misterm.style.display = "none"
  }
}

function checkChecks(){
  var check = document.querySelectorAll('input[name="check"]:checked')
  var sendBtn = document.getElementById("btn5");
  sendBtn.disabled = true;
  if (check.length >= 2 ){
    console.log(check);
    sendBtn.disabled = false;
  }
}

function increaseFont(){
  var font = parseInt(window.getComputedStyle(document.getElementById("ex6e7e8")).getPropertyValue('font-size'));
  console.log(font);
  document.getElementById("ex6e7e8").style.fontSize = (font+2)+"px";
}
function decreaseFont(){
  var font = parseInt(window.getComputedStyle(document.getElementById("ex6e7e8")).getPropertyValue("font-size"));
  console.log(font);
  document.getElementById("ex6e7e8").style.fontSize = (font-2)+"px";
}

function pWhiteBackGroundColor(){
  document.getElementById("ex6e7e8").style.backgroundColor = "white";
}

function pBlackBackGroundColor(){
  document.getElementById("ex6e7e8").style.backgroundColor = "black";
}
function pWhiteFont(){
  document.getElementById("ex6e7e8").style.color = "white";
}
function pBlackFont(){
  document.getElementById("ex6e7e8").style.color = "black";
}
function pUpCase(){
  var p = document.getElementById("ex6e7e8");
  maiusucla = p.textContent.toUpperCase();
  p.textContent = maiusucla;
}
function pDownCase(){
  var p = document.getElementById("ex6e7e8");
  minuscula = p.textContent.toLowerCase();
  p.textContent = minuscula;
}

function matchPasswords(){
  senha = document.getElementById("psw");
  confirma_senha = document.getElementById("confirm-psw");
  if (senha !== confirma_senha) {
    alert("A senha e a confirmação devem ser iguais.");
  }
}

function checaBox() {
  var boxCPF = document.getElementById("box-document-cpf");
  var boxCNPJ = document.getElementById("box-document-cnpj");
  var formCPF = document.getElementById("form-CPF");
  var formCNPJ = document.getElementById("form-CPNJ");
  var birthdayField = document.getElementById("input-birthday");

  if (boxCPF.checked) {
    formCPF.style.display = "block";
    formCNPJ.style.display = "none";
    birthdayField.style.display = "block";
  } else if (boxCNPJ.checked) {
    formCPF.style.display = "none";
    formCNPJ.style.display = "block";
    birthdayField.style.display = "none";
  } else {
    formCPF.style.display = "none";
    formCNPJ.style.display = "none";
    birthdayField.style.display = "none";

  }
}