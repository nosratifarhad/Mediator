using WebApplicationMediator.Domain;
using WebApplicationMediator.Domain.Entity;

namespace WebApplicationMediator.Repository
{
    public class ProductRepository : IProductRepository
    {
        public async Task CreateProduct(Product product)
        {
            await Task.Delay(1000);
        }

        public async Task<IEnumerable<Product>> GetProduct()
        {
            return await Task.FromResult(Enumerable.Empty<Product>());
        }
    }
}
