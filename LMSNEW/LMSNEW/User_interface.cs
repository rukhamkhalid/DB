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
    public partial class User_interface : Form
    {
        public User_interface()
        {
            InitializeComponent();
        }

        private void User_interface_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Profile f = new Edit_Profile();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book_History f = new Book_History();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
