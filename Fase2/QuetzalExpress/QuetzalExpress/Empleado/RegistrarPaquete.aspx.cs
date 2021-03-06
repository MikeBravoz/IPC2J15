﻿using System;
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

        protected void btnregistrar_Click1(object sender, EventArgs e)
        {

            string clasificacion;
            string descripcion;
            string peso;
            string casilla;
            string destino;

            string codDetallePac;
            string codPaquete;
            string codCliente;

            clasificacion = txtclasificacion.Text;
            descripcion = txtdescripcion.Text;
            peso = txtpeso.Text;
            casilla = txtcasilla.Text;
            destino = txtdestino.Text;


            conexion.insertarPaquete(clasificacion, descripcion, peso, casilla);
            codPaquete = conexion.obtenerCodigoPaquete();
            codCliente = conexion.obtenerCodigoCliente(casilla);
            conexion.ingresarDetallePaquete(destino, codCliente);

            codDetallePac = conexion.obtenerCodigoDetallePaquete();
            conexion.ingresarCodigoDetallePaquete(codDetallePac, codPaquete);


            string mensaje = "El Codigo del paquete es  " + codPaquete + "  El Codigo del Cliente es " + codCliente;
            this.Page.Response.Write("<script language='JavaScript'>window.alert('" + mensaje + "');</script>");

            txtclasificacion.Text = "";
            txtdescripcion.Text = "";
            txtpeso.Text = "";
            txtdestino.Text = "";
            txtcasilla.Text = "";


        }


    }
}