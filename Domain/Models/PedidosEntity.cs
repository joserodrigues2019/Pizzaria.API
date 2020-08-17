using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Domain.Models
{
    [Table("Pedidos")]
    public class PedidosEntity
    {

        [Key]
        public int IdPedido { get; set; }

        public Boolean ClienteTemCadastro{ get; set; }

        public int? IdCliente { get; set; }

        [StringLength(100)]
        public string NomeCliente { get; set; }

        [StringLength(15)]
        public string Telefone { get; set; }

        [Column("DataEmissao", TypeName = "DateTime")]
        public DateTime DataEmissao { get; set; }

        [Column("DataEntrega", TypeName = "DateTime")]
        public DateTime DataEntrega{ get; set; }

        public Decimal ValorTotal { get; set; }

        public IList<PedidosItensEntity> pedidosItens { get; set; } = new List<PedidosItensEntity>();
    }
}
