using BikeStoresApi.Dtos;
using BikeStoresApi.Models;
using BikeStoresApi.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoresApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCategoryDto>>>> Get()
        {
            return Ok(await _categoryService.GetCategories());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCategoryDto>>> GetById(long id)
        {   
            var response = await _categoryService.GetCategoryById(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCategoryDto>>> AddCategory(AddCategoryDto newCategory)
        {
            return Ok(await _categoryService.AddCategory(newCategory));
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<ServiceResponse<GetCategoryDto>>> UpdateCategory(UpdateCategoryDto updateCategory)
        {
            return Ok(await _categoryService.UpdateCategory(updateCategory));
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<ServiceResponse<List<GetCategoryDto>>>> DeleteCategory(long id)
        {
            var response = await _categoryService.DeleteCategory(id); 
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        

    }
}
