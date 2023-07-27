using DriverApp.Models;

namespace DriverApp.Services
{
    public interface IDriverService
    {
        Task CreateDriverAsync(Driver driver);
        Task DeleteDriverAsync(string id);
        Task<Driver> GetDriverAsync(string id);
        Task<List<Driver>> GetDriversAsync();
        Task UpdateDriverAsync(Driver driver);
    }
}