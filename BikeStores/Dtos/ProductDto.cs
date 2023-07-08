namespace BikeStoresApi.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; }
    }
    public class GetProductDto : ProductDto
    {
        public long Id { get; set; }
        public int ModelYear { get; internal set; }
        public decimal ListPrice { get; internal set; }
        public long CategoryId { get; internal set; }
        public string CategoryName { get; internal set; }
    }
    public class UpdateProductDto : ProductDto
    {
        public long Id { get; set; }
    }
    public class DeleteProductDto : ProductDto
    {
        public long Id { get; set; }
    }
    public  class AddProductDto : ProductDto { }
}
