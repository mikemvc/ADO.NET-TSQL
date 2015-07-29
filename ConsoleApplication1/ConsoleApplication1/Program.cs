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
            conn.Open();

            #region 查詢
            #region 單一資料表查詢
            //cmd.CommandText = "select * from customers";
            //var result1 = cmd.ExecuteReader();
            //while (result.Read())
            //{
            //    Console.WriteLine(result1[0]);
            //}
            #endregion
            #region 雙欄位合併
            cmd.CommandText = @"SELECT TOP 1000 EmployeeID, 
                CONVERT(VARCHAR,EmployeeID) + '/' 
                + LastName + ',' + FirstName FROM Employees";
            var result2 = cmd.ExecuteReader();
            while(result2.Read())
            {
                Console.WriteLine(result2[1]);
            }
            #endregion

            #endregion

            conn.Close();
            Console.Read();
        }
    }
}
