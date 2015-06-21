using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace QuetzalExpress
{
    public partial class FormularioNuevos : System.Web.UI.Page
    {
       
       
       // string nombre, apellido, dpi, nit, telefono, direccion, email, fecnac, numtar, tiptar, fecex, banco;
        //Declaracion de variables***
        string nombre;
        string apellido;
        int dpi;
        int nit;
        int telefono;
        string direccion;
        string email;
        string fecnac;
        int numtar;
        string tiptar;
        string fecex;
        string banco;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblfecha.Text = System.DateTime.Now.ToString();
           
        }

        

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            ConexionWeb.ServiceSoapClient conec = new ConexionWeb.ServiceSoapClient();

           

            nombre = txtnombre.Text;
            apellido = txtapellido.Text;
            dpi = Convert.ToInt32(txtdpi.Text); 
            nit =Convert.ToInt32(txtnit.Text);
            telefono =Convert.ToInt32(txttelefono.Text);
            direccion = txtdireccion.Text;
            email = txtemail.Text;
            fecnac = txtfecnac.Text;
            numtar = Convert.ToInt32(txtnumtar.Text);
            tiptar = txttiptar.Text;
            fecex = txtfecex.Text;
            banco = txtbanco.Text;
            bool respuesta=false;
            respuesta=conec.Guardar(nombre, apellido, dpi, nit, telefono, direccion, email, fecnac, numtar, tiptar, fecex, banco);
            if (respuesta == true)
            {
                lblmensaje.Visible = true;
                lblmensaje.Text = "La informacion se envio Correctamente";
            }
            else 
            {
                lblmensaje.Visible = true;
                lblmensaje.Text = "Ha ocurrido un problema";
            }

            

       
    

            //metodos.setNombre(txtnombre.Text);
            //metodos.setApellido(txtapellido.Text);
            //metodos.setDpi(Convert.ToInt32(txtdpi.Text));
            //metodos.setNit(Convert.ToInt32(txtnit.Text));
            //metodos.setTelefono(Convert.ToInt32(txttelefono.Text));
            //metodos.setDireccion(txtdireccion.Text);
            //metodos.setEmail(txtemail.Text);
            //metodos.setFecnac(Convert.ToChar(txtfecnac.Text));
            //metodos.setNumtar(Convert.ToInt32(txtnumtar));
            //metodos.setTiptar(txttiptar.Text);
            //metodos.setFecex(Convert.ToChar(txtfecex.Text));
            //metodos.setBanco(txtbanco.Text);




           
           
        }

        
    }
}