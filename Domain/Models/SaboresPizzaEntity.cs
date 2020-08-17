using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Domain.Models
{
    [Table("SaboresPizza")]
    public class SaboresPizzaEntity
    {
        [Key]
        public int IdSabor { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public Decimal ValorPadrao { get; set; }

        [Column("DataCadastro", TypeName = "DateTime")]
        public DateTime DataCadastro { get; set; }
    }
}
