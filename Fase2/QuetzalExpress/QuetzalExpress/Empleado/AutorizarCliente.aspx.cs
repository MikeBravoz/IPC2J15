using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuetzalExpress.Empleado
{
    public partial class AutorizarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblfecha.Text = System.DateTime.Now.ToString();

            lblusuario.Visible = true;
            if (Session["SessionEmpleado"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                lblusuario.Text = Session["SessionEmpleado"].ToString();
            }
        }

     ConexionWeb.ServiceSoapClient conexion= new ConexionWeb.ServiceSoapClient();

        protected void btnClientesPendientes_Click(object sender, EventArgs e)
        {
           
            dgvClientes.DataSource= conexion.verClientesPendientes();
            dgvClientes.DataBind();
        }

        protected void btnAutorizar_Click(object sender, EventArgs e)
        {
            Boolean autorizacion= false;
            int codCliente = Convert.ToInt32(txtCodigoCliente.Text);
            String casilla = txtCasilla.Text;
            autorizacion = true;

          //  this.Page.Response.Write("<script language='JavaScript'>window.alert('" + codCliente + "');</script>");

            conexion.autorizarCliente(casilla, codCliente);

            if (autorizacion == true)
            {
                string mensaje = "Se guardaron los datos exitosamente";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + mensaje + "');</script>");
            }
            else
            {
                string mensaje = "Hubo un problema intente de nuevo";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + mensaje + "');</script>");
            }

            txtCasilla.Text = "";
            txtCodigoCliente.Text = "";

        }
    }
}