using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\v11.0;attachdbfilename=|DataDirectory|\NorthwindDB.mdf;;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, conn);

            #region 查詢
            #region 單一資料表查詢
            cmd.CommandText = "select * from customers";
            conn.Open();
            var result = cmd.ExecuteReader();
            while(result.Read())
            {
                Console.WriteLine(result[0]);
            }
            #endregion
            #endregion

            conn.Close();
            Console.Read();
        }
    }
}
