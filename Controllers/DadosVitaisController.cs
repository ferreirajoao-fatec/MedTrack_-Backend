using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedTrack_Projeto.Data;
using MedTrack_Projeto.Models;

namespace MedTrack_Projeto.Controllers
{
    public class DadosVitaisController : Controller
    {
        private readonly AppDbContext _context;

        public DadosVitaisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DadosVitais
        public async Task<IActionResult> Index()
        {
            return View(await _context.DadosVitais.ToListAsync());
        }

        // GET: DadosVitais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var dadosVitais = await _context.DadosVitais
                .FirstOrDefaultAsync(d => d.IdUsuario == id);

            if (dadosVitais == null) return NotFound();

            return View(dadosVitais);
        }

        // GET: DadosVitais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DadosVitais/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(
            "IdUsuario,Nome,CPF,DataNascimento,Sexo,Altura,Peso,TipoSanguineo,SUS,NomeContato,TelefoneContato,Relacionamento,Medicamento,Dosagem,Frequencia,Observacoes"
        )] DadosVitais dadosVitais)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dadosVitais);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dadosVitais);
        }

        // GET: DadosVitais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var dadosVitais = await _context.DadosVitais.FindAsync(id);
            if (dadosVitais == null) return NotFound();

            return View(dadosVitais);
        }

        // POST: DadosVitais/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind(
            "IdUsuario,Nome,CPF,DataNascimento,Sexo,Altura,Peso,TipoSanguineo,SUS,NomeContato,TelefoneContato,Relacionamento,Medicamento,Dosagem,Frequencia,Observacoes"
        )] DadosVitais dadosVitais)
        {
            if (id != dadosVitais.IdUsuario) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dadosVitais);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DadosVitaisExists(dadosVitais.IdUsuario)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dadosVitais);
        }

        // GET: DadosVitais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var dadosVitais = await _context.DadosVitais
                .FirstOrDefaultAsync(d => d.IdUsuario == id);

            if (dadosVitais == null) return NotFound();

            return View(dadosVitais);
        }

        // POST: DadosVitais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dadosVitais = await _context.DadosVitais.FindAsync(id);
            if (dadosVitais != null)
            {
                _context.DadosVitais.Remove(dadosVitais);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool DadosVitaisExists(int id)
        {
            return _context.DadosVitais.Any(e => e.IdUsuario == id);
        }
    }
}
