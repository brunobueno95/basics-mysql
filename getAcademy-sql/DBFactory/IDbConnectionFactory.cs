


using MySqlConnector;

namespace getAcademy_sql.DBFactory
{
    public interface IDbConnectionFactory
    {
        MySqlConnection CreateConnection();
    }
}
