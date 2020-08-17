using Pizzaria.API.Domain.Models;
using Pizzaria.API.Domain.Repositories;
using Pizzaria.API.Domain.Services;
using Pizzaria.API.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Services
{
    public class EnderecosClientesService : IEnderecosClientesService
    {
        private readonly IEnderecosClientesRepository _enderecosClientesRepository;

        public EnderecosClientesService(IEnderecosClientesRepository enderecosClientesRepository)
        {
            _enderecosClientesRepository = enderecosClientesRepository;
        }

        public async Task<EnderecosClientesEntity> GetEnderecoCliente(int idCliente)
        {
            var ret =  await _enderecosClientesRepository.FindByIdAsync(idCliente);

            return ret;
        }
    }
}
