using Scentinel.Models;

namespace Scentinel.IServices
{
    public interface IBrandService
    {
        public Task<List<Brand>> GetAllBrands();
    }
}
