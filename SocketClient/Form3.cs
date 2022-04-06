using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SocketClient
{
    public partial class Form3 : Form
    {
        TcpClient client;
        ArrayList msgList;

        public Form3(TcpClient client)
        {
            this.client = client;
            this.msgList = new ArrayList(100);
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (textMsg != null)
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
                textContent.Text += msgList[msgList.Count - 1];
            }

            if (msgList.Count == 4)
            {
                btnRemove.Enabled = true;
                btnInput.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = (int)selectMsg.SelectedIndex;
            msgList.RemoveAt(index);
            selectMsg.Items.RemoveAt(index);

            UpdateChat();

            btnRemove.Enabled = false;
            btnInput.Enabled = true;
        }

        private void UpdateChat()
        {
            textContent.Text = "";

            for (int i = 0; i < msgList.Count; i++)
            {
                textContent.Text += msgList[i];
            }
        }
    }
}
