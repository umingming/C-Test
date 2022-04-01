namespace InputForm
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
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputPort = new System.Windows.Forms.TextBox();
            this.inputIp = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.btnPort = new System.Windows.Forms.Button();
            this.btnIp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(22, 21);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(346, 28);
            this.inputName.TabIndex = 0;
            this.inputName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.inputName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputName_KeyDown);
            // 
            // inputPort
            // 
            this.inputPort.Location = new System.Drawing.Point(22, 78);
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(346, 28);
            this.inputPort.TabIndex = 1;
            this.inputPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputPort_KeyDown);
            // 
            // inputIp
            // 
            this.inputIp.Location = new System.Drawing.Point(22, 136);
            this.inputIp.Name = "inputIp";
            this.inputIp.Size = new System.Drawing.Size(346, 28);
            this.inputIp.TabIndex = 2;
            this.inputIp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputIp_KeyDown);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(386, 22);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 3;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.BtnName_Click);
            // 
            // btnPort
            // 
            this.btnPort.Location = new System.Drawing.Point(386, 81);
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(75, 23);
            this.btnPort.TabIndex = 4;
            this.btnPort.Text = "Port";
            this.btnPort.UseVisualStyleBackColor = true;
            this.btnPort.Click += new System.EventHandler(this.BtnPort_Click);
            // 
            // btnIp
            // 
            this.btnIp.Location = new System.Drawing.Point(386, 138);
            this.btnIp.Name = "btnIp";
            this.btnIp.Size = new System.Drawing.Size(75, 23);
            this.btnIp.TabIndex = 5;
            this.btnIp.Text = "IP";
            this.btnIp.UseVisualStyleBackColor = true;
            this.btnIp.Click += new System.EventHandler(this.BtnIp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 195);
            this.Controls.Add(this.btnIp);
            this.Controls.Add(this.btnPort);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.inputIp);
            this.Controls.Add(this.inputPort);
            this.Controls.Add(this.inputName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputPort;
        private System.Windows.Forms.TextBox inputIp;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnPort;
        private System.Windows.Forms.Button btnIp;
    }
}

