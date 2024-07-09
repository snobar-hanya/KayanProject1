using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer
{
    public class DataAccess
    {
        private string ConnectionString { get; set; }

        public DynamicParameters Parameters { get; set; } = new DynamicParameters();

        public DataAccess() {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                    .AddJsonFile("appsettings.json", optional: false);
            IConfiguration configuration = builder.Build();
            ConnectionString = configuration.GetConnectionString("DBConnection") ?? string.Empty;
        }

        public IEnumerable<T> ReturnList<T>(string ProcedureName) {
            using (SqlConnection con = new SqlConnection(ConnectionString)) { 
                con.Open();
                return con.Query<T>(ProcedureName, param: Parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
