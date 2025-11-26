using MedTrack_Projeto.Data;
using MedTrack_Projeto.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedTrack_Projeto.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;
        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Usuario model)
        {
            if (ModelState.IsValid)
            {
                if (_context.Usuarios.Any(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("", "Email já em uso.");
                    return View(model);
                }
                model.SenhaHash = BCrypt.Net.BCrypt.HashPassword(model.Senha);
                model.AtivarUsuario = true;
                _context.Usuarios.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(model);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string email, string senha)
        {
            var user = _context.Usuarios.SingleOrDefault(u => u.Email == email);
            if (user != null && user.AtivarUsuario && BCrypt.Net.BCrypt.Verify(senha,
           user.SenhaHash))
            {
                var claims = new List<Claim> {
                new Claim(ClaimTypes.Name, user.Nome),
                new Claim("UserId", user.Id.ToString()),
                new Claim(ClaimTypes.Role, RoleFromTipoUsuario(user.TipoUsuario))
                };
                var identity = new ClaimsIdentity(claims,
               CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Login inválido ou usuário desativado.");
            return View();
        }
        private string RoleFromTipoUsuario(int tipo)
        {
            return tipo switch
            {
                1 => "Administrador",
                2 => "Supervisor",
                3 => "Comum",
                _ => "Comum"
            };
        }

        [Authorize]
        public IActionResult Dashboard()
        {
            // Provide a non-null model to the view to avoid NullReferenceException.
            // Only return the full user list for privileged roles; other authenticated users
            // receive an empty list (or you may change to show only current user).
            List<Usuario> users;
            if (User.IsInRole("Administrador") || User.IsInRole("Supervisor"))
            {
                users = _context.Usuarios.ToList();
            }
            else
            {
                users = new List<Usuario>();
            }
            return View(users);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        [Authorize(Roles = "Administrador,Supervisor")]
        public IActionResult Index()
        {
            return View(_context.Usuarios.ToList());
        }

        [Authorize(Roles = "Administrador,Supervisor")]
        public IActionResult Create()
        {
            return View(new Usuario());
        }
        [Authorize(Roles = "Administrador,Supervisor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Usuario model)
        {
            if (ModelState.IsValid)
            {
                if (_context.Usuarios.Any(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("", "Email já em uso.");
                    return View(model);
                }
                model.SenhaHash = BCrypt.Net.BCrypt.HashPassword(model.Senha);
                if (User.IsInRole("Supervisor,Comum"))
                {
                    model.AtivarUsuario = true;
                    model.TipoUsuario = 3;
                }
                _context.Usuarios.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [Authorize(Roles = "Administrador,Supervisor,Comum")]
        public IActionResult Edit(int id)
        {
            var user = _context.Usuarios.Find(id);
            if (user == null) return NotFound();
            return View(user);
        }
        [Authorize(Roles = "Administrador,Supervisor,Comum")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Usuario model)
        {
            if (id != model.Id) return NotFound();
            var userInDb = _context.Usuarios.Find(id);
            if (userInDb == null) return NotFound();
            if (ModelState.IsValid)
            {
                userInDb.Nome = model.Nome;
                userInDb.Telefone = model.Telefone;
                userInDb.Email = model.Email;
                if (!string.IsNullOrEmpty(model.Senha))
                {
                    userInDb.SenhaHash = BCrypt.Net.BCrypt.HashPassword(model.Senha);
                }
                if (User.IsInRole("Administrador,Comum"))
                {
                    userInDb.AtivarUsuario = model.AtivarUsuario;
                    userInDb.TipoUsuario = model.TipoUsuario;
                }
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [Authorize(Roles = "Administrador,Comum")]
        public IActionResult Delete(int id)
        {
            var user = _context.Usuarios.Find(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = _context.Usuarios.Find(id);
            if (user == null) return NotFound();
            _context.Usuarios.Remove(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
