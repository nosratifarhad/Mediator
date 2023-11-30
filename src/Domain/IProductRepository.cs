using WebApplicationMediator.Domain.Entity;

namespace WebApplicationMediator.Domain
{
    public interface IProductRepository
    {
        Task CreateProduct(Product product, CancellationToken cancellationToken);

        Task<IEnumerable<Product>> GetProduct(CancellationToken cancellationToken);

        Task<Product> GetProduct(int productId, CancellationToken cancellationToken);
    }
}
