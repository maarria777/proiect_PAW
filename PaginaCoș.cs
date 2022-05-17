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
    public partial class PaginaCoș : Form
    {
        public PaginaCoș()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var finalComanda = new PaginaClient();
            finalComanda.Text = "Finalizeaza comanda";
            finalComanda.Show();
        }


        public List<Servicii> OferteCumparate = new List<Servicii>(); //equipM  
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //articoleCosgv.DataSource = PaginaCoș.adaugaInCos;
        }

        private void sumaPlata_TextChanged(object sender, EventArgs e)
        {
            double sumaTotala = 0;
            //foreach (var articol in articoleCosgv.DataSource)
            //{
            //    sumaTotala += articol.PretOferta;
            //}
            //sumaPlata.Text = Convert.ToString(sumaTotala);
        }
    }
}
