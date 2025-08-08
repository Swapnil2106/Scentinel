using Microsoft.EntityFrameworkCore;
using Scentinel.Data;
using Scentinel.IServices;
using Scentinel.Models;

namespace Scentinel.Services
{
    public class BrandService: IBrandService
    {
        private readonly AppDbContext dbContext;

        public BrandService(AppDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }

        public async Task<List<Brand>> GetAllBrands()
        {
            return await dbContext.Brands.ToListAsync();
        }
    }
}
