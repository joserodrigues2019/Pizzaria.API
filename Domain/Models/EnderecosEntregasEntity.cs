using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Domain.Models
{
    [Table("EnderecosEntregas")]
    public class EnderecosEntregasEntity
    {
        public virtual PedidosEntity Pedidos { get; set; }

        [Key]
        public int IdEnderecoEntrega { get; set; }

        [ForeignKey(nameof(Pedidos))]
        public int IdPedido { get; set; }

        [StringLength(200)]
        public string EnderecoEntrega { get; set; }

        [StringLength(200)]
        public string Complemento { get; set; }

        [StringLength(100)]
        public string PontoReferencia { get; set; }

        [StringLength(50)]
        public string Bairro { get; set; }

        [StringLength(50)]
        public string Municipio { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(20)]
        public string Cep { get; set; }

    }
}
