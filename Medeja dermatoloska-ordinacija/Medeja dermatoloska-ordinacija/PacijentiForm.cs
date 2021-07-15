using BussinesLayer;
using DataLayer.Models;
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
    public partial class PacijentiForm : Form
    {
        public PacijentiForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pacijent p = new Pacijent(brojLicneKarte.Text, ime.Text, prezime.Text, brojTelefona.Text, alergije.Text);
            PacijentBussines zb = new PacijentBussines();
            if (zb.InsertPacijent(p) == true)
                MessageBox.Show("Uspešno ste dodali novog pacijenta u listu pacijenata!");
            else
                MessageBox.Show("Niste uspeli da dodate novog pacijenata. Pokušajte ponovo!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pacijent p = new Pacijent();
            PacijentBussines zb = new PacijentBussines();
            string pid = brojLicneKarte.Text;
            if (zb.DeletePacijent(pid) == true)
                MessageBox.Show("Pacijent" + p.Ime + " " + p.Prezime + "više nije na listi pacijenata u našoj ordinaciji!");
            else
                MessageBox.Show("Niste uspeli da uklonite pacijenta sa liste pacijenata. Pokušajte ponovo!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Pacijent> lista = new List<Pacijent>();
            PacijentBussines zb = new PacijentBussines();
            lista = zb.listaPacijenata();
            foreach (Pacijent p in lista)
            {
                listBox1.Items.Add(p.ToString());
            }
        }

        private void PacijentiForm_Load(object sender, EventArgs e)
        {
            List<Pacijent> lista = new List<Pacijent>();
            PacijentBussines zb = new PacijentBussines();
            lista = zb.listaPacijenata();
            foreach (Pacijent p in lista)
            {
                listBox1.Items.Add(p.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
