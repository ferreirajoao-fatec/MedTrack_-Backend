document.addEventListener("DOMContentLoaded", () => {
// Vetor com os pares [botao, menu]
const elementos = [
["nav-btn-toggle", "nav-mobile"]
];

// Percorrer o vetor
for (let i = 0; i < elementos.length; i++) {
const btn = document.getElementById(elementos[i][0]);
const menu = document.getElementById(elementos[i][1]);

if (btn && menu) {
btn.addEventListener("click", () => {
menu.classList.toggle("open");
});
}
}
});
