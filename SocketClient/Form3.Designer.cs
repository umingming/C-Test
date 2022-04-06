namespace SocketClient
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
            this.textContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.selectMsg = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textContent
            // 
            this.textContent.Location = new System.Drawing.Point(55, 29);
            this.textContent.Multiline = true;
            this.textContent.Name = "textContent";
            this.textContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textContent.Size = new System.Drawing.Size(414, 263);
            this.textContent.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(55, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 2);
            this.label3.TabIndex = 10;
            // 
            // textMsg
            // 
            this.textMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMsg.Location = new System.Drawing.Point(55, 311);
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(330, 21);
            this.textMsg.TabIndex = 9;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(401, 302);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(68, 30);
            this.btnInput.TabIndex = 11;
            this.btnInput.Text = "Send";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // selectMsg
            // 
            this.selectMsg.FormattingEnabled = true;
            this.selectMsg.Location = new System.Drawing.Point(55, 341);
            this.selectMsg.Name = "selectMsg";
            this.selectMsg.Size = new System.Drawing.Size(330, 26);
            this.selectMsg.TabIndex = 12;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(391, 338);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(84, 29);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 387);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.selectMsg);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.textContent);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ComboBox selectMsg;
        private System.Windows.Forms.Button btnRemove;
    }
}