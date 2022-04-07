using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SocketClient
{
    public partial class NameForm : Form
    {
        TcpClient client;
        String name;

        public NameForm(TcpClient client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void EnterName(object sender, EventArgs e)
        {
            if(!(name = txtName.Text).Equals(""))
            {
                byte[] byteData = new byte[name.Length];
                byteData = Encoding.UTF8.GetBytes(name + "\n");
                client.GetStream().Write(byteData, 0, byteData.Length);

                ChatForm chatForm = new ChatForm(client);
                chatForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("이름을 입력해주세요.", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
