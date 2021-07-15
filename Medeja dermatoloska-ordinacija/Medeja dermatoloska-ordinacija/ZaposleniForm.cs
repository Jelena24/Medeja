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
    public partial class ZaposleniForm : Form
    {
        public ZaposleniForm()
        {
            InitializeComponent();
        }


        private void ZaposleniForm_Load(object sender, EventArgs e)
        {
            List<Zaposleni> lista = new List<Zaposleni>();
            BusinessZaposleni zb = new BusinessZaposleni();
            lista = zb.listaZaposlenih();
            foreach (Zaposleni z in lista)
            {
                listBox1.Items.Add(z.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zaposleni z = new Zaposleni();
            BusinessZaposleni zb = new BusinessZaposleni();
            string zid = brojLicneKarte.Text;
            if (zb.DeleteZaposleni(zid) == true)
                MessageBox.Show("Zaposleni" + z.Ime + " " + z.Prezime + "više nije na listi zaposlenih u ordinaciji!");
            else
                MessageBox.Show("Niste uspeli da uklonite zaposlenog sa liste zaposlenih. Pokušajte ponovo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zaposleni z = new Zaposleni(brojLicneKarte.Text, ime.Text, prezime.Text, brojTelefona.Text, strucnaSprema.Text, diploma.Text, sertifikat.Text);
            BusinessZaposleni zb = new BusinessZaposleni();
            if (zb.InsertZaposleni(z) == true)
                MessageBox.Show("Uspešno ste dodali novog zaposlenog u listu zaposlenpg osoblja!");
            else
                MessageBox.Show("Niste uspeli da dodate novog zaposleng. Pokušajte ponovo!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Zaposleni> lista = new List<Zaposleni>();
            BusinessZaposleni zb = new BusinessZaposleni();
            lista = zb.listaZaposlenih();
            foreach (Zaposleni z in lista)
            {
                listBox1.Items.Add(z.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
