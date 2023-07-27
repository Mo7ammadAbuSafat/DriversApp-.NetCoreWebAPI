using DriverApp.Models;
using DriverApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DriverApp.Controllers
{
    [Route("api/drivers")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IDriverService driverService;

        public DriversController(IDriverService driverService)
        {
            this.driverService = driverService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDrivers()
        {
            var drivers = await driverService.GetDriversAsync();
            return Ok(drivers);
        }

        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> GetDriver(string id)
        {
            var driver = await driverService.GetDriverAsync(id);
            if (driver == null)
            {
                return NotFound();
            }
            return Ok(driver);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDriver(Driver driver)
        {
            await driverService.CreateDriverAsync(driver);
            return CreatedAtAction(nameof(GetDriver), new { id = driver.Id }, driver);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> UpdateDriver(string id, Driver driver)
        {
            var existingDriver = await driverService.GetDriverAsync(id);
            if (existingDriver == null)
            {
                return BadRequest();
            }

            driver.Id = existingDriver.Id;

            await driverService.UpdateDriverAsync(driver);
            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> DeleteDriver(string id)
        {
            var existingDriver = await driverService.GetDriverAsync(id);
            if (existingDriver == null)
            {
                return BadRequest();
            }

            await driverService.DeleteDriverAsync(id);
            return NoContent();
        }



    }
}
