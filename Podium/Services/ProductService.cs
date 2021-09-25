using Podium.Data.Entities;
using Podium.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Podium.Services
{
    public class ProductService  : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await _repository.GetAllAsync();
            return products;
        }
    }
}
