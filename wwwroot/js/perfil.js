// perfil.js - inicialização segura dos modais
(function () {
    document.addEventListener("DOMContentLoaded", function () {
        console.debug("perfil.js carregado");

        function setupModal(modalId, btnId) {
            var modal = document.getElementById(modalId);
            var btn = document.getElementById(btnId);
            if (!modal || !btn) {
                console.debug("Ignorando par modal/btn ausente:", modalId, btnId);
                return;
            }

            var span = modal.querySelector(".close");
            var content = modal.querySelector(".modal-content");

            btn.addEventListener("click", function (e) {
                e.preventDefault();
                modal.style.display = "block";
            });

            if (span) {
                span.addEventListener("click", function () {
                    modal.style.display = "none";
                });
            }

            if (content) {
                content.addEventListener("click", function (e) {
                    e.stopPropagation();
                });
            }
        }

        var modalIds = [
            { modal: "myModal-dados", btn: "dados" },
            { modal: "myModal-ctts", btn: "cttsEmergencia" },
            { modal: "myModal-remed", btn: "remedios" },
            { modal: "myModal-alerg", btn: "alergias" } // será ignorado se não existir
        ];

        modalIds.forEach(function (m) {
            setupModal(m.modal, m.btn);
        });

        // Fechar clicando fora do modal
        window.addEventListener("click", function (event) {
            modalIds.forEach(function (m) {
                var modal = document.getElementById(m.modal);
                if (modal && event.target === modal) {
                    modal.style.display = "none";
                }
            });
        });

        console.debug("perfil.js inicializado");
    });
})();