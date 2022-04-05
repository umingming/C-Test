using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WinformsClientEx1
{

    public partial class Form1 : Form
    {
        TcpClient client;

        String name;
        String msg;
        String ip;
        int port;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port = Convert.ToInt32(textPort.Text);
            ip = textIp.Text;

            client = new TcpClient();
            client.Connect(ip, port);

            name = textName.Text;
            byte[] byteData = new byte[name.Length];
            byteData = Encoding.UTF8.GetBytes(name + "\n");
            client.GetStream().Write(byteData, 0, byteData.Length);

            textChat.Text = String.Format("[통신 시작] {0}님 환영합니다.\r\n", name);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            msg = textMsg.Text;
            textMsg.Text = "";

            byte[] byteData = new byte[msg.Length];
            byteData = Encoding.UTF8.GetBytes(msg + "\n");
            client.GetStream().Write(byteData, 0, byteData.Length);

            byteData = new Byte[256];
            String responseData = String.Empty;
            Int32 bytes = client.GetStream().Read(byteData, 0, byteData.Length);
            responseData = System.Text.Encoding.UTF8.GetString(byteData, 0, bytes);

            textChat.Text += responseData;
        }
    }
}
