using Mediator;
using WebApplicationMediator.Dtos;
using WebApplicationMediator.Service.Contracts;

namespace WebApplicationMediator.Application.Commands.ProductCommands.CreateProduct
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
    {
        #region Fields

        private readonly IProductService _productService;
        #endregion Fields

        #region Ctor

        public CreateProductCommandHandler(IProductService productService)
        {
            this._productService = productService;
        }

        #endregion Ctor

        #region Handle

        public async ValueTask<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var createProductDto = GenereateCreateProductDtoFromaCommand(request);

            await _productService.CreateProduct(createProductDto).ConfigureAwait(false);

            return Unit.Value;
        }
        #endregion

        #region Private

        private CreateProductDto GenereateCreateProductDtoFromaCommand(CreateProductCommand command)
            => new CreateProductDto()
            {
                //Map Prop
            };

        #endregion Private
    }
}
