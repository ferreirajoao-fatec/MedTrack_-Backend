using Microsoft.AspNetCore.Mvc;
using MedTrack_Projeto.Models;
using MedTrack_Projeto.Data;

namespace MedTrack_Projeto.Controllers
{
    public class FormularioController : Controller
    {
        private readonly AppDbContext _context;

        public FormularioController(AppDbContext context)
        {
            _context = context;
        }

        // GET: exibe o formulário
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: recebe o formulário e salva no banco
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnviarFormulario(Formulario dados)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.FormularioMedtrack.Add(dados);
                    _context.SaveChanges();

                    // Redireciona para uma página de confirmação (ou home)
                    return RedirectToAction("Sucesso");
                }

                // Se der erro de validação, volta com os dados preenchidos
                return View("Index", dados);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Erro ao salvar no banco: " + ex.Message);
                return View("Index", dados);
            }
        }

        // Página de sucesso (opcional)
        public IActionResult Sucesso()
        {
            return View();
        }
    }
}
