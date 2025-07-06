using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.DataAccess
{
    public static class DBConnection
    {
        public static string GetConnectionString()
        {
            string connectionString = Program.Configuration.GetConnectionString("eShiftDBConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("eShiftDBConnection connection string not found or is empty in appsettings.json. Please ensure it's configured correctly.");
            }

            return connectionString;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
