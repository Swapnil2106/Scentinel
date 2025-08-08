using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scentinel.IServices;
using Scentinel.Services;

namespace Scentinel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService brandService;
        public BrandController(IBrandService _brandService)
        {
            brandService = _brandService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            var brands = await brandService.GetAllBrands();
            return Ok(brands);
        }
    }
}
