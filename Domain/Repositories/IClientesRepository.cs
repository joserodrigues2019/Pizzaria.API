﻿using Pizzaria.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Domain.Repositories
{
    public interface IClientesRepository
    {
        Task<IEnumerable<ClientesEntity>> ListAsync();
        Task Add(ClientesEntity clientes);
        Task<ClientesEntity> FindByIdAsync(int id);
        void Update(ClientesEntity clientes);
        void Remove(ClientesEntity clientes);
    }
}
