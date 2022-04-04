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
            while((msg = Console.ReadLine()) != null)
            {
                byte[] byteData = new byte[msg.Length];
                byteData = Encoding.UTF8.GetBytes(msg + "\n");
                client.GetStream().Write(byteData, 0, byteData.Length);

                byteData = new Byte[256];
                String responseData = String.Empty;
                Int32 bytes = client.GetStream().Read(byteData, 0, byteData.Length);
                responseData = System.Text.Encoding.UTF8.GetString(byteData, 0, bytes);

                Console.Write("{0} \n ☞ ", responseData);

//              Console.Write("{0} \n ☞ ", msg);
            }
        }

        private void setClient()
        {
            byte[] byteData = new byte[name.Length];
            byteData = Encoding.UTF8.GetBytes(name);
            client.GetStream().Write(byteData, 0, byteData.Length);

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

            byte[] byteData = new byte[name.Length];
            byteData = Encoding.UTF8.GetBytes(name + "\n");

            client.GetStream().Write(byteData, 0, byteData.Length);
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
