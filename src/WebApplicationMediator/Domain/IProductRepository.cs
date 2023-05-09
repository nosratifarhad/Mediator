using WebApplicationMediator.Domain.Entity;

namespace WebApplicationMediator.Domain
{
    public interface IProductRepository
    {
        Task CreateProduct(Product product);

        Task<IEnumerable<Product>> GetProduct();
    }
}
