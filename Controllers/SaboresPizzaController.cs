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

    public class SaboresPizzaController : ControllerBase
    {
        private readonly ISaboresPizzaService _serviceSabores;

        public SaboresPizzaController(ISaboresPizzaService serviceSabores)
        {
            _serviceSabores = serviceSabores;
        }

        // GET: api/PedidosEntities
        [HttpGet]
        public async Task<IEnumerable<SaboresPizzaEntity>> GetAllAsync()
        {
            var saboresPizza = await _serviceSabores.ListAsync();

            return saboresPizza;
        }
    }

}
