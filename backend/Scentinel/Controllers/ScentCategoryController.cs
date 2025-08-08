using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scentinel.IServices;

namespace Scentinel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScentCategoryController : ControllerBase
    {
        private readonly IScentCategoryService scentCategoryService;
        public ScentCategoryController(IScentCategoryService _scentCategoryService)
        {
            scentCategoryService = _scentCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllScentCategories()
        {
            var scentCategories = await scentCategoryService.GetAllScentCategories();
            return Ok(scentCategories);
        }
    }
}
