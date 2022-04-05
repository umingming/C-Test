namespace WinformsClientEx1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnAccess;
            this.textPort = new System.Windows.Forms.TextBox();
            this.textIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textChat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.selectMsg = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            btnAccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccess
            // 
            btnAccess.Location = new System.Drawing.Point(110, 73);
            btnAccess.Name = "btnAccess";
            btnAccess.Size = new System.Drawing.Size(325, 28);
            btnAccess.TabIndex = 4;
            btnAccess.Text = "접속";
            btnAccess.UseVisualStyleBackColor = true;
            btnAccess.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(59, 24);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(118, 28);
            this.textPort.TabIndex = 0;
            // 
            // textIp
            // 
            this.textIp.Location = new System.Drawing.Point(227, 24);
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(123, 28);
            this.textIp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(476, 386);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(74, 28);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "입력";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(432, 24);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(118, 28);
            this.textName.TabIndex = 6;
            // 
            // textChat
            // 
            this.textChat.Location = new System.Drawing.Point(49, 123);
            this.textChat.Multiline = true;
            this.textChat.Name = "textChat";
            this.textChat.Size = new System.Drawing.Size(501, 247);
            this.textChat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(49, 386);
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(421, 28);
            this.textMsg.TabIndex = 9;
            // 
            // selectMsg
            // 
            this.selectMsg.FormattingEnabled = true;
            this.selectMsg.Location = new System.Drawing.Point(49, 436);
            this.selectMsg.Name = "selectMsg";
            this.selectMsg.Size = new System.Drawing.Size(421, 26);
            this.selectMsg.TabIndex = 10;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(476, 434);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(74, 28);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 487);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.selectMsg);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textChat);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(btnAccess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textIp);
            this.Controls.Add(this.textPort);
            this.Name = "Form1";
            this.Text = "ChatChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textChat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.ComboBox selectMsg;
        private System.Windows.Forms.Button btnRemove;
    }
}

