using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Models.ProductGroupModels;
using Service.Services.Product;
using Service.Services.ProductGroup;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public async Task<ActionResult<bool>> GetProductGroup(int productGroupId)
        {
            var result = await _productGroupService.GetProductGroup(productGroupId);
            return Ok(result);
        }

        [HttpGet("list")]
        public async Task<ActionResult<bool>> GetProductGroups()
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
