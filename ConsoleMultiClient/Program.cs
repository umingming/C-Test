

using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleMultiClient
{
    internal class Program
    {
        private static Socket client;
        private static NetworkStream input;
        private static NetworkStream output;
        private static string name;

        static void Main(string[] args)
        {
            AccessServer();
            if(client != null)
            {
                Console.WriteLine("[통신 시작] {0}님 환영합니다.\n ☞ ", name);

                SetClient();
            }
        }

        private static void SetClient()
        {
            input = new NetworkStream(client);
            input = new NetworkStream(client);
            byte[] nameByte = Encoding.UTF8.GetBytes(name);
            input.Write(nameByte, 0, nameByte.Length);

            Console.WriteLine("전송");

            Thread sender = new Thread(Sender);
            Thread receiver = new Thread(Receiver);
            sender.Start();
            receiver.Start();
        }

        private static void Receiver()
        {
            while(true) {
                byte[] byteData = new Byte[256];
            }
        }

        private static void Sender()
        {
            string msg;
            while ((msg = Console.ReadLine()) != null)
            {
                byte[] byteData = new byte[msg.Length];
                byteData = Encoding.UTF8.GetBytes(msg + "\n");
            }
        }

        private static void AccessServer()
        {
            try
            {
                Console.WriteLine("[시스템 시작] IP 주소를 입력하세요. \n ☞ ");
                string ip = Console.ReadLine();

                Console.WriteLine("[시스템 시작] Port 번호를 입력하세요. \n ☞ ");
                int port = Convert.ToInt32(Console.ReadLine());

                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                client.Connect(new IPEndPoint(IPAddress.Parse(ip), port));

                Console.WriteLine("[서버 접속 중] 사용자 이름을 입력해주세요. \n ☞ ");
                name = Console.ReadLine();

            }
            catch (Exception)
            {
                Console.WriteLine("[서버 접속 실패] 잘못된 입력입니다.");
            }
        }
    }
}