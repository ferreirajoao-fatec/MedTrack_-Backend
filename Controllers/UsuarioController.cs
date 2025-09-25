using Microsoft.AspNetCore.Mvc;
using MedTrack_Projeto.Models;

namespace UsuarioCrud.Controllers
{
    public class UsuarioController : Controller
    {

        public static List<Usuario> usuarios = new List<Usuario>();
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

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

        public IActionResult Edit(int id)
        {

            var usuario = usuarios.FirstOrDefault(u => u.IdUsuario == id);
            if (usuario == null)
                return NotFound();
            return View(usuario);
        }

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

        public IActionResult Delete(int id)
        {
            // Buscar o usuário na lista pelo Id
            var usuario = usuarios.FirstOrDefault(u => u.IdUsuario == id);

            if (usuario == null)
            {
                return NotFound();
            }

            // Remover o usuário encontrado
            usuarios.Remove(usuario);

            // Redirecionar para a lista de usuários
            return RedirectToAction("Index");
        }
    }
}

