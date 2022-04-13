﻿using System;
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
        Notification box;

        public MainForm()
        {
            box = new Notification();
            InitializeComponent();
        }

        /*
            Start 메소드; start 버튼을 클릭하면 서버에 접속
            1. ip와 port 변수 선언 후 해당 텍스트를 초기화
            2. if문 port가 범위 내인지?
                > ip, port를 매개로 Connect 호출
                > 범위 내가 아니면 FormatException 예외 생성
            3. 예외 처리; box 객체의 Display 메소드 사용
                > 잘못된 port 번호; 범위 내의 숫자가 아니거나, 서버가 열리지 않음.
                > IP가 올바르지 않은 경우
                > 그 외 오류
         */
        private void Start(object sender, EventArgs e)
        {
            try
            {
                String ip = txtIp.Text;
                int port = Convert.ToInt32(txtPort.Text);

                if(port > 0 && port < 65536)
                {
                    Connect(ip, port);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                box.DisplayWarning("Port 번호");
            }
            catch (SocketException)
            {
                box.DisplayWarning("접속 정보");
            }
            catch (Exception)
            {
                box.DisplayError();
            }
        }

        /*
            Connect 메소드; 서버에 접속
            1. IP, Port를 매개로 서버에 연결.
            2. client를 인자로 NameForm 열고, 해당 폼은 숨기기
         */
        private void Connect(string ip, int port)
        {
            TcpClient client = new TcpClient();
            client.Connect(ip, port);
            (new NameForm(client)).Show();
            this.Visible = false;
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
