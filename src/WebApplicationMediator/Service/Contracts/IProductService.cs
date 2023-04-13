using WebApplicationMediator.Dtos;
using WebApplicationMediator.ViewModels.ProductViewModels;

namespace WebApplicationMediator.Service.Contracts
{
    public interface IProductService
    {
        Task CreateProduct(CreateProductDto createProductDto);

        Task<IEnumerable<ProductVM>> GetProduct();
    }
}
