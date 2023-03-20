using WebApplicationMediator.Dtos;
using WebApplicationMediator.ViewModels.ProductViewModels;

namespace WebApplicationMediator.Service
{
    public interface IProductService
    {
        Task CreateProduct(CreateProductDto createProductDto);

        Task<IEnumerable<ProductVM>> GetProduct();
    }
}
