using Pizzaria.API.Domain.Models;
using Pizzaria.API.Domain.Repositories;
using Pizzaria.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Services
{
    public class SaboresPizzaService: ISaboresPizzaService
    {
        private readonly ISaboresPizzaRepository _saboresPizzaRepository;

        public SaboresPizzaService(ISaboresPizzaRepository saboresPizzaRepository)
        {
            _saboresPizzaRepository = saboresPizzaRepository;
        }

        public async Task<IEnumerable<SaboresPizzaEntity>> ListAsync()
        {
            return await _saboresPizzaRepository.ListAsync();
        }
    }
}
