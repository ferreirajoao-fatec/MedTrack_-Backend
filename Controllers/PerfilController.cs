using Microsoft.AspNetCore.Mvc;

namespace MedTrack_Projeto.Controllers
{
    public class PerfilController : Controller
    {
        public IActionResult Perfil()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
