﻿using Podium.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podium.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
    }
}
