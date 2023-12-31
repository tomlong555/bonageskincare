using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Models.ProductGroupModels;
using Service.Services.Product;
using Service.Services.ProductGroup;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductGroupController : ControllerBase
    {
        private readonly IProductGroupService _productGroupService;

        public ProductGroupController(
            IProductGroupService productGroupService
            )
        {
            _productGroupService = productGroupService;
        }

        [HttpGet("{productGroupId}")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(ProductGroupModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<ProductGroupModel>> GetProductGroup(int productGroupId)
        {
            var result = await _productGroupService.GetProductGroup(productGroupId);
            return Ok(result);
        }

        [HttpGet("list")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(List<ProductGroupModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ProductGroupModel>>> GetProductGroups()
        {
            var result = await _productGroupService.GetProductGroups();
            return Ok(result);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<bool>> CrateProductGroup([FromBody] ProductGroupInputModel input)
        {
            var result = await _productGroupService.CrateProductGroup(input);
            return Ok(result);
        }

        [HttpPut("{productGroupId}")]
        [Authorize]
        public async Task<ActionResult<bool>> UpdateProductGroup(int productGroupId, [FromBody] ProductGroupInputModel input)
        {
            var result = await _productGroupService.UpdateProductGroup(productGroupId, input);
            return Ok(result);
        }

        [HttpDelete("{productGroupId}")]
        [Authorize]
        public async Task<ActionResult<bool>> DeleteProductGroup(int productGroupId)
        {
            var result = await _productGroupService.DeleteProductGroup(productGroupId);
            return Ok(result);
        }
    }
}
