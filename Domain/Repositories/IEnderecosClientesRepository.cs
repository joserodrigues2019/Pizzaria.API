using Pizzaria.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Domain.Repositories
{
    public interface IEnderecosClientesRepository
    {
        Task<EnderecosClientesEntity> FindByIdAsync(int idCliente);
        IQueryable GetEndCliente(int idCliente);
    }
}
