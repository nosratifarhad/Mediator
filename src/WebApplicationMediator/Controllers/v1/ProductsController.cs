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
        [HttpPost("/api/v1/product")]
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
        [HttpGet("/api/v1/product/{productId:int}")]
        public async Task<IActionResult> GetProduct(int productId)
        {
            var productVMs = await _mediator.Send(new GetProductQuery() { ProductId = productId });

            return Ok(productVMs);
        }


    }
}
