using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Repository.Specifications.ProductSpecifications;
using Store.Service.Services.ProductServices;
using Store.Service.Services.ProductServices.Dtos;
using Store.Web.Helper;

namespace Store.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        [Cache(10)]
        public async Task<ActionResult<IReadOnlyList<ProductDetailsDto>>> GetAllProducts([FromQuery]ProductSpecification input) 
            => Ok(await _productService.GetAllProductsAsync(input));
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<TypeBrandDetailsDto>>> GetAllBrands()
            => Ok(await _productService.GetAllBrandsAsync());
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<TypeBrandDetailsDto>>> GetAllTypes()
            => Ok(await _productService.GetAllTypesAsync());
        [HttpGet]
        public async Task<ActionResult<ProductDetailsDto>> GetProductById(int? id)
            => Ok(await _productService.GetProductByIdAsync(id));
    }
}
