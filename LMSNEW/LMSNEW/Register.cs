using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSNEW
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-J1N8T2Q\SQLEXPRESS;Initial Catalog=lms4;Integrated Security=True");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Insert Into Requests(email, password, type)Values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + comboBox1.Text + "')", c);
            c.Open();
            cmd2.ExecuteNonQuery();
            c.Close();
            this.Hide();
            Login f = new Login();
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Show();
        }
    }
}
