using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace SocketClient
{
    internal class Client
    {
		private TcpClient client;

		private String name;
		private String msg;

		private StreamWriter sender;
		private StreamReader receiver;

		public Client(String ip, int port)
        {
			this.client = new TcpClient(ip, port);
			this.sender = new StreamWriter(client.GetStream());
			this.receiver = new StreamReader(client.GetStream());
        }

		public void SetName(String name)
        {
			this.name = name;
			sender.WriteLine(this.name);
        }

		public String Echo(String msg)
        {
			sender.WriteLine(msg);
			sender.Flush();
			return receiver.ReadLine();
		}

		public void Close()
        {
			receiver.Close();
			sender.Close();
			client.Close();
        }
	}
}
