using Mediator;
using WebApplicationMediator.ViewModels.ProductViewModels;

namespace WebApplicationMediator.Application.Queries.Products.GetProduct
{
    public class GetProductByIdQuery : IQuery<ProductVM>
    {
        public int ProductId { get; set; }
    }
}
