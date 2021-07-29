using MongoDB.Driver;
using System.Threading.Tasks;
using System.Collections.Generic;
using APIForMongoDBQuickstart_WebAPI.Models;

namespace APIForMongoDBQuickstart_WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _products;        

        public ProductService(MongoService mongo, IDatabaseSettings settings)
        {
            var db = mongo.GetClient().GetDatabase(settings.DatabaseName);
            _products = db.GetCollection<Product>(settings.ProductCollectionName);
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