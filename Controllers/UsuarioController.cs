using Microsoft.AspNetCore.Mvc;

using MedTrack_Projeto.Models;

namespace MedTrack_Projeto.Controllers
{
    public class UsuarioController : Controller
    {
        // 1. Criar a lista estática de usuários.
        private static List<Usuario> usuarios = new List<Usuario>();

        // 2. Fazer o CRUD (Create, Read, Update and Delete) do Usuário.
        // 2.1 CRUD => Read: Listar Todos os Usuários.
        public IActionResult Index()
        {
            if (usuarios.Count <= 0)
            {
                usuarios.Add(new Usuario(1, "Julia", "julia@gmail.com", "(16)997227057", "senha1", "senha1"));
                usuarios.Add(new Usuario(2, "Bruno", "bruno@email.com", "(16)988776655", "senha2", "senha2"));
                usuarios.Add(new Usuario(3, "Carla", "carla@email.com", "(16)977665544", "senha3", "senha3"));
                usuarios.Add(new Usuario(4, "Diego", "diego@email.com", "(16)966554433", "senha4", "senha4"));
                usuarios.Add(new Usuario(5, "Elisa", "elisa@email.com", "(16)955443322", "senha5", "senha5"));
            }
            return View(usuarios);
        }

        // 2.2.1 CRUD => Create(HttpGet): Criar um novo usuário a partir da página
        //  Em branco do formulário de cadastro do usuário.        
        public IActionResult Create()
        {
            return View();
        }

        // 2.2.2 CRUD => Create(HttpPost): Enviar os dados do formulário para o controlador,
        //                                 salvar os dados na lista de usuário.
        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.IdUsuario = usuarios.Count > 0 ? usuarios.Max(u => u.IdUsuario) + 1 : 1;
                usuarios.Add(usuario);
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // 2.2.3 CRUD => Edit(HttpGet): Acessa a página de alteração de dados do usuário,
        //                              trazendo consigo os dados desse usuário, através do seu id.
        public IActionResult Edit(int id)
        {
            var usuario = usuarios.FirstOrDefault(u => u.IdUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // 2.2.4 CRUD => Edit(HttpPost): Envia os dados do usuário alterados e
        //                               salva esses dados na lista do usuário.
        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDaLista = usuarios.FirstOrDefault(u => u.IdUsuario == usuario.IdUsuario);
                if (usuarioDaLista == null)
                {
                    return NotFound();
                }
                usuarioDaLista.NomeUsuario = usuario.NomeUsuario;
                usuarioDaLista.EmailUsuario = usuario.EmailUsuario;
                usuarioDaLista.TelefoneUsuario = usuario.TelefoneUsuario;
                usuarioDaLista.SenhaUsuario = usuario.SenhaUsuario;
                usuarioDaLista.ConfirmarSenhaUsuario = usuario.ConfirmarSenhaUsuario;

                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // 2.2.5 CRUD => Delete(HttpGet): Remove o usuário da lista de usuário
        //                                através do parâmetro id passado no método Delete.
        public IActionResult Delete(int id)
        {
            var usuario = usuarios.FirstOrDefault(u => u.IdUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            usuarios.Remove(usuario);
            return RedirectToAction("Index");
        }

    }
}
