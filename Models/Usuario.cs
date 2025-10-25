using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace MedTrack_Projeto.Models
{
    public class Usuario
    {
        // Chave primária
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        public string NomeUsuario { get; set; }
        [Required]
        public string EmailUsuario { get; set; }
        public string CpfUsuario { get; set; }
        [Required]
        public string SenhaUsuario { get; set; }
        public string ConfirmarSenhaUsuario { get; set; }

        public Usuario()
        {
            IdUsuario = 0;
            NomeUsuario = string.Empty;
            EmailUsuario = string.Empty;
            CpfUsuario = string.Empty;
            SenhaUsuario = string.Empty;
            ConfirmarSenhaUsuario = "";
        }

        public Usuario(int idUsuario, string nomeUsuario, string emailUsuario, string cpfUsuario, string senhaUsuario, string confirmarSenhaUsuario)
        {
            IdUsuario = idUsuario;
            NomeUsuario = nomeUsuario;
            EmailUsuario = emailUsuario;
            CpfUsuario = cpfUsuario;
            SenhaUsuario = senhaUsuario;
            ConfirmarSenhaUsuario = confirmarSenhaUsuario;
        }
    }
}
