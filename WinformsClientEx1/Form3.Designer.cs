namespace WinformsClientEx1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnAccess;
            this.btnRemove = new System.Windows.Forms.Button();
            this.selectMsg = new System.Windows.Forms.ComboBox();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textChat = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textIp = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            btnAccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccess
            // 
            btnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccess.Location = new System.Drawing.Point(229, 55);
            btnAccess.Name = "btnAccess";
            btnAccess.Size = new System.Drawing.Size(328, 29);
            btnAccess.TabIndex = 16;
            btnAccess.Text = "접속";
            btnAccess.UseVisualStyleBackColor = true;
            btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(595, 416);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(74, 28);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // selectMsg
            // 
            this.selectMsg.FormattingEnabled = true;
            this.selectMsg.Location = new System.Drawing.Point(168, 418);
            this.selectMsg.Name = "selectMsg";
            this.selectMsg.Size = new System.Drawing.Size(421, 26);
            this.selectMsg.TabIndex = 22;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(168, 368);
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(421, 28);
            this.textMsg.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            // 
            // textChat
            // 
            this.textChat.Location = new System.Drawing.Point(168, 105);
            this.textChat.Multiline = true;
            this.textChat.Name = "textChat";
            this.textChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textChat.Size = new System.Drawing.Size(501, 247);
            this.textChat.TabIndex = 19;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(551, 6);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(118, 28);
            this.textName.TabIndex = 18;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(595, 368);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(74, 28);
            this.btnInput.TabIndex = 17;
            this.btnInput.Text = "입력";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Port";
            // 
            // textIp
            // 
            this.textIp.Location = new System.Drawing.Point(346, 6);
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(123, 28);
            this.textIp.TabIndex = 13;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(178, 6);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(118, 28);
            this.textPort.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox selectMsg;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textChat;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIp;
        private System.Windows.Forms.TextBox textPort;
    }
}