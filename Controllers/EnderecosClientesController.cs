using Microsoft.AspNetCore.Mvc;
using Pizzaria.API.Domain.Models;
using Pizzaria.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecosClientesController: ControllerBase
    {
        private readonly IEnderecosClientesService _enderecoClienteService;

        public EnderecosClientesController(IEnderecosClientesService enderecoClienteService)
        {
            _enderecoClienteService = enderecoClienteService;
        }

        // GET: api/EnderecosClientesEntity
        [HttpGet("{id}")]
        public async Task<EnderecosClientesEntity> GetEnderecoCliente(int id)
        {
            var retEndereco = await _enderecoClienteService.GetEnderecoCliente(id);

            return retEndereco;
        }
    }
}
