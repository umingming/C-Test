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
        private static string provider = "OraOLEDB.Oracle";
        private static string dataSource = "orcl.mdb"; // 뭘로 해도 에러가 안 나네;
        private static string userId = "runch";
        private static string password = "java1234";

        public static OleDbConnection connection;

        static void Main(string[] args)
        {
            string connectionString = "Provider=MSDAORA.1;Data Source=orcl;User Id=runch;Password=java1234";

            connection = new OleDbConnection(connectionString);
            connection.Open();
            Console.Write("[서버 접속 중] 사용자 이름을 입력해주세요. \n ☞ ");
            String name = Console.ReadLine();
        }
    }
}
