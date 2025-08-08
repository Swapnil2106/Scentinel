using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scentinel.Data;
using Scentinel.DTOs;
using Scentinel.IServices;

namespace Scentinel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await productService.GetProductById(id);
            return Ok(product);
        }
    }
}
