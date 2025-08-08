using Scentinel.Models;

namespace Scentinel.IServices
{
    public interface IScentCategoryService
    {
        public Task<List<ScentCategory>> GetAllScentCategories();
    }
}
