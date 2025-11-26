using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
    using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedTrack_Projeto.Models
{
    public class Usuario
    {
        // Chave primária
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]

        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O telefone é obrigatório")]

        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = string.Empty;

        // Removed [Required] here so model validation uses Senha (the user input)
        public string SenhaHash { get; set; } = string.Empty;

        [NotMapped]
        [Required(ErrorMessage = "A senha é obrigatória")]
        [DataType(DataType.Password)]
        public string Senha { get; set; } = string.Empty;

        [NotMapped]
        [Required(ErrorMessage = "Confirme a senha")]
        [DataType(DataType.Password)]
        [Compare(nameof(Senha), ErrorMessage = "As senhas devem coincidir")]
        public string ConfirmarSenha { get; set; } = string.Empty;

        public bool AtivarUsuario { get; set; }

        [Required(ErrorMessage = "O tipo do usuário é obrigatório")]
        public int TipoUsuario { get; set; } // 1 = Admin, 2 = Supervisor, 3 = Comum
    }
}
