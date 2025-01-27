﻿using System;
using System.Windows.Forms;

namespace SocketClient
{
    /*
        NameForm
        - 이름을 입력 받아 서버에 전달
     */
    public partial class NameForm : Form
    {
        private Client client;
        private Notification box;

        public NameForm(Client client)
        {
            this.client = client;
            box = new Notification();
            InitializeComponent();
        }

        /*
            EnterName 메소드
            1. if문 텍스트 박스가 공백이 아닌지?
                > SetName 호출; 클라이언트 이름 설정
                > client를 인자로 chatForm 열고, 해당 폼은 닫기
            2. 텍스트 박스가 비었으면 안내
         */
        private void EnterName(object sender, EventArgs e)
        {
            if(!txtName.Text.Equals(""))
            {
                client.SetName(txtName.Text);
        
                (new ChatForm(client)).Show();
                this.Visible = false;
            }
            else
            {
                box.DisplayWarning("이름 입력");
            }
        }

        /*
            EnterNameByEnterKeyDown
            1. if문 입력 키가 엔터가 아닌지?
                > return
            2. EnterName 호출
         */
        private void EnterNameByEnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            EnterName(sender, e);
        }
    }
}
