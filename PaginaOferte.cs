using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_PAW
{
    public partial class PaginaOferte : Form
    {
        private InterfataOferte interfataOferte;
        public PaginaOferte()
        {
            InitializeComponent();
            interfataOferte = new AdaugaOferta();
            ofertabGridView1.DataSource = interfataOferte.GetServicii();
            

            //var adaugaInCos = new DataGridViewButtonColumn();
            //adaugaInCos.Text = "Adauga in cos";
            

        }

        private void adaugaInCos_Click(object sender, EventArgs e)
        {
            var adaugaInCos = new PaginaCoș();
            adaugaInCos.Text = "Adauga in cos";
            adaugaInCos.Show();
        }
    }
}
