using Microsoft.AspNetCore.Mvc;
using Pizzaria.API.Domain.Services;
using Pizzaria.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace Pizzaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesService _serviceCliente;

        public ClientesController(IClientesService serviceCliente)
        {
            _serviceCliente = serviceCliente;
        }

        // GET: api/ClienteEntities
        [HttpGet]
        public async Task<IEnumerable<ClientesEntity>> GetAllAsync()
        {
            var clientes = await _serviceCliente.ListAsync();

            return clientes;
        }

        // POST: api/ClienteEntities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public void PostCliente(ClientesEntity clienteEntity)
        {
           _serviceCliente.IncluirCliente(clienteEntity);
        }

    }
}
