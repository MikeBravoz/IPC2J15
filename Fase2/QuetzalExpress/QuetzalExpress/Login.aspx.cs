using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace QuetzalExpress
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblfecha.Text = System.DateTime.Now.ToString();
            lblusuario.Text = "Invitado";
            lblusuario.Visible = true;  

        }

        public string AnalisarUsuario(String Usuario)
        {

            

            SqlConnection conectar = new SqlConnection("Data Source=PERSONAL;Initial Catalog=QuetzalExpress;Integrated Security=True");
            SqlCommand cmdU = new SqlCommand();
            conectar.Open();
            SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM Empleado WHERE idEmpleado='" + Usuario + "'", conectar);
            DataSet ds = new DataSet();
            CMD.Fill(ds, "DATOS");
            DataTable TablaRol = ds.Tables[0];
            string rol = TablaRol.Rows[0]["rolEmpleado"].ToString();
            //Response.Write("El usuario es de tipo:" + rol);
            return rol;
        }

        protected void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnacceder_Click(object sender, EventArgs e)
        {
            String Usuario = txtusuario.Text;
            String Contrasena = txtpassword.Text;

            String User;

            ConexionWeb.ServiceSoapClient conect = new ConexionWeb.ServiceSoapClient();
            User = conect.LoguinCliente(Usuario, Contrasena); 

            

            Session["SessionCliente"] = User;

            if (Session["SessionCliente"] == null)
            {
                User = conect.Loguin(Usuario, Contrasena);
               
                Session["SessionEmpleado"] = User;
                if (Session["SessionEmpleado"] == null)
                {
                    Response.Write("Usuario o Contrasena INCORRECTA... Intente de nuevo..!");
                }
                else
                {
                    if (AnalisarUsuario(User) == "administrador")
                    {
                        Response.Redirect("Administrador.aspx");
                    }
                    if (AnalisarUsuario(User) == "empleado")
                    {
                        Response.Redirect("/Empleado/PrincipalEmpleado");
                    }
                }
                //Response.Redirect("Principal.aspx");

            }
            else
            {
                Response.Redirect("/Cliente/Casillero.aspx");
            }
        
        







    

        }
    }
}