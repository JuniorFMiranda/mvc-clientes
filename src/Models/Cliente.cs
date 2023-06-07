using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClientes.Models
{
    public sealed class Cliente : Pessoa
    {
        [Range(0, 5000, ErrorMessage = "O valor do limite de crédito deve estar dentro da faixa entre R$ 0.00 e R$ 5.000,00")]
        [Display(Name = "Limite de crédito")]
        public decimal LimiteCredito { get; set; }
    }
}