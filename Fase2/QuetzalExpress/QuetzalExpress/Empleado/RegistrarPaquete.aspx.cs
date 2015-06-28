using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuetzalExpress.Empleado
{
    public partial class RegistrarPaquete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblfecha.Text = System.DateTime.Now.ToString();
            lblusuario.Text = Session["SessionEmpleado"].ToString();
            lblusuario.Visible = true; 
        }

        ConexionWeb.ServiceSoapClient conexion = new ConexionWeb.ServiceSoapClient();

        protected void btnregistrar_Click1(object sender, EventArgs e)
        {

            string clasificacion;
            string descripcion;
            string peso;
            string casilla;
            string codPaquete;

            clasificacion = txtclasificacion.Text;
            descripcion = txtdescripcion.Text;
            peso = txtpeso.Text;
            casilla = txtcasilla.Text;



            codPaquete = conexion.obtenerCodigoPaquete();
            string mensaje = "El Codigo del paquete es "+codPaquete;
            this.Page.Response.Write("<script language='JavaScript'>window.alert('" + mensaje + "');</script>");





        }


    }
}