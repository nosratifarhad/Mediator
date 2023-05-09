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
            var createProductDto = GenereateCreateProductDtoFromaCommand(request);

            await _productRepository.CreateProduct(createProductDto).ConfigureAwait(false);

            return Unit.Value;
        }
        #endregion

        #region Private

        private Product GenereateCreateProductDtoFromaCommand(CreateProductCommand command)
            => new Product()
            {
                //Map
            };

        #endregion Private
    }
}
