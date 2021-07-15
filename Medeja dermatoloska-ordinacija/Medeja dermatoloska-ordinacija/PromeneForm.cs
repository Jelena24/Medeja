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
using ZaposleniBusiness;

namespace Medeja_dermatoloska_ordinacija
{
    public partial class PromeneForm : Form
    {
        public PromeneForm()
        {
            InitializeComponent();
        }

        private void PromeneForm_Load(object sender, EventArgs e)
        {
            List<Preparat> lista = new List<Preparat>();
            PreparatBussines zb = new PreparatBussines();
            lista = zb.listaPreparata();
            foreach (Preparat p in lista)
            {
                listBox1.Items.Add(p.Naziv + "     " + p.Oznaka);
            }

            List<JedinicaMere> lista1 = new List<JedinicaMere>();
            JedinicaMereBussines jd = new JedinicaMereBussines();
            lista1 = jd.listaJedinicaMere();
            foreach (JedinicaMere j in lista1)
            {
                listBox2.Items.Add(j.ToString());
            }

            List<Tretman> lista11 = new List<Tretman>();
            TretmanBussines jd1 = new TretmanBussines();
            lista11 = jd1.listaTretmana();
            foreach (Tretman j1 in lista11)
            {
                listBox3.Items.Add(j1.SifraTretmana + "   " + j1.Naziv + "   " + j1.Cena);
                listBox5.Items.Add(j1.SifraTretmana + "   " + j1.Naziv + "   " + j1.Cena);
            }
            List<Evidencija> listaa = new List<Evidencija>();
            EvidencijeBussines pba = new EvidencijeBussines();
            listaa = pba.listaEvidencija();
            foreach (Evidencija p in listaa)
            {
                listBox4.Items.Add(p.DatumIzvodjenjaTretmana +  "   " + p.VremeTretmana + "   " + p.Naziv);
            }

            
            List<RegijaTretmana> list = new List<RegijaTretmana>();
            RegijaTretmanaBussines rt = new RegijaTretmanaBussines();
            list = rt.listaRegijaTretmana();
            foreach (RegijaTretmana r in list)
            {
                listBox6.Items.Add(r.NazivRegije + " " + r.MaxCena);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JedinicaMere a = new JedinicaMere(Convert.ToInt32(textBox1.Text),textBox1.Text,textBox2.Text);
            JedinicaMereBussines zb = new JedinicaMereBussines();
            if (zb.UpdateJedinicaMere(a) == true)
                MessageBox.Show("Uspešno ste izmenili oznaku i naziv jedinice mere!");
            else
                MessageBox.Show("Niste uspeli da promenite. Pokušajte ponovo!");
            listBox2.Items.Clear();
            List<JedinicaMere> lista1 = new List<JedinicaMere>();
            JedinicaMereBussines jd = new JedinicaMereBussines();
            lista1 = jd.listaJedinicaMere();
            foreach (JedinicaMere j in lista1)
            {
                listBox2.Items.Add(j.ToString());
            }

            listBox1.Items.Clear();
            List<Preparat> lista = new List<Preparat>();
            PreparatBussines pb = new PreparatBussines();
            lista = pb.listaPreparata();
            foreach (Preparat p in lista)
            {
                listBox1.Items.Add(p.Naziv + "     " + p.Oznaka);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tretman a = new Tretman(Convert.ToInt32(textBox4.Text), textBox3.Text,textBox4.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox4.Text));
            TretmanBussines tb = new TretmanBussines();
            if (tb.UpdateTretmanDenormalizacija(a) == true)
                MessageBox.Show("Uspešno ste izmenili naziv tretmana!");
            else
                MessageBox.Show("Niste uspeli da promenite. Pokušajte ponovo!");

            listBox3.Items.Clear();
            List<Tretman> lista1 = new List<Tretman>();
            TretmanBussines jd = new TretmanBussines();
            lista1 = jd.listaTretmana();
            foreach (Tretman j in lista1)
            {
                listBox3.Items.Add(j.SifraTretmana + "   " + j.Naziv + "   " + j.Cena);
            }

            listBox4.Items.Clear();
            List<Evidencija> lista = new List<Evidencija>();
            EvidencijeBussines pb = new EvidencijeBussines();
            lista = pb.listaEvidencija();
            foreach (Evidencija p in lista)
            {
                listBox4.Items.Add(p.DatumIzvodjenjaTretmana + "   " + p.VremeTretmana + "   " + p.Naziv);
            }

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tretman a = new Tretman(Convert.ToInt32(textBox6.Text), textBox5.Text, textBox5.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox5.Text));
            TretmanBussines tb = new TretmanBussines();
            if (tb.UpdateTretmanOptimizacija(a) == true)
            {
                tb.UpdateTretmanOptimizacija(a);
                MessageBox.Show("Uspešno ste izmenili cenu tretmana!");
            }
                
            else
                MessageBox.Show("Niste uspeli da promenite. Pokušajte ponovo!");

            listBox5.Items.Clear();
            List<Tretman> lista1 = new List<Tretman>();
            TretmanBussines jd = new TretmanBussines();
            lista1 = jd.listaTretmana();
            foreach (Tretman j in lista1)
            {
                listBox5.Items.Add(j.SifraTretmana + "   " + j.Naziv + "   " + j.Cena);
            }

            listBox6.Items.Clear();
            List<RegijaTretmana> lista = new List<RegijaTretmana>();
            RegijaTretmanaBussines pb = new RegijaTretmanaBussines();
            lista = pb.listaRegijaTretmana();
            foreach (RegijaTretmana p in lista)
            {
                listBox6.Items.Add(p.NazivRegije + " " + p.MaxCena);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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
