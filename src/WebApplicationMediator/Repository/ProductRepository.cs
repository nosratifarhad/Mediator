﻿using WebApplicationMediator.Domain;
using WebApplicationMediator.Domain.Entity;

namespace WebApplicationMediator.Repository
{
    public class ProductRepository : IProductRepository
    {
        public async Task CreateProduct(Product product, CancellationToken cancellationToken)
        {
            await Task.Delay(1000);
        }

        public async Task<IEnumerable<Product>> GetProduct(CancellationToken cancellationToken)
        {
            return await Task.FromResult(Enumerable.Empty<Product>());
        }

        public async Task<Product> GetProduct(int productId, CancellationToken cancellationToken)
        {
            return await Task.Run(() => new Product());
        }
    }
}
