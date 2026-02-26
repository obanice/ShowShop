using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DB_Context
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
    }
    public class DapperContext : IDapperContext
    {
        private readonly IConfiguration _config;
        private readonly string _connetionString;

        public DapperContext(IConfiguration configuration)
        {
            _config = configuration;
            _connetionString =  _config.GetConnectionString("");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connetionString);
    }
}
