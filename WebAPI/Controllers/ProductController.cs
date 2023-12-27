using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Models.ProductGroupModels;
using Service.Models.ProductModels;
using Service.Services.Product;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(
            IProductService productService
            )
        {
            _productService = productService;
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<bool>> GetProduct(int productId)
        {
            var result = await _productService.GetProduct(productId);
            return Ok(result);
        }

        [HttpGet("list")]
        public async Task<ActionResult<bool>> GetProducts()
        {
            var result = await _productService.GetProducts();
            return Ok(result);
        }

        [HttpGet("list/promote")]
        public async Task<ActionResult<bool>> GetProductPromotes()
        {
            var result = await _productService.GetProductPromotes();
            return Ok(result);
        }

        [HttpGet("list/{productGroupId}")]
        public async Task<ActionResult<bool>> GetProducts(int productGroupId)
        {
            var result = await _productService.GetProducts(productGroupId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> CrateProduct([FromBody] ProductInputModel input)
        {
            var result = await _productService.CrateProduct(input);
            return Ok(result);
        }

        [HttpPut("{productId}")]
        public async Task<ActionResult<bool>> UpdateProduct(int productId, [FromBody] ProductInputModel input)
        {
            var result = await _productService.UpdateProduct(productId, input);
            return Ok(result);
        }

        [HttpDelete("{productId}")]
        public async Task<ActionResult<bool>> DeleteProduct(int productId)
        {
            var result = await _productService.DeleteProduct(productId);
            return Ok(result);
        }

        [HttpPost("files")]
        [RequestSizeLimit(5 * 1024 * 1024)]
        public async Task<ActionResult<bool>> CrateProductFile([FromForm] List<IFormFile> input)
        {
            var result = await _productService.CrateProductFile(input);
            return Ok(result);
        }
    }
}
