
using MySqlConnector;


namespace getAcademy_sql.DBFactory
{



    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public DbConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MySqlConnection CreateConnection()
        {
            var connectionString = _configuration.GetConnectionString("MySqlConnection");
            return new MySqlConnection(connectionString);
        }
    }
}
