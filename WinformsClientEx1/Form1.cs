using System;
using System.Collections;
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

        int port;
        String ip;
        String name;
        ArrayList msgList;

        public Form1()
        {
            InitializeComponent();
            msgList = new ArrayList(100);
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
            if(textMsg != null)
            {
                String msg = textMsg.Text;
                textMsg.Text = "";

                byte[] byteData = new byte[msg.Length];
                byteData = Encoding.UTF8.GetBytes(msg + "\n");
                client.GetStream().Write(byteData, 0, byteData.Length);

                byteData = new Byte[256];
                Int32 bytes = client.GetStream().Read(byteData, 0, byteData.Length);
                msgList.Add(System.Text.Encoding.UTF8.GetString(byteData, 0, bytes));

                selectMsg.Items.Add(msgList[msgList.Count - 1]);
                textChat.Text += msgList[msgList.Count - 1];
            }
                
            if(msgList.Count == 4)
            {
                btnRemove.Enabled = true;
                btnInput.Enabled = false;                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = (int)selectMsg.SelectedIndex;
            msgList.Remove(index);
            selectMsg.Items.RemoveAt(index);

            UpdateChat();

            btnRemove.Enabled = false;
            btnInput.Enabled = true;
        }

        private void UpdateChat()
        {
            textChat.Text = "";

            for(int i=0; i<msgList.Count; i++)
            {
                textChat.Text += msgList[i];
            }
        }
    }
}
