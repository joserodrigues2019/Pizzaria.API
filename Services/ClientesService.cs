using Pizzaria.API.Domain.Models;
using Pizzaria.API.Domain.Repositories;
using Pizzaria.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Services
{
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _clienteRepository;

        public ClientesService(IClientesRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<ClientesEntity>> ListAsync()
        {
            return await _clienteRepository.ListAsync();
        }

        public async void IncluirCliente(ClientesEntity clienteEntity)
        {
            await _clienteRepository.Add(clienteEntity);
        }
    }
}
