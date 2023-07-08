namespace BikeStoresApi.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int ModelYear { get; set; }
        public decimal ListPrice { get; set; }
        public long CategoryId { get; set; }
    }
        
}
