using APIForMongoDBQuickstart_WebAPI.Models;
using MongoDB.Driver;

namespace APIForMongoDBQuickstart_WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _products;        

        public ProductService(IMongoDatabase db)
        {
            _products = db.GetCollection<Product>(typeof(Product).Name);
        }

        public Task<List<Product>> GetNAsync(int n)
        {
            return  _products.Find(product => true).Limit(n).ToListAsync();
        }

        public Task<Product> GetBySkuAsync(string sku)
        {
            return _products.Find(p => p.Sku == sku).FirstOrDefaultAsync();
        }

        public Task CreateAsync(Product product)
        {
            return _products.InsertOneAsync(product);
        }

        public Task<Product> UpdateAsync(Product update)
        {
            return _products.FindOneAndReplaceAsync(
                Builders<Product>.Filter.Eq(p => p.Sku, update.Sku), 
                update, 
                new FindOneAndReplaceOptions<Product> { ReturnDocument = ReturnDocument.After });
        }

        public Task DeleteAsync(string sku)
        {
            return _products.DeleteOneAsync(p => p.Sku == sku);
        }
    }
}