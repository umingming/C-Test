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

        /*
            SendMsg
            1. if문 메시지 내용을 msg 변수에 초기화 후, 값이 존재하는지
                > Communication 메소드 호출
                > 텍스트 박스 비움.
            2. 입력 값이 없을 경우 안내
         */
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

        /*
            Communicate
            1. byte 배열 생성 후, msg 저장
            2. msg를 서버에 전송
            3. byte 배열 초기화
            4. 서버로부터 받은 메시지를 변환해 echo 변수에 초기화
            5. if문 echo가 null이 아닌지?
                > AddMsg 호출
         */
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

        /*
            AddMsg
            1. echo를 msgList와 콤보 박스, 대화 내용에 추가함.
            2. if msgList의 크기가 최대 값을 초과하는지?
                > 입력을 막고 삭제를 보이게 함.
         */
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

        /*
            RemoveMsg
            1. 콤보 박스에 선택된 index를 변수에 초기화
            2. if문 index가 유효한지?
                > RemoveMsg와 UpdateChat 호출
                > 입력을 열고, 삭제를 닫기
            3. 메시지를 잘못 선택한 경우 안내
         */
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

        /*
            RemoveAtMsg
            1. 특정 인덱스의 메시지를 지움.
         */
        private void RemoveAtMsg()
        {
            msgList.RemoveAt(index);
            cmbMsg.Items.RemoveAt(index);
        }

        /*
            UpdateChat
            1. 대화 박스 초기화
            2. for문 ArrayList의 크기 반복
                > 대화 내용에 해당 요소 추가
         */ 
        private void UpdateChat()
        {
            txtChat.Text = "";

            for (int i = 0; i < msgList.Count; i++)
            {
                txtChat.Text += msgList[i];
            }
        }

        /*
            IsEnterKey
            1. if문 입력 키가 엔터인지?
                > SendMsg 호출
         */
        private void IsEnterKey(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendMsg(sender, e);
            }
            
        }
    }
}
