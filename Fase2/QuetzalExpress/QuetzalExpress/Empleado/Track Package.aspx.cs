using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuetzalExpress.Empleado
{
    public partial class Track_Package : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ConexionWeb.ServiceSoapClient conexion = new ConexionWeb.ServiceSoapClient();

        protected void btnVerPaquetes_Click(object sender, EventArgs e)
        {
            dgvPaquete.DataSource = conexion.verPaquete2();
            dgvPaquete.DataBind();
        }
    }
}