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
    public partial class Book_Collection : Form
    {
        public Book_Collection()
        {
            InitializeComponent();
        }

        private void Book_Collection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lms4DataSet.Collection' table. You can move, or remove it, as needed.
            this.collectionTableAdapter1.Fill(this.lms4DataSet.Collection);
            // TODO: This line of code loads data into the 'libDataSet.Collection' table. You can move, or remove it, as needed.
            this.collectionTableAdapter.Fill(this.libDataSet.Collection);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Collection(BookID, BookName, Author, DatePublished, EntryDate, ExportDate, Price, BookCount)Values('" + textBox2.Text + "', '" + textBox1.Text + "','" + textBox4.Text + "', '" + textBox3.Text + "','" + textBox8.Text + "', '" + textBox7.Text + "','" + Convert.ToInt16(textBox6.Text) + "', '" + Convert.ToInt16(textBox5.Text) + "')", c);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Collection Set BookID='" + textBox2.Text + "', BookName='" + textBox1.Text + "', Author='" + textBox4.Text + "', DatePublished='" + textBox3.Text + "', EntryDate='" + textBox8.Text + "', ExportDate='" + textBox7.Text + "', Price='" + Convert.ToInt16(textBox6.Text) + "', BookCount='" + Convert.ToInt16(textBox5.Text) + "')", c);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From Collection Where BookID = '" + textBox2.Text + "' ", c);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moderator_Interface f = new Moderator_Interface();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-J1N8T2Q\SQLEXPRESS;Initial Catalog=Lib;Integrated Security=True");
        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
