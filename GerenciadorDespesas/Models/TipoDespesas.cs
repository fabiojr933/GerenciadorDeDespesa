using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.Models
{
    public class TipoDespesas
    {
        public int TipoDespesasId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Remote("TipoDespesasExiste", "TipoDespesas")]
        public string Nome { get; set; }


        public ICollection<Despesas> Despesas { get; set; }
    }
}
