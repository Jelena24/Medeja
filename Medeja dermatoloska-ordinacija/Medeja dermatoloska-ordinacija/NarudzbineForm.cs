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

namespace Medeja_dermatoloska_ordinacija
{
    public partial class NarudzbineForm : Form
    {
        public NarudzbineForm()
        {
            InitializeComponent();
        }

        private void NarudzbineForm_Load(object sender, EventArgs e)
        {
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                String command = "SELECT NAZIV,KOLICINA, KOLICINA_PREPARATA(SIFRA_PREPARATA) FROM PREPARATI";
                OracleCommand com = new OracleCommand(command, con);
                OracleDataReader dr = com.ExecuteReader();
                while (dr.Read())
                    listBox1.Items.Add($"Preparat {dr.GetString(0)} u količini {dr.GetInt32(1)}: {dr.GetString(2)}");
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
