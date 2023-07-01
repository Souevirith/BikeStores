using AutoMapper;
using BikeStoresApi.Dtos;
using BikeStoresApi.Models;

namespace BikeStoresApi.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private static List<Category> categories = new List<Category> {
            new Category(),
            new Category{Id = 1,Name = "Water"}
        };
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetCategoryDto>>> AddCategory(AddCategoryDto newCategory)
        {
            var serviceResponse = new ServiceResponse<List<GetCategoryDto>>();
            categories.Add(_mapper.Map<Category>(newCategory));
            serviceResponse.Data = categories.Select(c => _mapper.Map<GetCategoryDto>(c)).ToList();
            return serviceResponse;
        }
        public async Task<ServiceResponse<List<GetCategoryDto>>> GetCategories()
        {
            var serviceResponse = new ServiceResponse<List<GetCategoryDto>>();
            serviceResponse.Data = categories.Select(c => _mapper.Map<GetCategoryDto>(c)).ToList();
            return serviceResponse;
        }
        public async Task<ServiceResponse<GetCategoryDto>> GetCategoryById(long id)
        {
            var serviceResponse = new ServiceResponse<GetCategoryDto>();
            var category = categories.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetCategoryDto>(category);
            return serviceResponse;
        }
    }
}
