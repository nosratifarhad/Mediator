using Mediator;
using WebApplicationMediator.ViewModels.ProductViewModels;

namespace WebApplicationMediator.Application.Queries.Products.GetProduct
{
    public class GetProductQuery : IQuery<IEnumerable<ProductVM>>
    {
        public int ProductId { get; set; }
    }
}
