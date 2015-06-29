﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;


[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    //Direccion de nuestra conexion con la base de datos***
    SqlConnection conexion = new SqlConnection("Data Source=PERSONAL;Initial Catalog=QuetzalExpress;Integrated Security=True");

    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }


    //Metodo para Guardar datos****
    [WebMethod]
    public Boolean Guardar(string nombre, string apellido, int dpi, int nit, int telefono, string direccion, string email, string fecnac, int numtar,  string tiptar, string fecex, string banco)
    {

        SqlConnection conect = new SqlConnection("Data Source=PERSONAL;Initial Catalog=QuetzalExpress;Integrated Security=True");
        
        conect.Open();
        SqlCommand command = new SqlCommand();
        command.Connection= conect;
        command.CommandType= CommandType.Text;
        command.CommandText= "INSERT INTO Clientes VALUES(@nombre, @apellido, @dpi, @nit, @telefono, @direccion, @email, @fechaNacimiento, @numeroTarjeta, @tipoTarjeta, @fechaExpiracion, @banco)";

            command.Parameters.Add("nombre", SqlDbType.VarChar, 50).Value = nombre;
            command.Parameters.Add("apellido", SqlDbType.VarChar, 50).Value = apellido;
            command.Parameters.Add("dpi", SqlDbType.Int).Value = dpi;
            command.Parameters.Add("nit", SqlDbType.Int).Value = nit;
            command.Parameters.Add("telefono", SqlDbType.Int).Value = telefono;
            command.Parameters.Add("direccion", SqlDbType.VarChar, 50).Value = direccion;
            command.Parameters.Add("email", SqlDbType.VarChar, 50).Value = email;
            command.Parameters.Add("fechaNacimiento", SqlDbType.VarChar, 50).Value = fecnac;
            command.Parameters.Add("numeroTarjeta", SqlDbType.Int).Value = numtar;
            command.Parameters.Add("tipoTarjeta", SqlDbType.VarChar, 50).Value = tiptar;
            command.Parameters.Add("fechaExpiracion", SqlDbType.VarChar, 50).Value = fecex;
            command.Parameters.Add("banco", SqlDbType.VarChar, 50).Value = banco;

            command.ExecuteNonQuery();
            conect.Close();


        return true;
    }


    [WebMethod]
    public DataSet CargarClientes()
    {

        
        conexion.Open();
        SqlDataAdapter daClientes;
        DataSet dsClientes= new DataSet();
        DataTable dt;
        try
        {

            dt= new DataTable();
            daClientes= new SqlDataAdapter("SELECT *FROM Clientes", conexion);
            daClientes.Fill(dt);
           
           
        
            //daClientes.Fill(dsClientes, "Clientes");
            //datos = dsClientes;
            conexion.Close();
            
        }
        catch(Exception ex)
        {
            
        }
        
        return dsClientes;
    }

    [WebMethod]
    public Boolean CargarDatos(string datos)
    {


        return true;
    }

    [WebMethod]

    public string LoguinCliente(String Usuario, String Contrasena)
    {
        
        String SessionC;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        conexion.Open();
        cmd.Connection = conexion;
        cmd.CommandText = "SELECT * from Cliente WHERE nombreCliente='" + Usuario + "' AND codigoCasilla='" + Contrasena + "'";
        dr = cmd.ExecuteReader();
        dr.Read();
        if (dr.HasRows)
        {
            SessionC = Usuario;
        }
        else
        {
            SessionC = null;
            conexion.Close();
        }
        return SessionC;
    }

    [WebMethod]

    public string Loguin(String Usuario, String Contrasena)
    {
        String Session;
     
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        conexion.Open();
        cmd.Connection = conexion;
        cmd.CommandText = "SELECT * from Empleado WHERE nombreEmpleado='" + Usuario + "' AND idEmpleado='" + Contrasena + "'";
        dr = cmd.ExecuteReader();
        dr.Read();
        if (dr.HasRows)
        {
            Session = Usuario;
            
        }
        else
        {
            Session = null;
            conexion.Close();
        }
        return Session;
    }

    [WebMethod]
    public string LoguinPass(String Usuario, String Contrasena)
    {
        String Session;
       
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        conexion.Open();
        cmd.Connection = conexion;
        cmd.CommandText = "SELECT * from Empleado WHERE nombreEmpleado='" + Usuario + "' AND idEmpleado='" + Contrasena + "'";
        dr = cmd.ExecuteReader();
        dr.Read();
        if (dr.HasRows)
        {
            Session = Contrasena;
            
        }
        else
        {
            Session = null;
            conexion.Close();
        }
        return Session;
    }

    [WebMethod]
    public string insertarCategoria(string nombre, int impuesto)
    {
        string vel="";
        try
        {
            conexion.Open();
            string consulta = "Insert into Impuestos (categoriaImpuesto, impuesto) Values('" + nombre + "','" + impuesto + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            SqlCommand cmd;
            cmd = new SqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            vel = "hubo un error" + ex;
        }


        return vel;
    }

    [WebMethod]
    public Boolean insertarPaquete(string clasificacion, string descripcion, string peso)
    {
        string mensaje="";
        try
        {
            conexion.Open();
            string consulta = "Insert into Paquete (clasificacionPaquete, descripcionPaquete,  pesoPaquete) Values('" + clasificacion + "','" + descripcion + "','" + peso + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            SqlCommand cmd;
            cmd = new SqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            mensaje = "hubo un error" + ex;
        }
        return true;
    }

    [WebMethod]
    public String obtenerCodigoPaquete()
    {
        conexion.Open();
        SqlCommand cmdU = new SqlCommand();


        SqlDataAdapter CMD = new SqlDataAdapter("SELECT TOP 1 * FROM Paquete ORDER BY codPaquete DESC" , conexion);
        DataSet ds = new DataSet();
        CMD.Fill(ds, "DATOS");
        DataTable TablaRol = ds.Tables[0];

        string codigo;
        codigo = TablaRol.Rows[0]["codPaquete"].ToString(); 
        return codigo;
    }

     [WebMethod]
    public String obtenerCodigoDetallePaquete()
    {
        conexion.Open();
        SqlCommand cmdU = new SqlCommand();


        SqlDataAdapter CMD = new SqlDataAdapter("SELECT TOP 1 * FROM DetallePaquete ORDER BY codDetallePaquete DESC", conexion);
        DataSet ds = new DataSet();
        CMD.Fill(ds, "DATOS");
        DataTable TablaRol = ds.Tables[0];

        string codigo;
        codigo = TablaRol.Rows[0]["codDetallePaquete"].ToString();
        return codigo;
    }

     [WebMethod]
     public String obtenerCodigoCliente(string casilla)
     {
       
         conexion.Open();
         SqlCommand cmdU = new SqlCommand();
         string consulta = "SELECT codCliente  FROM Cliente WHERE codigoCasilla='" + casilla + "'";
         
         SqlDataAdapter CMD = new SqlDataAdapter(consulta, conexion);
     
         DataSet ds = new DataSet();
         CMD.Fill(ds, "DATOS");
         DataTable TablaRol = ds.Tables[0];

         string codigo;
         codigo = TablaRol.Rows[0]["codCliente"].ToString();
         return codigo;
     }

    [WebMethod]
    public Boolean registrarPaquete(string clasificacion, string descripcion,  string peso, string destino, string codCliente)
    {

        conexion.Open();

        SqlCommand command = new SqlCommand();
        command.Connection = conexion;
        command.CommandType = CommandType.Text;
        command.CommandText = "INSERT INTO Paquete VALUES(@clasificacionPaquete, @descripcionPaquete, @pesoPaquete)";

        command.Parameters.Add("clasificacionPaquete", SqlDbType.VarChar, 50).Value = clasificacion;
        command.Parameters.Add("descripcionPaquete", SqlDbType.VarChar, 50).Value = descripcion;
        command.Parameters.Add("pesoPaquete", SqlDbType.Int).Value = peso;
        command.ExecuteNonQuery();

        command.CommandText = "INSERT INTO DetallePaquete VALUES(@destinoDetallePaquete, @codCliente)";
        command.Parameters.Add("destinoDetallePaquete", SqlDbType.VarChar, 50).Value = destino;
        command.Parameters.Add("codCliente", SqlDbType.Int).Value = codCliente;
        command.ExecuteNonQuery();

        conexion.Close();
        return true;
    }
    
    [WebMethod]


    public Boolean ingresarDetallePaquete(string destino, string codigo)
    {
       
        Boolean confirm = true;

        string mensaje = "";
        try
        {
            conexion.Open();
            string consulta = "Insert into DetallePaquete (bodegaDetallePaquete, destinoDetallePaquete, codCliente) Values('" + confirm + "','" + destino + "','" + codigo + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            SqlCommand cmd;
            cmd = new SqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            mensaje = "hubo un error" + ex;
        }
        return true;
    }

    [WebMethod]
    public Boolean ingresarCodigoDetallePaquete(string codigoDetalle)
    {
        

        string mensaje = "";
        try
        {
            conexion.Open();
            string consulta = "Insert into Paquete (codDetallePaquete) Values('" + codigoDetalle + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            SqlCommand cmd;
            cmd = new SqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            mensaje = "hubo un error" + ex;
        }
        return true;
    }
   
    }
    
