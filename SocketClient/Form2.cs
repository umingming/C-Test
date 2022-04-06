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
    public partial class Form2 : Form
    {
        TcpClient client;
        String name;

        public Form2(TcpClient client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            name = textName.Text;
            byte[] byteData = new byte[name.Length];
            byteData = Encoding.UTF8.GetBytes(name + "\n");
            client.GetStream().Write(byteData, 0, byteData.Length);

            Form3 chatForm = new Form3(client);
            chatForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
