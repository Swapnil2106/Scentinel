using Scentinel.DTOs;

namespace Scentinel.IServices
{
    public interface IProductService
    {
        public Task<List<ProductDTO>> GetAllProducts();

        public Task<ProductDTO> GetProductById(int id);
    }
}
