using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzaria.API.Domain.Models;
using Pizzaria.API.Domain.Services;

namespace Pizzaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidosService _servicepedidos;

        public PedidosController(IPedidosService servicepedidos)
        {
            _servicepedidos = servicepedidos;
        }

        // GET: api/PedidosEntities
        [HttpGet]
        public async Task<IEnumerable<PedidosEntity>> GetAllAsync()
        {
            var pedidos = await _servicepedidos.ListAsync();

            return pedidos;
        }

        // POST: api/PedidosEntities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public void PostPedidos(PedidosEntity pedidos)
        {
            _servicepedidos.IncluirPedido(pedidos);
        }
    }
}
