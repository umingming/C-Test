using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SocketClient
{
    /*
        MainForm
        - Port와 IP를 입력 받아 서버에 연결할 것
     */
    public partial class MainForm : Form
    {
        TcpClient client;

        int port;
        String ip;

        public MainForm()
        {
            InitializeComponent();
        }

        /*
            Start 메소드; start 버튼을 클릭하면 서버에 접속
            1. 텍스트 박스의 텍스트를 변수에 초기화
            2. IP, Port를 매개로 서버에 연결. if문을 사용한 예외처리 하는 게 나은지?
            3. client를 인자로 NameForm 열고, 해당 폼은 닫기
            4. 예외 처리
                > 잘못된 port 번호; 숫자가 아니거나, 서버가 열리지 않은 경우
                > IP가 올바르지 않은 경우
         */
        private void Start(object sender, EventArgs e)
        {
            try
            {
                port = Convert.ToInt32(txtIp.Text);
                ip = txtPort.Text;

                client = new TcpClient();
                client.Connect(ip, port);

                (new NameForm(client)).Show();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("올바른 Port 번호를 입력해주세요.", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("올바른 IP 주소를 입력해주세요.", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SocketException)
            {
                MessageBox.Show("불가능한 Port 번호입니다.", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
