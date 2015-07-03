using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace QuetzalExpress.Empleado
{
    public partial class PrincipalCliente : System.Web.UI.Page
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

        public string AnalisarUsuario(String password)
        {



            SqlConnection conectar = new SqlConnection("Data Source=PERSONAL;Initial Catalog=QuetzalExpress;Integrated Security=True");
            SqlCommand cmdU = new SqlCommand();
            conectar.Open();
            SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM Empleado WHERE idEmpleado='" + password + "'", conectar);
            DataSet ds = new DataSet();
            CMD.Fill(ds, "DATOS");
            DataTable TablaRol = ds.Tables[0];
            string pais = TablaRol.Rows[0]["direccionEmpleado"].ToString();
            return pais;
        }


        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            String acceso = "Usa";
            String pass = Session["PassEmpleado"].ToString();

            if (acceso == AnalisarUsuario(pass))
            {
                Response.Redirect("~/Empleado/RegistrarPaquete.aspx");
            }
            else
            {
                string error = "Acceso Denegado... Comuniquese con administracion";

                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                //Response.Write("Acceso Denegado.. Comuniquese con administracion");
                //   Response.Redirect("~/Empleado/PrincipalEmpleado.aspx");
            }
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            String acceso = "Usa";
            String pass = Session["PassEmpleado"].ToString();

            if (acceso == AnalisarUsuario(pass))
            {
                Response.Redirect("~/Empleado/Lote.aspx");
            }
            else
            {
                string error = "Acceso Denegado... Comuniquese con administracion";

                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                //Response.Write("Acceso Denegado.. Comuniquese con administracion");
                //   Response.Redirect("~/Empleado/PrincipalEmpleado.aspx");
            }
        }

        protected void btnAutorizarClientes_Click(object sender, EventArgs e)
        {
            String acceso = "Guatemala";
            String pass = Session["PassEmpleado"].ToString();

            if (acceso == AnalisarUsuario(pass))
            {
                Response.Redirect("~/Empleado/AutorizarCliente.aspx");
            }
            else
            {
                string error = "Acceso Denegado... Comuniquese con administracion";

                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
            }
        }

        protected void btnConsultarEquipo_Click(object sender, EventArgs e)
        {
            String acceso = "Guatemala";
            String pass = Session["PassEmpleado"].ToString();

            if (acceso == AnalisarUsuario(pass))
            {
                Response.Redirect("~/Empleado/ConsultarEquipo.aspx");
            }
            else
            {
                string error = "Acceso Denegado... Comuniquese con administracion";

                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
            }
        }

        protected void btntracking_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Empleado/Track Package.aspx");
        }
    }
}