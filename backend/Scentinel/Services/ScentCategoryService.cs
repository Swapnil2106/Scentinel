using Microsoft.EntityFrameworkCore;
using Scentinel.Data;
using Scentinel.IServices;
using Scentinel.Models;

namespace Scentinel.Services
{
    public class ScentCategoryService : IScentCategoryService
    {
        private readonly AppDbContext dbContext;
        public ScentCategoryService(AppDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public async Task<List<ScentCategory>> GetAllScentCategories()
        {
            return await dbContext.ScentCategories.ToListAsync();
        }
    }
}
