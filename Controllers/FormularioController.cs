using Microsoft.AspNetCore.Mvc;

namespace MedTrack_Projeto.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Formulario()
        {
            return View();
        }
    }
}
