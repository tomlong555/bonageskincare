using Database.Entitys;
using Microsoft.EntityFrameworkCore;
using Service.Models.ProductGroupModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.ProductGroup
{
    public class ProductGroupService : IProductGroupService
    {
        private readonly DBContext _dBContext;
        public ProductGroupService(
            DBContext dBContext
            )
        {
            _dBContext = dBContext;
        }

        public async Task<ProductGroupModel> GetProductGroup(int productGroupId)
        {
            var result = new ProductGroupModel();
            result = await (from productGroup in _dBContext.TbProductGroup
                            where productGroup.ProductGroupId == productGroupId 
                            && !productGroup.IsDeleted
                            select new ProductGroupModel
                            {
                                ProductGroupId = productGroup.ProductGroupId,
                                ProductGroupName = productGroup.ProductGroupName,
                            }).SingleAsync();

            return result;
        }

        public async Task<List<ProductGroupModel>> GetProductGroups()
        {
            var results = new List<ProductGroupModel>();
            results = await (from productGroup in _dBContext.TbProductGroup
                            where !productGroup.IsDeleted
                            select new ProductGroupModel
                            {
                                ProductGroupId = productGroup.ProductGroupId,
                                ProductGroupName = productGroup.ProductGroupName,
                            }).ToListAsync();

            return results;
        }

        public async Task<bool> CrateProductGroup(ProductGroupInputModel input)
        {
            var newData = new TbProductGroup()
            {
                ProductGroupName = input.ProductGroupName,
                CreateBy = 1,
                CreateDate = DateTime.UtcNow,
            };

            await _dBContext.TbProductGroup.AddAsync(newData);
            await _dBContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateProductGroup(int productGroupId, ProductGroupInputModel input)
        {
            var productGroupData = new TbProductGroup();

            productGroupData = await (from productGroup in _dBContext.TbProductGroup
                            where productGroup.ProductGroupId == productGroupId
                            && !productGroup.IsDeleted
                            select productGroup).SingleAsync();

            productGroupData.ProductGroupName = input.ProductGroupName;
            productGroupData.UpdateDate = DateTime.UtcNow;
            productGroupData.UpdateBy = 1;

            await _dBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProductGroup(int productGroupId)
        {
            var productGroupData = new TbProductGroup();

            productGroupData = await (from productGroup in _dBContext.TbProductGroup
                                      where productGroup.ProductGroupId == productGroupId
                                      && !productGroup.IsDeleted
                                      select productGroup).SingleAsync();

            productGroupData.IsDeleted = true;
            productGroupData.UpdateDate = DateTime.UtcNow;
            productGroupData.UpdateBy = 1;

            await _dBContext.SaveChangesAsync();
            return true;
        }
    }
}
