document.addEventListener("DOMContentLoaded", () => {
  const NavBtnToggle = document.getElementById("nav-btn-toggle");
  const NavMobile = document.getElementById("nav-mobile");

  NavBtnToggle.addEventListener("click", () => {
    NavMobile.classList.toggle("open");
  });
});