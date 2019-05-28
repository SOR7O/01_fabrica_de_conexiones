using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fabrica_De_Conexiones
{
    internal class MyConnectionSql
    {
        private class MyConnectionSql : MyConnection
        {
            public MyConnectionSql(DataProvider theDataProvider) : base(theDataProvider)
            {
                // Utilizando un ConnectionString para realizar la conexión
                // con el servidor SQL Server
                SqlConnection connectionString = new SqlConnection(@"server = (local)\sqlexpress;");
            }
        }
    }
}
