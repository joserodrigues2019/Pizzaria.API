using Microsoft.EntityFrameworkCore;
using Pizzaria.API.Domain.Models;
using Pizzaria.API.Domain.Repositories;
using Pizzaria.API.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Persistence.Repositories
{
    public class ClientesRepository: BaseRepository, IClientesRepository
    {
        public ClientesRepository(AppDbContext context) : base(context)
        {

        }
        public async Task Add(ClientesEntity clientes)
        {
            await _context.Clientes.AddAsync(clientes);

            _context.SaveChanges();
        }

        public async Task<ClientesEntity> FindByIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<IEnumerable<ClientesEntity>> ListAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public void Remove(ClientesEntity clientes)
        {
            _context.Clientes.Remove(clientes);
        }

        public void Update(ClientesEntity clientes)
        {
            _context.Clientes.Update(clientes);
            _context.SaveChanges();
        }
    }
}
