// Matriz com [idDoBotao, posicaoDeScroll]
const botoesTopo = [
["btnTopo", 0],          // botão que sobe pro topo
["btnMeio", 500],        // exemplo: botão que vai até 500px da página
["btnFim", document.body.scrollHeight] // exemplo: botão que vai pro final
];

// Percorrer a matriz e aplicar a lógica em cada botão
for (let i = 0; i < botoesTopo.length; i++) {
let [idBotao, posicao] = botoesTopo[i];
const btn = document.getElementById(idBotao);

if (btn) {
// Mostrar ou esconder botão conforme o scroll
window.addEventListener("scroll", () => {
if (document.body.scrollTop > 200 || document.documentElement.scrollTop > 200) {
btn.style.display = "block";
} else {
btn.style.display = "none";
}
});

// Ao clicar, rolar suavemente até a posição definida na matriz
btn.addEventListener("click", () => {
window.scrollTo({
top: posicao,
behavior: "smooth"
});
});
}
}
