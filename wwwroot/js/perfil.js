var modal1 = document.getElementById("myModal-dados");
var btn1 = document.getElementById("dados");
var span1 = modal1.getElementsByClassName("close")[0];

var modal2 = document.getElementById("myModal-ctts");
var btn2 = document.getElementById("cttsEmergencia");
var span2 = modal2.getElementsByClassName("close")[0];

var modal3 = document.getElementById("myModal-remed");
var btn3 = document.getElementById("remedios");
var span3 = modal3.getElementsByClassName("close")[0];

var modal4 = document.getElementById("myModal-alerg");
var btn4 = document.getElementById("alergias");
var span4 = modal4.getElementsByClassName("close")[0];

// Abrir modais
btn1.onclick = function() {
  modal1.style.display = "block";
}
btn2.onclick = function() {
  modal2.style.display = "block";
}
btn3.onclick = function() {
  modal3.style.display = "block";
}
btn4.onclick = function() {
  modal4.style.display = "block";
}

// Fechar com "x"
span1.onclick = function() {
  modal1.style.display = "none";
}
span2.onclick = function() {
  modal2.style.display = "none";
}
span3.onclick = function() {
  modal3.style.display = "none";
}
span4.onclick = function() {
  modal4.style.display = "none";
}

// Fechar clicando fora do modal (área preta)
window.onclick = function(event) {
  if (event.target == modal1) {
    modal1.style.display = "none";
  }
  if (event.target == modal2) {
    modal2.style.display = "none";
  }
  if (event.target == modal3) {
    modal3.style.display = "none";
  }
  if (event.target == modal4) {
    modal4.style.display = "none";
  }
}
