using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ConsoleClientEx2
{
    internal class Program
    {
        static TcpClient client = null;
        static string name;

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("클라이언트");
                Console.WriteLine("1. 서버 연결");
                Console.WriteLine("2. Message 보내기");

                string key = Console.ReadLine();
                int order = 0;

                if (int.TryParse(key, out order))
                {
                    switch (order)
                    {
                        case 1:
                            {
                                if (client != null)
                                {
                                    Console.WriteLine("이미 연결");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Connect();
                                }
                                break;
                            }
                        case 2:
                            {
                                if (client == null)
                                {
                                    Console.WriteLine("서버와 연결하렴");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    SendMessage();
                                }
                                break;
                            }
                    }
                }

                else
                {
                    Console.WriteLine("잘못 입력");
                    Console.ReadKey();
                }
                Console.Clear();
            }

        }

        static private void SendMessage()
        {
            Console.WriteLine("메시지 입력");
            string message = Console.ReadLine() + "\n";
            byte[] byteData = new byte[message.Length];
            byteData = Encoding.UTF8.GetBytes(message);

            client.GetStream().Write(byteData, 0, byteData.Length);
            Console.WriteLine("전송 성공");
            Console.ReadKey();
        }

        static private void Connect()
        {
            /*
            client = new TcpClient();
            client.Connect("127.0.0.1", 1234);
            Console.WriteLine("서버 연결 성공! 메시지 입력하셈ㅋ");
            Console.ReadKey();
            */

            Console.WriteLine("[시스템 시작] Port 번호를 입력하세요?. \n ☞ ");
            int port = Console.Read();

            Console.WriteLine("[시스템 시작] IP 번호를 입력하세요. \n ☞ ");
            String ip = Console.ReadLine();

            client = new TcpClient();
            client.Connect(ip, port);

            Console.WriteLine("[서버 접속 중] 사용자 이름을 입력해주세요. \n ☞ ");
            name = Console.ReadLine() + "\n";

            byte[] byteData = new byte[name.Length];
            byteData = Encoding.UTF8.GetBytes(name);

            client.GetStream().Write(byteData, 0, byteData.Length);
        }
    }
}
