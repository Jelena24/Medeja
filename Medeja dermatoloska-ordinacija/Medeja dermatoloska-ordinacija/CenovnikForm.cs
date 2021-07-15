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
using ZaposleniBusiness;

namespace Medeja_dermatoloska_ordinacija
{
    public partial class CenovnikForm : Form
    {
        public CenovnikForm()
        {
            InitializeComponent();
        }

        private void CenovnikForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Tretman> lista = new List<Tretman>();
            TretmanBussines zb = new TretmanBussines();
            lista = zb.listaTretmana();
            foreach (Tretman t in lista)
            {
                listBox1.Items.Add(t.Naziv.PadRight(75, '.').Substring(0,70) + t.Cena);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tretman t = new Tretman(Convert.ToInt32(sifra.Text), naziv.Text, dijagnoza.Text, Convert.ToInt32(cena.Text), Convert.ToInt32(sifraPreparata.Text), Convert.ToInt32(idRegije.Text));
            TretmanBussines zb = new TretmanBussines();
            if (zb.InsertTretmana(t) == true)
                MessageBox.Show("Uspešno ste dodali novu cenu tretmana!");
            else
                MessageBox.Show("Niste uspeli da dodate novu cenu. Pokušajte ponovo!");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Tretman> lista = new List<Tretman>();
            TretmanBussines zb = new TretmanBussines();
            lista = zb.listaTretmana();
            foreach (Tretman t in lista)
            {
                listBox1.Items.Add(t.Naziv.PadRight(75, '.').Substring(0, 70) + t.Cena);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
