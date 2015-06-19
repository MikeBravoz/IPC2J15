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
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Consultar_Libro consulta = new Consultar_Libro();
            consulta.Show();
            this.Hide();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Registrar reg = new Registrar();
            reg.Show();
            this.Hide();
        }

        private void btninscribir_Click(object sender, EventArgs e)
        {
            

            Inscripcion ins = new Inscripcion();
            ins.Show();
            this.Hide();

        }
    }
}
