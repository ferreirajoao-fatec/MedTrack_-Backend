using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace MedTrack_Projeto.Models
{
    public class DadosVitais
    {
        // Chave primária
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }
        public string TipoSanguineo { get; set; }
        public string SUS { get; set; }
        public string NomeContato { get; set; }
        public string TelefoneContato { get; set; }
        public string Relacionamento { get; set; }
        public string Medicamento { get; set; }
        public string Dosagem { get; set; }
        public string Frequencia { get; set; }
        public string Observacoes { get; set; }

        // Construtor padrão
        public DadosVitais()
        {
            IdUsuario = 0;
            Nome = string.Empty;
            CPF = string.Empty;
            DataNascimento = null;
            Sexo = string.Empty;
            Altura = string.Empty;
            Peso = string.Empty;
            TipoSanguineo = string.Empty;
            SUS = string.Empty;
            NomeContato = string.Empty;
            TelefoneContato = string.Empty;
            Relacionamento = string.Empty;
            Medicamento = string.Empty;
            Dosagem = string.Empty;
            Frequencia = string.Empty;
            Observacoes = string.Empty;
        }

        // Construtor com parâmetros
        public DadosVitais(
            int idUsuario,
            string nome,
            string cpf,
            DateTime? dataNascimento,
            string sexo,
            string altura,
            string peso,
            string tipoSanguineo,
            string sus,
            string nomeContato,
            string telefoneContato,
            string relacionamento,
            string medicamento,
            string dosagem,
            string frequencia,
            string observacoes)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Altura = altura;
            Peso = peso;
            TipoSanguineo = tipoSanguineo;
            SUS = sus;
            NomeContato = nomeContato;
            TelefoneContato = telefoneContato;
            Relacionamento = relacionamento;
            Medicamento = medicamento;
            Dosagem = dosagem;
            Frequencia = frequencia;
            Observacoes = observacoes;
        }
    }
}
