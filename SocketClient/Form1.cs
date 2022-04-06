using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SocketClient
{
    public partial class Form1 : Form
    {
        TcpClient client;

        int port;
        String ip;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            port = Convert.ToInt32(textPort.Text);
            ip = textIp.Text;

            client = new TcpClient();
            client.Connect(ip, port);

            (new Form2(client)).Show();
            this.Close();
        }
    }
}
