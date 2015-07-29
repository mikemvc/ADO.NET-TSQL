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
//            cmd.CommandText = @"SELECT TOP 1000 EmployeeID, 
//                CONVERT(VARCHAR,EmployeeID) + '/' 
//                + LastName + ',' + FirstName FROM Employees";
//            var result2 = cmd.ExecuteReader();
//            while(result2.Read())
//            {
//                Console.WriteLine(result2[1]);
//            }
            #endregion

            #region JOIN的簡寫
//            cmd.CommandText = @"SELECT E.LastName + ',' + E.FirstName AS FullName,
//                    O.OrderID, O.OrderDate 
//                    FROM Employees E, Orders O
//                    WHERE O.EmployeeID = E.EmployeeID";
//            var result3 = cmd.ExecuteReader();
//            while(result3.Read())
//            {
//                Console.WriteLine(result3[0] + " " + result3[1] + " " + result3[2]);
//            }
            #endregion

            #region INNER JOIN
//            cmd.CommandText = @"SELECT E.LastName + ',' + E.FirstName AS FullName,
//                    O.OrderID, O.OrderDate 
//                    FROM Employees E
//                    JOIN Orders O ON O.EmployeeID = E.EmployeeID";
//            var result4 = cmd.ExecuteReader();
//            while (result4.Read())
//            {
//                Console.WriteLine(result3[0] + " " + result3[1] + " " + result3[2]);
//            }
            #endregion

            #region LEFT OUTER JOIN
//            cmd.CommandText = @"SELECT * FROM Customers C 
//                            LEFT OUTER JOIN Orders O ON O.CustomerID = C.CustomerID";
//            var result5 = cmd.ExecuteReader();            
//            while (result5.Read())
//            {
//                Console.WriteLine(result5[0] + " " + result5[1] + " " + result5[2]);
//            }
            #endregion

            #region RIGHT OUTER JOIN
//            cmd.CommandText = @"SELECT * FROM Customers C 
//                            RIGHT JOIN Orders O ON O.CustomerID = C.CustomerID";
//            var result6 = cmd.ExecuteReader();
//            while (result6.Read())
//            {
//                Console.WriteLine(result6[0] + " " + result6[1] + " " + result6[2]);
//            }
            #endregion

            #region FULL OUTER JOIN
            cmd.CommandText = @"SELECT * FROM Customers C 
                            FULL OUTER JOIN Orders O ON O.CustomerID = C.CustomerID";
            var result7 = cmd.ExecuteReader();
            while (result7.Read())
            {
                Console.WriteLine(result7[0] + " " + result7[1] + " " + result7[2]);
            }
            #endregion
            #endregion

            conn.Close();
            Console.Read();
        }
    }
}
