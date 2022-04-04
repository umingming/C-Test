using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ConsoleClientEx3
{
    internal class Program
    {
        TcpClient client;

        String name;
        String msg;
        String ip;
        int port;

        private Program()
        {
            accessServer();

            if(client != null)
            {
                setClient();
                communicate();
            }
        }

        private void communicate()
        {
            throw new NotImplementedException();
        }

        private void setClient()
        {
            throw new NotImplementedException();
        }

        private void accessServer()
        {
            Console.WriteLine("[시스템 시작] Port 번호를 입력하세요. \n ☞ ");
            port = Console.Read();

            Console.WriteLine("[시스템 시작] IP 번호를 입력하세요. \n ☞ ");
            ip = Console.ReadLine();

            client = new TcpClient();
            client.Connect(ip, port);

            Console.WriteLine("[서버 접속 중] 사용자 이름을 입력해주세요. \n ☞ ");
            name = Console.ReadLine();

            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
