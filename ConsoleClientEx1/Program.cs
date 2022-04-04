using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ConsoleClientEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("클라이언트 콘솔");
            TcpClient client = new TcpClient();

            client.Connect("127.0.0.1", 1234);
            byte[] name = Encoding.UTF8.GetBytes("유미");

            client.GetStream().Write(name, 0, name.Length);

            client.Close();

            Console.WriteLine(System.Text.Encoding.UTF8.GetString(name));
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i].ToString() + "//");
            }
            Console.ReadLine();
        }
    }
}
