using System;
using System.Net.Sockets;
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

        private void Start(object sender, EventArgs e)
        {
            try
            {
                port = Convert.ToInt32(textPort.Text);
                ip = textIp.Text;

                client = new TcpClient();
                client.Connect(ip, port);

                (new Form2(client)).Show();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("올바른 Port 번호를 입력해주세요.", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(SocketException)
            {
                MessageBox.Show("Port 번호, 또는 IP 주소를 확인해주세요.", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
