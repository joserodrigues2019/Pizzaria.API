using Pizzaria.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Domain.Services
{
    public interface IPedidosService
    {
        Task<IEnumerable<PedidosEntity>> ListAsync();
        void IncluirPedido(PedidosEntity pedidos);
    }
}
