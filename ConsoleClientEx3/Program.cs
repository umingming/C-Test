using System;
using System.Collections.Generic;
using System.IO;
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

        StreamReader reader;
        StreamWriter writer;

        private Program()
        {
            accessServer();
            writer = new StreamWriter(client.GetStream());
            reader = new StreamReader(client.GetStream());

            if(client != null)
            {
                setClient();
                communicate();
            }
        }

        private void communicate()
        {
            while((msg = Console.ReadLine()) != null)
            {
                writer.WriteLine(msg);
                writer.Flush();

                Console.Write("{0} ☞ ", reader.ReadLine());
            }
        }

        private void setClient()
        {
            writer.WriteLine(name);
            writer.Flush();

            Console.Write("[통신 시작] {0}님 환영합니다. \n ☞ ", name);
        }

        private void accessServer()
        {
            Console.Write("[시스템 시작] Port 번호를 입력하세요. \n ☞ ");
            port = Convert.ToInt32(Console.ReadLine());

            Console.Write("[시스템 시작] IP 번호를 입력하세요. \n ☞ ");
            ip = Console.ReadLine();

            client = new TcpClient();
            client.Connect(ip, port);

            Console.Write("[서버 접속 중] 사용자 이름을 입력해주세요. \n ☞ ");
            name = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
