using Microsoft.EntityFrameworkCore;
using MedTrack_Projeto.Models;

namespace MedTrack_Projeto.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DadosVitais> DadosVitais { get; set; }

        public DbSet<Formulario> FormularioMedtrack { get; set; }

    }
}
