using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using Dapper;
using System;
using System.Collections.Generic;
using getAcademy_sql.DBFactory;

namespace getAcademy_sql.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public TestController(IDbConnectionFactory dbConnectionConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionConnectionFactory;
        }


        [HttpGet]
        public IActionResult TestConnection()
        {
           
            try
            {
                using var connection = _dbConnectionFactory.CreateConnection();
                connection.Open();

                connection.Close();
                return Ok("Database connection successful!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error connecting to the database: {ex.Message}");
            }
        }
    }
}