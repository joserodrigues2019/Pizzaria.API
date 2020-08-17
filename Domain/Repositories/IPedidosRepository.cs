using Pizzaria.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Domain.Repositories
{
    public interface IPedidosRepository
    {
        Task<IEnumerable<PedidosEntity>> ListAsync();
        Task Add(PedidosEntity pedidos);
        Task<PedidosEntity> FindByIdAsync(int id);
        void Update(PedidosEntity pedidos);
        void Remove(PedidosEntity pedidos);
    }
}
