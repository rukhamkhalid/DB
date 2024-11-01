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
    public partial class Staff_Record : Form
    {
        public Staff_Record()
        {
            InitializeComponent();
        }

        private void Staff_Record_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moderator_Interface f = new Moderator_Interface();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
