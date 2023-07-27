using DriverApp.Configurations;
using DriverApp.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DriverApp.Services
{
    public class DriverService : IDriverService
    {
        private readonly IMongoCollection<Driver> driverCollection;

        public DriverService(IOptions<DatabaseSettings> databaseSetting)
        {
            var mongoClient = new MongoClient(databaseSetting.Value.ConnectionString);
            var mongoDb = mongoClient.GetDatabase(databaseSetting.Value.DatabaseName);
            driverCollection = mongoDb.GetCollection<Driver>(databaseSetting.Value.CollectionName);
        }

        public async Task<List<Driver>> GetDriversAsync() => await driverCollection.Find(x => true).ToListAsync();
        public async Task<Driver> GetDriverAsync(string id) => await driverCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        public async Task CreateDriverAsync(Driver driver) => await driverCollection.InsertOneAsync(driver);
        public async Task UpdateDriverAsync(Driver driver) => await driverCollection.ReplaceOneAsync(x => x.Id == driver.Id, driver);
        public async Task DeleteDriverAsync(string id) => await driverCollection.DeleteOneAsync(x => x.Id == id);


    }
}
