using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model.DbAcess
{
    class DbConnect
    {
        public static SqlConnection SqlConnection { get; set; }

        public DbConnect()
        {
            SqlConnection = new SqlConnection();
            SqlConnection.ConnectionString = @"Data Source = localhost; Initial Catalog = BankDB; Integrated Security=True";
            
        }
    }
}
