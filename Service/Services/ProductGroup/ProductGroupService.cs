using Database.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Service.Helpers;
using Service.Models.BaseModels;
using Service.Models.ProductGroupModels;
using Service.Models.ProductModels;
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
        private readonly PathOptionModel _pathOptionModel;
        public ProductGroupService(
            DBContext dBContext
            , IOptions<PathOptionModel> pathOptionModel
            )
        {
            _dBContext = dBContext;
            _pathOptionModel = pathOptionModel.Value;
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
                                Products = productGroup.TbProducts
                                .Where(product => !product.IsDeleted)
                                .Select(product =>
                                    new ProductModel
                                    {
                                        ProductName = product.ProductName,
                                        ContentHeader = product.ContentHeader,
                                        IsVegan = product.IsVegan,
                                        Filess = product.TbFileProducts
                                        .Where(file => !file.TbFile.IsDeleted)
                                        .Select(file =>
                                            new FileModel
                                            {
                                                FileName = file.TbFile.FileName.ToFilePath(_pathOptionModel.ResoucesPath)
                                            }).ToList(),
                                    }).ToList()
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
                CreateDate = DateTime.UtcNow,
                IsDeleted = false,
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

            await _dBContext.SaveChangesAsync();
            return true;
        }
    }
}
