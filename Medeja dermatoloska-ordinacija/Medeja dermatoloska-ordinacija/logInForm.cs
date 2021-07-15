using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medeja_dermatoloska_ordinacija
{
    public partial class logInForm : Form
    {
        public logInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "JELENA" && textBox2.Text == "2412")
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
          

            else if (textBox1.Text == "MARIJA" && textBox2.Text == "2412")
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Uneli ste pogrešan username ili password. Pokušajte ponovo!");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void logInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
