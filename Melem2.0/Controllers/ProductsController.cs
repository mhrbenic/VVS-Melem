using BLL.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Melem2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProducstService _productService; 

        public ProductsController(IProducstService producstService)
        {
            _productService = producstService;
        }

        [HttpGet("GetProducts")]
        public ActionResult<List<string>> GetProducts()
        {
            return _productService.GetProducstList();
        }

    }
}
