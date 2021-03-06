﻿using Pizzaria.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.API.Domain.Repositories
{
    public interface ISaboresPizzaRepository
    {
        Task<IEnumerable<SaboresPizzaEntity>> ListAsync();
    }
}
