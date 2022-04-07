using System;
using System.Collections;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SocketClient
{
    public partial class ChatForm : Form
    {
        TcpClient client;
        ArrayList msgList;

        String msg;
        String echo;
        int index;
        int maxMsg;

        public ChatForm(TcpClient client)
        {
            this.client = client;
            this.msgList = new ArrayList(100);
            this.maxMsg = 100;
            InitializeComponent();
        }

        private void SendMsg(object sender, EventArgs e)
        {
            if (!(msg = txtMsg.Text).Equals(""))
            {
                Communicate();
                txtMsg.Text = "";
            }
            else
            {
                MessageBox.Show("메시지를 입력해주세요.", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Communicate()
        {
            byte[] msgData = new byte[msg.Length];
            msgData = Encoding.UTF8.GetBytes(msg + "\n");
            client.GetStream().Write(msgData, 0, msgData.Length);

            msgData = new Byte[256];
            Int32 bytes = client.GetStream().Read(msgData, 0, msgData.Length);
            echo = System.Text.Encoding.UTF8.GetString(msgData, 0, bytes);

            if (echo != null)
            {
                AddMsg();
            }
        }

        private void AddMsg()
        {
            msgList.Add(echo);
            cmbMsg.Items.Add(echo);
            txtChat.Text += echo;

            if (msgList.Count > maxMsg)
            {
                btnRemove.Visible = true;
                cmbMsg.Visible = true;
                btnInput.Visible = false;
                txtMsg.Visible = false;
            }
        }

        private void RemoveMsg(object sender, EventArgs e)
        {
            index = (int)cmbMsg.SelectedIndex;

            if(index > -1)
            {
                RemoveAtMsg();
                UpdateChat();

                btnRemove.Visible = false;
                cmbMsg.Visible = false;
                btnInput.Visible = true;
                txtMsg.Visible = true;
            }
            else
            {
                MessageBox.Show("삭제할 메시지를 확인해주세요.", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RemoveAtMsg()
        {
            msgList.RemoveAt(index);
            cmbMsg.Items.RemoveAt(index);
        }

        private void UpdateChat()
        {
            txtChat.Text = "";

            for (int i = 0; i < msgList.Count; i++)
            {
                txtChat.Text += msgList[i];
            }
        }

        private void IsEnterKey(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendMsg(sender, e);
            }
        }
    }
}
