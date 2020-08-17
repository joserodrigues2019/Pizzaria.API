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
    public class SaboresPizzaRepository: BaseRepository,ISaboresPizzaRepository
    {
        public SaboresPizzaRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<SaboresPizzaEntity>> ListAsync()
        {
            return await _context.Sabores.ToListAsync();
        }
    }
}
