using BikeStoresApi.Dtos;
using BikeStoresApi.Models;

using BikeStoresApi.Services.ProductService;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoresApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService categoryService)
        {
            _productService = categoryService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetProductDto>>>> Get()
        {
            return Ok(await _productService.GetProductAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetProductDto>>> GetById(long id)
        {
            var response = await _productService.GetProductById(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetProductDto>>> AddCategory(AddProductDto newProduct)
        {
            return Ok(await _productService.AddProduct(newProduct));
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<ServiceResponse<GetProductDto>>> UpdateProduct(UpdateProductDto updateProduct)
        {
            return Ok(await _productService.UpdateProduct(updateProduct));
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<ServiceResponse<List<GetProductDto>>>> DeleteProduct(int id)
        {
            var response = await _productService.DeleteProduct(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

    }
}
