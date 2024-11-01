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
    public partial class Admin_requests : Form
    {
        public Admin_requests()
        {
            InitializeComponent();
        }

        private void Admin_requests_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lms4DataSet1.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.lms4DataSet1.Request);
            // TODO: This line of code loads data into the 'libDataSet.Requests' table. You can move, or remove it, as needed.
            this.requestsTableAdapter.Fill(this.libDataSet.Requests);
            
        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-J1N8T2Q\SQLEXPRESS;Initial Catalog=lms4;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Interface f = new Admin_Interface();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Accept")
            {
                SqlCommand cmd1 = new SqlCommand("Insert Into Accounts(email, password, type)Values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')", c);
                SqlCommand cmd2 = new SqlCommand("Delete From Requests Where email = '" + textBox1.Text + "' ", c);
                c.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                c.Close();
            }
            if (comboBox1.Text == "Deny")
            {
                SqlCommand cmd = new SqlCommand("Delete From Requests Where email = '" + textBox1.Text + "' ", c);
                c.Open();
                cmd.ExecuteNonQuery();
                c.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
    }
}
