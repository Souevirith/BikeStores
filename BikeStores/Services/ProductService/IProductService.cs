using BikeStoresApi.Dtos;
using BikeStoresApi.Models;

namespace BikeStoresApi.Services.ProductService
{
    public interface IProductService
    {
        
        Task<ServiceResponse<List<GetProductDto>>> GetProductAsync();
        Task<ServiceResponse<GetProductDto>> GetProductById(long id);
        

        Task<ServiceResponse<List<GetProductDto>>> AddProduct(AddProductDto addProductDto);

        Task<ServiceResponse<GetProductDto>> UpdateProduct(UpdateProductDto updateProductDto);
        Task<ServiceResponse<List<GetProductDto>>> DeleteProduct(long id);
       

    }
}
