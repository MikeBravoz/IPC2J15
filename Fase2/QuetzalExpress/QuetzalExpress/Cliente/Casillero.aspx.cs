using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace QuetzalExpress.Cliente
{
    public partial class Casillero : System.Web.UI.Page
    {
        ConexionWeb.ServiceSoapClient conexion = new ConexionWeb.ServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblfecha.Text = System.DateTime.Now.ToString();

            lblusuario.Visible = true;
            if (Session["SessionCliente"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                lblusuario.Text = Session["SessionCliente"].ToString();
            }

           
        }


       



        protected void Button1_Click(object sender, EventArgs e)
        {

           // DataTable tabla;
            DataSet datos;
            datos = conexion.CargarClientes();

            dgvCliente.DataSource = datos;
           // cargarClientes(dgvCliente);

            //dgvCliente.DataSource = con.CargarClientes(DataGrid datos);
            //DataBind();
            

        }
        public string CodigoCliente()
        {
            string codigo=conexion.obtenerCodigoCliente(Session["PassCliente"].ToString());

            return codigo;
        }
    

     

        protected void btnTrack_Click(object sender, EventArgs e)
        {
            string codCasilla = CodigoCliente();

            dgvCliente.DataSource = conexion.cargarDetallePaquete(codCasilla);
            dgvCliente.DataBind();
        }

        protected void btnVerPaquetes_Click(object sender, EventArgs e)
        {
            string codCasilla = Session["PassCliente"].ToString();
            dgvCliente.DataSource = conexion.verPaquete(codCasilla);
            dgvCliente.DataBind();
        }

   

        protected void btnConsutarPaquete_Click(object sender, EventArgs e)
        {
            string CodPaq = txtCodPaquete.Text;
            string casillero= Session["PassCliente"].ToString();
            txtArea.Text = conexion.consultarPaquete(casillero,CodPaq);
            
        }

     

     
    }
}