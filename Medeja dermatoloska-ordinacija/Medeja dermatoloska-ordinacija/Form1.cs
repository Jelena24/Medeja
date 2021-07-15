using BussinesLayer;
using DataLayer.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaposleniBusiness;

namespace Medeja_dermatoloska_ordinacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PACIJENTI' table. You can move, or remove it, as needed.
            this.pACIJENTITableAdapter.Fill(this.dataSet1.PACIJENTI);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NarudzbineForm n = new NarudzbineForm();
            n.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TretmaniNaAkciji t = new TretmaniNaAkciji();
            t.Show();
        }


        private void Zaposleni_Click(object sender, EventArgs e)
        {
            ZaposleniForm z1 = new ZaposleniForm();
            z1.Show();                       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PacijentiForm  p= new PacijentiForm();
            p.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CenovnikForm c= new CenovnikForm();
            c.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PromeneForm d = new PromeneForm();
            d.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TretmaniNaAkciji t = new TretmaniNaAkciji();
            t.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ZakazivanjeForm z = new ZakazivanjeForm();
            z.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            brisanjeForm  b= new brisanjeForm();
            b.Show();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
