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
        private Client client;
        private Notification box;

        public MainForm()
        {
            box = new Notification();
            InitializeComponent();
        }

        /*
            Start 메소드; start 버튼을 클릭하면 서버에 접속
            1. ip와 port 변수 선언 후 해당 텍스트를 초기화
            2. 클래이언트 객체 생성
            3. NameForm을 호출하고, 현재 폼은 안 보이게 함.
            4. 예외 처리; box 객체의 Display 메소드 사용
                > 텍스타 박스 입력이 잘못된 경우
                > 그 외 오류
         */
        private void Start(object sender, EventArgs e)
        {
            try
            {
                String ip = txtIp.Text;
                int port = Convert.ToInt32(txtPort.Text);

                client = new Client(ip, port);
                (new NameForm(client)).Show();
                this.Visible = false;
            }
            catch (FormatException)
            {
                box.DisplayWarning("Port 번호");
            }
            catch (Exception)
            {
                box.DisplayError();
            }
        }

        /*
            IsEnterKey; port 박스에서 엔터를 누를 경우 실행시킴
            1. if문 입력 키가 엔터가 아닌지?
                > return
            2. Start 호출
         */
        private void IsEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            
            Start(sender, e);
        }
    }
}
