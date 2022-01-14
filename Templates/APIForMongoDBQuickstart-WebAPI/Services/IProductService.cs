using APIForMongoDBQuickstart_WebAPI.Models;

namespace APIForMongoDBQuickstart_WebAPI.Services
{
    public interface IProductService
    {
        public Task<List<Product>> GetNAsync(int n);
        public Task<Product> GetBySkuAsync(string sku);
        public Task CreateAsync(Product product);
        public Task<Product> UpdateAsync(Product product);
        public Task DeleteAsync(string sku);
    }
}
