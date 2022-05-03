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
        Notification box;

        public NameForm(TcpClient client)
        {
            this.client = client;
            box = new Notification();
            InitializeComponent();
        }

        /*
            EnterName 메소드
            1. if문 텍스트 박스가 공백이 아닌지?
                > SetName 호출
                > client를 인자로 chatForm 열고, 해당 폼은 닫기
            2. 이름이 없으면 안내
         */
        private void EnterName(object sender, EventArgs e)
        {
            if(!txtName.Text.Equals(""))
            {
                SetName();
        
                (new ChatForm(client)).Show();
                this.Visible = false;
            }
            else
            {
                box.DisplayWarning("이름 입력");
            }
        }

        /*
            SetName 메소드
            1. 입력 값을 byte로 형변환해 저장
            2. 서버에 byte 배열 전송
         */
        private void SetName()
        {
            byte[] name = new byte[txtName.TextLength];
            name = Encoding.UTF8.GetBytes(txtName.Text + "\n");
            client.GetStream().Write(name, 0, name.Length);
        }

        /*
            IsEnterKey
            1. if문 입력 키가 엔터가 아닌지?
                > return
            2. Start 호출
         */
        private void IsEnterKey(object sender, KeyEventArgs e)
        {
            if (!e.Alt || e.KeyCode != Keys.Enter) return;

            EnterName(sender, e);
        }
    }
}
