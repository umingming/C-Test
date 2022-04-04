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
            byte[] buf = Encoding.Default.GetBytes("유미");

            client.GetStream().Write(buf, 0, buf.Length);

            byte[] buf2 = Encoding.Default.GetBytes("안녕ㅋ");

            client.GetStream().Write(buf2, 0, buf2.Length);
            client.Close();
        }
    }
}
