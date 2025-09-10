// Seleciona o botão e o body
const darkModeToggle = document.getElementById('dark-mode-toggle');
const body = document.body;

// Seleciona o logotipo (pode não existir)
const logo = document.querySelector('.navbar-logo');

// Caminhos das imagens para os modos
const logoLight = "../imagens/logo-claro.svg"; // imagem para modo claro
const logoDark = "../imagens/logo-escuro.svg"; // imagem para modo escuro

// Verifica se o usuário já tem preferência salva
if (localStorage.getItem('darkMode') === 'enabled') {
  body.classList.add('dark-mode');
  darkModeToggle.innerHTML = '<i class="fa-solid fa-sun"></i>';
  if (logo) logo.src = logoDark;
} else {
  if (logo) logo.src = logoLight;
  darkModeToggle.innerHTML = '<i class="fa-solid fa-moon"></i>';
}

// Alterna o modo escuro
darkModeToggle.addEventListener('click', (e) => {
  e.preventDefault();
  body.classList.toggle('dark-mode');

  if (body.classList.contains('dark-mode')) {
    localStorage.setItem('darkMode', 'enabled');
    darkModeToggle.innerHTML = '<i class="fa-solid fa-sun"></i>'; // muda ícone para sol
    if (logo) logo.src = logoDark;
  } else {
    localStorage.setItem('darkMode', 'disabled');
    darkModeToggle.innerHTML = '<i class="fa-solid fa-moon"></i>'; // muda ícone para lua
    if (logo) logo.src = logoLight;
  }
});
