using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Domain.Models
{
    [Table("Clientes")]

    public class ClientesEntity
    {
        [Key]
        public int IdCliente { get; set; }
        
        [StringLength(100)]
        public string NomeCliente { get; set; }

        [StringLength(15)]
        public string Telefone { get; set; }

        public Boolean Ativo { get; set; }

        [Column("DataCadastro", TypeName = "DateTime")]
        public DateTime DataCadastro { get; set; }
    }
}
