using System;
using System.Collections;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SocketClient
{
    /*
        ChatForm
        - 메시지를 입력 받고 서버와 통신 내용을 텍스트 박스에 출력
     */
    public partial class ChatForm : Form
    {
        TcpClient client;
        ArrayList msgList;

        String echo;
        int max;

        public ChatForm(TcpClient client)
        {
            this.client = client;
            this.msgList = new ArrayList(200);
            InitializeComponent();
        }

        /*
            SendMsg
            1. if문 메시지 내용을 msg 변수에 초기화 후, 값이 존재하는지
                > Communication 메소드 호출
                > 텍스트 박스 비움.
            2. 입력 값이 없을 경우 안내
         */
        private void SendMsg(object sender, EventArgs e)
        {
            if (max == 0)
            {
                MessageBox.Show("최대 메시지 갯수를 정해주세요.", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((txtMsg.Text).Equals(""))
            {
                MessageBox.Show("메시지를 입력해주세요.", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Communicate(txtMsg.Text);
                txtMsg.Text = "";
            }
        }

        /*
            Communicate
            1. byte 배열 생성 후, msg 저장
            2. msg를 서버에 전송
            3. byte 배열 초기화
            4. 서버로부터 받은 메시지를 변환해 echo 변수에 초기화
            5. if문 echo가 null이 아닌지?
                > AddMsg 호출
         */
        private void Communicate(String msg)
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

        /*
            AddMsg
            1. echo를 msgList와 콤보 박스, 대화 내용에 추가함.
            2. if msgList의 크기가 최대 값을 초과하는지?
                > 입력을 막고 삭제를 보이게 함.
         */
        private void AddMsg()
        {
            msgList.Add(echo);
            rtxChat.Text += echo;

            if (msgList.Count > max)
            {
                UpdateChat();
            }
        }

        /*
            UpdateChat
            1. 대화 박스 초기화
            2. for문 ArrayList의 크기 반복
                > 대화 내용에 해당 요소 추가
         */
        private void UpdateChat()
        {
            msgList.RemoveAt(0);
            rtxChat.Text = "";

            for (int i = 0; i < msgList.Count; i++)
            {
                rtxChat.Text += msgList[i];
            }
        }

        /*
            SetMax; 콤보박스의 선택 값에 따라 메시지 보관 갯수를 설정함.
            1. 콤보 박스 값을 int로 변환해 max 변수에 초기화함.
         */
        private void SetMax(object sender, EventArgs e)
        {
            max = Convert.ToInt32(cmbMax.SelectedItem);
        }

        /*
            IsEnterKey
            1. if문 입력 키가 엔터인지?
                > SendMsg 호출
         */
        private void IsEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            SendMsg(sender, e);
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
