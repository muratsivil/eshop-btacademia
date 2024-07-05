using eshop.Application.DataTransferObjects.Responses;

namespace eshop.Application.Services
{
    public class ProductService
    {
        private List<ProductCardResponse> _products;
        public ProductService()
        {
            _products = new List<ProductCardResponse>()
            {
                new(){ Id= 1, Name="POCO", Description="8GB RAM", Price=10000 },
                new(){ Id= 2, Name="Samsung", Description="16GB RAM", Price=17000 },
                new(){ Id= 3, Name="IPAD", Description="8GB RAM", Price=25000 },
                new(){ Id= 4, Name="Homend", Description="8GB RAM", Price=5000 },
            };
        }
        public List<ProductCardResponse> GetProductCardResponses()
        {
            return _products;
        }
    }
}
