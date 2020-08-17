using Microsoft.EntityFrameworkCore;
using Pizzaria.API.Domain.Models;
using Pizzaria.API.Domain.Repositories;
using Pizzaria.API.Domain.Services;
using Pizzaria.API.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Persistence.Repositories
{
    public class PedidosRepository: BaseRepository, IPedidosRepository
    {
        public PedidosRepository(AppDbContext context) : base(context)
        {

        }
        public async Task Add(PedidosEntity pedidos)
        {
            await _context.Pedidos.AddAsync(pedidos);

            _context.SaveChanges();
        }

        public async Task<PedidosEntity> FindByIdAsync(int id)
        {
            return await _context.Pedidos.FindAsync(id);
        }

        public async Task<IEnumerable<PedidosEntity>> ListAsync()
        {
            return await _context.Pedidos.ToListAsync();
        }

        public void Remove(PedidosEntity pedidos)
        {
            _context.Pedidos.Remove(pedidos);
        }

        public void Update(PedidosEntity pedidos)
        {
            _context.Pedidos.Update(pedidos);
            _context.SaveChanges();
        }
    }
}
