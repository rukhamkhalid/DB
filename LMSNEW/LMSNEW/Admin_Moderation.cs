using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSNEW
{
    public partial class Admin_Moderation : Form
    {
        public Admin_Moderation()
        {
            InitializeComponent();
        }

        private void Admin_Moderation_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book_Collection f = new Book_Collection();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book_Record f = new Book_Record();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Record f = new Student_Record();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Record f = new Staff_Record();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Interface f = new Admin_Interface();
            f.Show();
        }
    }
}
