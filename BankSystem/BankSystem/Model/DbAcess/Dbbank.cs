using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model.DbAcess
{
    class Dbbank
    {
        public SqlConnection sqlConnection = DbConnect.SqlConnection;

        public void transfer(int user1, int amount, int user2)
        {
            sqlConnection.Open();
            string sql = "select * from Customer";
            SqlCommand dbCmd;
            dbCmd = new SqlCommand(sql, sqlConnection);
            dbCmd.Connection = sqlConnection;
            IDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                Customer c = new Customer();
                c.Adress = (string) dbReader["sss"];
            }
        }
    }
}
