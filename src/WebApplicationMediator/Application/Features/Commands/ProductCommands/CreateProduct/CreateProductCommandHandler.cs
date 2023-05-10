using Mediator;
using WebApplicationMediator.Domain;
using WebApplicationMediator.Domain.Entity;

namespace WebApplicationMediator.Application.Commands.ProductCommands.CreateProduct
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
    {
        #region Fields

        private readonly IProductRepository _productRepository;
        #endregion Fields

        #region Ctor

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        #endregion Ctor

        #region Handle

        public async ValueTask<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var createProduct = GenereateCreateProductFromaCommand(request);

            await _productRepository.CreateProduct(createProduct, cancellationToken).ConfigureAwait(false);

            return Unit.Value;
        }
        #endregion

        #region Private

        private Product GenereateCreateProductFromaCommand(CreateProductCommand command)
            => new Product()
            {
                //Map
            };

        #endregion Private
    }
}
