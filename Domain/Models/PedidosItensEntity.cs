using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Domain.Models
{
    [Table("PedidosItens")]
    public class PedidosItensEntity
    {
        public virtual PedidosEntity Pedidos { get; set; }
        public virtual SaboresPizzaEntity Sabores { get; set; }

        [Key]
        public int IdPedidoItem { get; set; }

        [ForeignKey(nameof(Pedidos))]
        public int IdPedido { get; set; }

        [ForeignKey(nameof(Sabores))]
        public int IdSabor { get; set; }

        public int NrItem { get; set; }
        public int Quantidade { get; set; }
        public Decimal ValorItem { get; set; }

    }
}
