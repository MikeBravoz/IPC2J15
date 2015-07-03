using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuetzalExpress.Empleado
{
    public partial class ConsultarEquipo : System.Web.UI.Page
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
        ConexionWeb.ServiceSoapClient conexion = new ConexionWeb.ServiceSoapClient();

        protected void btnClientesPendientes_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = conexion.verEmpleado();
            dgvClientes.DataBind();
        }

        protected void btnAutorizar_Click(object sender, EventArgs e)
        {
            string CodPaq = txtCodigoEmpleado.Text;

            txtArea.Text = conexion.consultarEmpleado(CodPaq);
        }
    }
}