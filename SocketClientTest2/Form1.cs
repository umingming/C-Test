using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SocketClientTest2
{
    public partial class Form1 : Form
    {
        TcpClient client;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) { }

        /*
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(); //연결
                client.Connect("localhost", 1234);
                button1.Enabled = false;
            }
            catch (SocketException)
            {
                button1.Enabled = true;
                MessageBox.Show("실패");
            }
            catch (Exception)
            {
                button1.Enabled = true;
                MessageBox.Show("실패");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024];
            String str = String.Empty;
            str = textBox1.Text;

            try
            {   
                for(int i=0; i<1024; i++)
                {
                    buffer[i] = 0;
                }
                buffer = Encoding.Default.GetBytes(str);
                NetworkStream net = client.GetStream();
                net.Write(buffer, 0, buffer.Length);
                net.Flush();
                textBox1.Clear();
            }
            catch (SocketException)
            {
                MessageBox.Show("실패");
            }
            catch (Exception)
            {
                MessageBox.Show("실패");
            }
        }
         */

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(); //연결
                client.Connect("localhost", 1234);
                button1.Enabled = false;
            }
            catch (SocketException)
            {
                button1.Enabled = true;
                MessageBox.Show("실패");
            }
            catch (Exception)
            {
                button1.Enabled = true;
                MessageBox.Show("실패");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024];
            String str = String.Empty;
            str = textBox1.Text;

            try
            {
                for (int i = 0; i < 1024; i++)
                {
                    buffer[i] = 0;
                }
                buffer = Encoding.Default.GetBytes(str);
                NetworkStream net = client.GetStream();
                net.Write(buffer, 0, buffer.Length);
                net.Flush();
                textBox1.Clear();
            }
            catch (SocketException)
            {
                MessageBox.Show("실패");
            }
            catch (Exception)
            {
                MessageBox.Show("실패");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
