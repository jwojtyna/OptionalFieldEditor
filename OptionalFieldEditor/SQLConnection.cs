using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalFieldEditor
{
    class SQLConnection
    {
        // Create a new SqlConnectionStringBuilder and
        // initialize it with a few name/value pairs.
        SqlConnectionStringBuilder builder =
            new SqlConnectionStringBuilder(GetConnectionString());

        private static string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            return "Server=(local);Integrated Security=SSPI;" +
                "Initial Catalog=AdventureWorks";
        }
    }
}
