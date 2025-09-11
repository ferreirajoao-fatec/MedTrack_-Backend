using Microsoft.AspNetCore.Mvc;

namespace MedTrack_Projeto.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
