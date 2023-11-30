using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace getAcademy_sql.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IDbConnection _dbConnection;

        public TestController(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }


        [HttpGet]
        public IActionResult TestConnection()
        {
            try
            {
                _dbConnection.Open();
                // If the connection is successfully opened, it means the configuration is correct.
                _dbConnection.Close();
                return Ok("Database connection successful!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error connecting to the database: {ex.Message}");
            }
        }
    }
}