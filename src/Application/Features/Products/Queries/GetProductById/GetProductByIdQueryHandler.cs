using Mediator;
using WebApplicationMediator.Domain;
using WebApplicationMediator.Domain.Entity;
using WebApplicationMediator.ViewModels.ProductViewModels;

namespace WebApplicationMediator.Application.Queries.Products.GetProduct
{
    public class GetProductByIdQueryHandler : IQueryHandler<GetProductByIdQuery, ProductVM>
    {
        #region Fields

        private readonly IProductRepository _productService;
        #endregion Fields

        #region Ctor

        public GetProductByIdQueryHandler(IProductRepository productService)
        {
            this._productService = productService;
        }

        #endregion Ctor

        #region Handle

        public async ValueTask<ProductVM> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productService.GetProduct(request.ProductId, cancellationToken).ConfigureAwait(false);

            var productVM = CreateProductVM(product);

            return productVM;
        }

        #endregion

        #region Private

        private ProductVM CreateProductVM(Product products)
            => new ProductVM()
            {
                Name = products.Name,
                Id = products.Id,
            };

        #endregion Private

    }
}
