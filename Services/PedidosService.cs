using Pizzaria.API.Domain.Models;
using Pizzaria.API.Domain.Repositories;
using Pizzaria.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Services
{
    public class PedidosService: IPedidosService
    {
        private readonly IPedidosRepository _pedidosRepository;

        public PedidosService(IPedidosRepository pedidosRepository)
        {
            _pedidosRepository = pedidosRepository;
        }
        public async Task<IEnumerable<PedidosEntity>> ListAsync()
        {
            return await _pedidosRepository.ListAsync();
        }

        public async void IncluirPedido(PedidosEntity pedidos)
        {
            if (ValidarPedidos(pedidos))
            {
                var pedidosItens = new List<PedidosItensEntity>();

                foreach (var item in pedidos.pedidosItens)
                {
                    pedidosItens.Add(item);
                }

                await _pedidosRepository.Add(pedidos);
            }
            else
            {
                throw new Exception("Pedidos sem Itens - Pedido deve ter pelo menos uma e no maximo 10 pizza");
            }
        }

        private Boolean ValidarPedidos(PedidosEntity pedidos)
        {
            Boolean bRet = false;

            if (pedidos.pedidosItens.Count > 0)
            {
                if (pedidos.pedidosItens.Count > 10)
                {
                    bRet = false;
                }
                else
                {
                    bRet = true;
                }
               
            }
            else
            {
                bRet = false;
            }

            return bRet;
        }
    }
}
