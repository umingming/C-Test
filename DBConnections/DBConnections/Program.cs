using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DBConnections
{
    internal class Program
    {
        public static OleDbConnection connection;

        static void Main(string[] args)
        {
            string connectionString = string.Format("Provider=OraOLEDB.Oracle;" +
            "OLEDB.NET=true;" +
            "PLSQLRSet=true;" +
            "Data Source=orcl;" +
            "User Id=runch;" +
            "Password=java1234;");

            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                Console.Write("[성공]");
                Console.ReadLine();
            }
            catch
            {
                Console.Write("[실패]");
                Console.ReadLine();
            }
        }
    }
}
