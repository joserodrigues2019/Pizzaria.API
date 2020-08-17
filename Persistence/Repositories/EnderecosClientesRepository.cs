using Pizzaria.API.Domain.Models;
using Pizzaria.API.Domain.Repositories;
using Pizzaria.API.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Persistence.Repositories
{
    public class EnderecosClientesRepository: BaseRepository, IEnderecosClientesRepository
    {
        public EnderecosClientesRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<EnderecosClientesEntity> FindByIdAsync(int idCliente)
        {
            return await _context.EnderecoClientes.FindAsync(idCliente);
        }
    }
}
