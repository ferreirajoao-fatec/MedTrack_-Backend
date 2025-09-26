using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Identity;

namespace MedTrack_Projeto.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string TelefoneUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string ConfirmarSenhaUsuario { get; set; }

        public Usuario()
        {
            IdUsuario = 0;
            NomeUsuario = string.Empty;
            EmailUsuario = string.Empty;
            TelefoneUsuario = string.Empty;
            SenhaUsuario = string.Empty;
            ConfirmarSenhaUsuario = "";
        }

        public Usuario(int idUsuario, string nomeUsuario, string emailUsuario, string telefoneUsuario, string senhaUsuario, string confirmarSenhaUsuario)
        {
            IdUsuario = idUsuario;
            NomeUsuario = nomeUsuario;
            EmailUsuario = emailUsuario;
            TelefoneUsuario = telefoneUsuario;
            SenhaUsuario = senhaUsuario;
            ConfirmarSenhaUsuario = confirmarSenhaUsuario;
        }
    }
}