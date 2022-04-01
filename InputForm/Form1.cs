using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputForm
{
    public partial class Form1 : Form
    {
        string name;
        string port;
        string ip;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            if(!inputName.Text.Equals(string.Empty))
            {
                name = inputName.Text;
            }
        }

        private void BtnPort_Click(object sender, EventArgs e)
        {
            if(!inputPort.Text.Equals(string.Empty))
            {
                port = inputPort.Text;
            }
        }

        private void BtnIp_Click(object sender, EventArgs e)
        {
            if(!inputIp.Text.Equals(string.Empty))
            {
                ip = inputIp.Text;
                ClientForm clientForm = new ClientForm(name, port, ip);
                this.Hide();
                clientForm.ShowDialog();
            }
        }

        private void inputName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                BtnName_Click(sender, e);
            }
        }

        private void inputPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                BtnPort_Click(sender, e);
            }
        }

        private void inputIp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                BtnIp_Click(sender, e);
            }
        }
    }
}
