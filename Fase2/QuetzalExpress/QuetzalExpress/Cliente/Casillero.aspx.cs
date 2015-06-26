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
        ConexionWeb.ServiceSoapClient con = new ConexionWeb.ServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblfecha.Text = System.DateTime.Now.ToString();
            lblusuario.Text = "Invitado";
            lblusuario.Visible = true;
            lblusuario.Text = Session["SessionCliente"].ToString();
        }


       



        protected void Button1_Click(object sender, EventArgs e)
        {

           // DataTable tabla;
            DataSet datos;
            datos = con.CargarClientes();

            dgvCliente.DataSource = datos;
           // cargarClientes(dgvCliente);

            //dgvCliente.DataSource = con.CargarClientes(DataGrid datos);
            //DataBind();
            

        }

     
    }
}