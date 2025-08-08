using Microsoft.EntityFrameworkCore;
using Scentinel.Data;
using Scentinel.DTOs;
using Scentinel.IServices;

namespace Scentinel.Services
{
    public class ProductService: IProductService
    {
        private readonly AppDbContext dbContext;

        public ProductService(AppDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }

        public async Task<List<ProductDTO>> GetAllProducts()
        {
            var products = await dbContext.Products
                           .Select(p => new ProductDTO
                           {
                               ProductId = p.ProductId,
                               Name = p.Name,
                               Description = p.Description,
                               Price = p.Price,
                               BrandName = p.Brand.Name,
                               ScentCategoryName = p.ScentCategory.CategoryName
                           })
                           .ToListAsync();

            return products;
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var product = await dbContext.Products
                            .Where(p => p.ProductId == id)
                            .Select(p => new ProductDTO
                            {
                                ProductId = p.ProductId,
                                Name = p.Name,
                                Description = p.Description,
                                Price = p.Price,
                                BrandName = p.Brand.Name,
                                ScentCategoryName = p.ScentCategory.CategoryName
                            }).FirstOrDefaultAsync();
            if (product == null)
                {
                throw new KeyNotFoundException($"Product with ID {id} not found.");
            }

            return product;
        }
    }
}
