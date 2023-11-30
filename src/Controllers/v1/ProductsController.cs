using Mediator;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMediator.Application.Commands.ProductCommands.CreateProduct;
using WebApplicationMediator.Application.Queries.Products.GetProduct;

namespace WebApplicationMediator.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;

        }

        /// <summary>
        /// CreateProduct
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/products")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        /// <summary>
        /// GetProduct
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/products/{productId:int}")]
        public async Task<IActionResult> GetProduct(int productId)
        {
            var productVMs = await _mediator.Send(new GetProductByIdQuery() { ProductId = productId });

            return Ok(productVMs);
        }

        /// <summary>
        /// GetProduct
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/v1/products")]
        public async Task<IActionResult> GetProduct()
        {
            var productVMs = await _mediator.Send(new GetProductQuery());

            return Ok(productVMs);
        }
    }
}
