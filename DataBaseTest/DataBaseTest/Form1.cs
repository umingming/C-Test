﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataBaseTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = string.Format("Provider=OraOLEDB.Oracle;" +
                                            "OLEDB.NET=true;" +
                                            "PLSQLRSet=true;" +
                                            "Data Source=orcl;" +
                                            "User Id=runch;" +
                                            "Password=java1234;");
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            String sql = "select count(*) from temp";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);

            OleDbCommand cmd = new OleDbCommand(sql, conn);

            OleDbDataReader reader = cmd.ExecuteReader();
            
            if(reader.Read())
            {
                textBox1.Text = reader.GetValue(0).ToString();
            }


            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            
        }
    }
}
