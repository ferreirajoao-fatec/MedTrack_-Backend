using Microsoft.AspNetCore.Mvc;

namespace MedTrack_Projeto.Controllers
{
    public class FormularioController : Controller
    {
        // Página do Formulário
        public IActionResult Formulario()
        {
            return View();
        }
    }
}
