using Service.Models.ProductGroupModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.ProductGroup
{
    public interface IProductGroupService
    {
        public Task<ProductGroupModel> GetProductGroup(int productGroupId);
        public Task<List<ProductGroupModel>> GetProductGroups();
        public Task<bool> CrateProductGroup(ProductGroupInputModel input);
        public Task<bool> UpdateProductGroup(int productGroupId, ProductGroupInputModel input);
        public Task<bool> DeleteProductGroup(int productGroupId);

    }
}
