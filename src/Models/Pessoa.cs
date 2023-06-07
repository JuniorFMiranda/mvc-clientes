using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClientes.Models
{
    public abstract class Pessoa
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome!")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "O campo nome deve possuir entre 5 e 60 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo documento!")]
        [RegularExpression(@"^[0-9]", ErrorMessage = "Formato inválido para o campo documento.")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "O campo documento deve possuir entre 11 e 14 caracteres.")]
        public string Documento { get; set; }
        public bool Ativo { get; set; }
    }
}