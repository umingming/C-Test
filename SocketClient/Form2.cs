using System;
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

        private void EnterName(object sender, EventArgs e)
        {
            if(!(name = textName.Text).Equals(""))
            {
                byte[] byteData = new byte[name.Length];
                byteData = Encoding.UTF8.GetBytes(name + "\n");
                client.GetStream().Write(byteData, 0, byteData.Length);

                Form3 chatForm = new Form3(client);
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
