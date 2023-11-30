using Mediator;
using WebApplicationMediator.Domain;
using WebApplicationMediator.Domain.Entity;
using WebApplicationMediator.ViewModels.ProductViewModels;

namespace WebApplicationMediator.Application.Queries.Products.GetProduct;

public class GetProductQueryHandler : IQueryHandler<GetProductQuery, IEnumerable<ProductVM>>
{
    #region Fields

    private readonly IProductRepository _productService;
    #endregion Fields

    #region Ctor

    public GetProductQueryHandler(IProductRepository productService)
    {
        this._productService = productService;
    }

    #endregion Ctor

    #region Handle

    public async ValueTask<IEnumerable<ProductVM>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var products = await _productService.GetProduct(cancellationToken).ConfigureAwait(false);

        var productVMs = CreateProductVM(products);

        return productVMs;
    }

    #endregion

    #region Private

    private IEnumerable<ProductVM> CreateProductVM(IEnumerable<Product> products)
    {
        ICollection<ProductVM> productVMs = new List<ProductVM>();

        foreach (var product in products)
            productVMs.Add(new ProductVM()
            {
                Id = product.Id,
                Name = product.Name,
            });

        return productVMs;
    }

    #endregion Private

}
