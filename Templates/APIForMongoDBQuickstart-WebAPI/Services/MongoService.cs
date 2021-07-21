using MongoDB.Driver;
using APIForMongoDBQuickstart_WebAPI.Models;

namespace APIForMongoDBQuickstart_WebAPI.Services
{
    public class MongoService
    {
        private static MongoClient _client;

        public MongoService(IDatabaseSettings settings)
        {
            _client = new MongoClient(settings.MongoConnectionString);
        }

        public MongoClient GetClient()
        {
            return _client;
        }
    }
}