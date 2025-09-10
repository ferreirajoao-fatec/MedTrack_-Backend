
  const btnTopo = document.getElementById("btnTopo");

  // Mostrar ou esconder o botão
  window.onscroll = function() {
    if (document.body.scrollTop > 200 || document.documentElement.scrollTop > 200) {
      btnTopo.style.display = "block";
    } else {
      btnTopo.style.display = "none";
    }
  };

  // Ao clicar, rola suavemente para o topo
  btnTopo.addEventListener("click", function() {
    window.scrollTo({
      top: 0,
      behavior: "smooth"
    });
  });

