using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhizzHardBooks
{
    public partial class Consultar_Libro : Form
    {
        public Consultar_Libro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Biblioteca biblio = new Biblioteca();
            biblio.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dGVconsulta.Visible = true;
        }
    }
}
