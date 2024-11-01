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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-J1N8T2Q\SQLEXPRESS;Initial Catalog=lms4;Integrated Security=True");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string q = "SELECT * FROM Accounts WHERE Email = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, c);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            string t = dt.Rows[0]["type"].ToString().Trim();
            string email = dt.Rows[0]["Email"].ToString().Trim();
            string p = dt.Rows[0]["password"].ToString().Trim();

            if (t == "Admin")
            {
                if (email == textBox1.Text)
                {
                    if (p == textBox2.Text)
                    {
                        this.Hide();
                        Admin_Interface f = new Admin_Interface();
                        f.Show();
                    }
                }

            }
            else if (t == "Moderator")
            {
                if (email == textBox1.Text)
                {
                    if (p == textBox2.Text)
                    {
                        this.Hide();
                        Moderator_Interface f = new Moderator_Interface();
                        f.Show();
                    }
                }

            }
            else if (t == "User")
            {
                if (email == textBox1.Text)
                {
                    if (p == textBox2.Text)
                    {
                        this.Hide();
                        User_Interface f = new User_Interface();
                        f.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Cedentials");
            }
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register f = new Register();
            f.Show();
        }
    }
}
