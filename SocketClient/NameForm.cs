using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SocketClient
{
    /*
        NameForm
        - 이름을 입력 받아 서버에 전달
     */
    public partial class NameForm : Form
    {
        TcpClient client;

        public NameForm(TcpClient client)
        {
            this.client = client;
            InitializeComponent();
        }

        /*
            EnterName 메소드
            1. if문 텍스트 박스의 내용을 name 변수에 저장하고, 해당 값이 존재하는지 확인
                > name의 length를 길이로 하는 바이트 배열 생성
                > name 변수를 byte로 형변환해 저장
                > 서버에 byte 배열 전송
                > client를 인자로 cahtForm 열고, 해당 폼은 닫기
            2. 이름이 없으면 안내
         */
        private void EnterName(object sender, EventArgs e)
        {
            if(!txtName.Text.Equals(""))
            {
                String name = txtName.Text;
                byte[] nameData = new byte[name.Length];
                nameData = Encoding.UTF8.GetBytes(name + "\n");
                client.GetStream().Write(nameData, 0, nameData.Length);

                (new ChatForm(client)).Show();
                this.Visible = false;
            }
            else
            {
                Message.Show("이름을 입력해주세요.", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*
            IsEnterKey
            1. if문 입력 키가 엔터가 아닌지?
                > return
            2. Start 호출
         */
        private void IsEnterKey(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter) return;

            EnterName(sender, e);
        }

        /*
            Quit
            1. 어플리케이션을 종료함.
         */
        private void Quit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
