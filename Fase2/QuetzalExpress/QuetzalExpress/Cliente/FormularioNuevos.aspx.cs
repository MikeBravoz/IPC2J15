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
       
       
     
        //Declaracion de variables***
        string nombre;
        string apellido;
        int nit;
        int telefono;
        string direccion;
        string numtar;
        string tiptar;
        string fecex;
        string banco;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblfecha.Text = System.DateTime.Now.ToString();
           
        }

        

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            ConexionWeb.ServiceSoapClient conexion = new ConexionWeb.ServiceSoapClient();

           

            nombre = txtnombre.Text;
            apellido = txtapellido.Text;
            nit =Convert.ToInt32(txtnit.Text);
            telefono =Convert.ToInt32(txttelefono.Text);
            direccion = txtdireccion.Text;
           
            numtar = txtnumtar.Text;
            tiptar = txttiptar.Text;
            fecex = txtfecex.Text;
            banco = txtbanco.Text;
            bool respuesta1 = false;
            bool respuesta2 = false;

            string codCliente = "";

            respuesta1 = conexion.GuardarClienteNuevo(nombre, apellido, nit, telefono, direccion);
            codCliente = conexion.obtenerCodigoCliente2();
            respuesta2= conexion.GuardarTarjeta(numtar, banco, tiptar, codCliente, fecex);
            this.Page.Response.Write("<script language='JavaScript'>window.alert('" + codCliente + "');</script>");

            if (respuesta1 == true && respuesta2 == true)
            {
                string mensaje = "Se guardaron los datos exitosamente";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + mensaje + "');</script>");
            }
            else
            {
                string mensaje = "Hubo un Problema intente de nuevo";
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + mensaje + "');</script>");
            }

           
            txtnombre.Text="";
            txtapellido.Text="";
            txtnit.Text="";
            txttelefono.Text="";
            txtdireccion.Text="";
           
            txtnumtar.Text="";
            txttiptar.Text="";
            txtfecex.Text="";
            txtbanco.Text="";
            codCliente = "";
        }

        
    }
}