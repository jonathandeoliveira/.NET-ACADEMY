function toggleParagraph() {
  var toggle = document.getElementById("ex4");
  if (toggle.style.display === "none") {
    toggle.style.display = "block";
  } else {
    toggle.style.display = "none";
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
  var font = parseInt(window.getComputedStyle(document.getElementById("ex6e7")).getPropertyValue('font-size'));
  console.log(font);
  document.getElementById("ex6e7").style.fontSize = (font+2)+"px";
}
function decreaseFont(){
  var font = parseInt(window.getComputedStyle(document.getElementById("ex6e7")).getPropertyValue("font-size"));
  console.log(font);
  document.getElementById("ex6e7").style.fontSize = (font-2)+"px";
}

function pWhiteBackGroundColor(){
  document.getElementById("ex6e7").style.backgroundColor = "white"
}

function pBlackBackGroundColor(){
  document.getElementById("ex6e7").style.backgroundColor = "black"
}
function pWhiteFont(){
  document.getElementById("ex6e7").style.color = "white"
}
function pBlackFont(){
  document.getElementById("ex6e7").style.color = "black";
}