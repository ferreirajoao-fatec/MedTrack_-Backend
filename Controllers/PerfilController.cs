using Microsoft.AspNetCore.Mvc;
using MedTrack_Projeto.Data;
using MedTrack_Projeto.Models;
using System.Linq;

namespace MedTrack_Projeto.Controllers
{
    public class PerfilController : Controller
    {
        private readonly AppDbContext _context;

        public PerfilController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Perfil()
        {
            // Busca o último formulário preenchido
            var ultimoFormulario = _context.FormularioMedtrack
                                           .OrderByDescending(f => f.IdUsuario)
                                           .FirstOrDefault();

            if (ultimoFormulario == null)
                return Content("Nenhum formulário foi preenchido ainda.");

            return View(ultimoFormulario);
        }
    }
}
