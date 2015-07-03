using System;
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
    public Boolean GuardarClienteNuevo(string nombre, string apellido, int nit, int telefono, string direccion)
    {

        string vel = "";
        try
        {
            conexion.Open();
            string consulta = "INSERT INTO Cliente (nombreCliente, apellidoCliente, nitCliente,telefonoCliente, direccionCliente)  Values('" + nombre + "','" + apellido + "','" + nit + "','" + telefono + "','" + direccion + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            SqlCommand cmd;
            cmd = new SqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            vel = "hubo un error" + ex;
        }
 
        conexion.Close();
        return true;
    }

    [WebMethod]
    public Boolean GuardarTarjeta(string numero, string banco, string tipo, string codCliente, string fex )
    {

        string vel = "";
        try
        {
            conexion.Open();
            string consulta = "INSERT INTO Tarjeta (noTarjeta, bancoTarjeta, tipoTarjeta, codCliente, expiracionTarjeta)  Values('" + numero + "','" + banco + "','" + tipo + "','" + codCliente + "','" + fex + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            SqlCommand cmd;
            cmd = new SqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            vel = "hubo un error" + ex;
        }

        conexion.Close();
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
    public string LoguinClientePass(String usu, String pass)
    {
        String SessionC;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        conexion.Open();
        cmd.Connection = conexion;
        cmd.CommandText = "SELECT * from Cliente WHERE nombreCliente='" + usu + "' AND codigoCasilla='" + pass + "'";
        dr = cmd.ExecuteReader();
        dr.Read();
        if (dr.HasRows)
        {
            SessionC = pass;
        }
        else
        {
            SessionC = null;
            conexion.Close();
        }
        conexion.Close();
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
    public Boolean insertarCategoria(string nombre, int impuesto)
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

        return true;
    }

    [WebMethod]
    public Boolean insertarPaquete(string clasificacion, string descripcion, string peso, string casilla)
    {
        string mensaje="";
        try
        {
            conexion.Open();
            string consulta = "Insert into Paquete (clasificacionPaquete, descripcionPaquete,  pesoPaquete, casillaCliente) Values('" + clasificacion + "','" + descripcion + "','" + peso + "','" + casilla + "')";
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
     public String obtenerCodigoCliente2()
     {
         conexion.Open();
         SqlCommand cmdU = new SqlCommand();


         SqlDataAdapter CMD = new SqlDataAdapter("SELECT TOP 1 * FROM Cliente ORDER BY codCliente DESC", conexion);
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
    public Boolean ingresarCodigoDetallePaquete(string codigoDetalle, string codigoPaquete)
    {

  

        string consulta = "UPDATE Paquete SET codDetallePaquete='" + codigoDetalle + "' WHERE codPaquete='" + codigoPaquete + "'"; 
        string mensaje = "";
        try
        {
            conexion.Open();
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
    public Boolean ingresarCategoria(string cat)
    {
        string mensaje = "";
        try
        {
            conexion.Open();
            string consulta = "Insert into Impuestos (categoriaImpuesto) Values('" + cat + "')";
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
    public Boolean ingresarImpuesto(string imp)
    {
        string consulta = "UPDATE Impuestos SET impuesto='" + imp + "' WHERE impuesto IS NULL";
        string mensaje = "";
        try
        {
            conexion.Open();
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
    public DataSet cargarDetallePaquete(string codCliente)
    {
        conexion.Open();
        string consulta= "Select *from DetallePaquete  WHERE codCliente='" + codCliente + "'";

        SqlDataAdapter daClientes= new SqlDataAdapter(consulta,conexion);
        DataSet dsClientes= new DataSet();
        daClientes.Fill(dsClientes, "DetallePaquete");
        return dsClientes;
    }

    [WebMethod]
    public DataSet verPaquete(string casilla)
    {
        conexion.Open();
        string consulta = "Select *FROM Paquete  WHERE casillaCliente='" + casilla + "'";

        SqlDataAdapter daClientes = new SqlDataAdapter(consulta, conexion);
        DataSet dsClientes = new DataSet();
        daClientes.Fill(dsClientes, "Paquete");
        return dsClientes;
    }

    [WebMethod]
    public DataSet verPaquete2()
    {
        conexion.Open();
        string consulta = "Select *FROM Paquete ";

        SqlDataAdapter daClientes = new SqlDataAdapter(consulta, conexion);
        DataSet dsClientes = new DataSet();
        daClientes.Fill(dsClientes, "Paquete");
        return dsClientes;
    }


    [WebMethod]
    public DataSet verClientesPendientes()
    {
        conexion.Open();
        string consulta = "Select *from Cliente  WHERE codigoCasilla is Null";

        SqlDataAdapter daClientes = new SqlDataAdapter(consulta, conexion);
        DataSet dsClientes = new DataSet();
        daClientes.Fill(dsClientes, "Paquete");
        return dsClientes;
    }

    [WebMethod]
    public DataSet verTarjetas()
    {
        conexion.Open();
        string consulta = "Select *from Tarjeta  WHERE codigoCasilla is Null";

        SqlDataAdapter daClientes = new SqlDataAdapter(consulta, conexion);
        DataSet dsClientes = new DataSet();
        daClientes.Fill(dsClientes, "Paquete");
        return dsClientes;
    }

    [WebMethod]
    public Boolean autorizarCliente(string casilla, int codigoCliente)
    {
       

        string consulta = "UPDATE Cliente SET codigoCasilla ='" + casilla + "' WHERE codCliente='" + codigoCliente + "'"; 
        string mensaje = "";
        try
        {
            conexion.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            SqlCommand cmd;
            cmd = new SqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            mensaje = "hubo un error" + ex;
        }
        conexion.Close();
        return true;
    }

    [WebMethod]
    public string consultarPaquete(string casilla, string codigoPac)
    {
     

        conexion.Open();
        SqlCommand cmdU = new SqlCommand();

        string consulta = "SELECT codPaquete, clasificacionPaquete, descripcionPaquete, pesoPaquete  FROM Paquete WHERE casillaCliente='" + casilla + "' AND codPaquete='" + codigoPac + "'";
        SqlDataAdapter CMD = new SqlDataAdapter(consulta, conexion);
        DataSet ds = new DataSet();
        CMD.Fill(ds, "DATOS");
        DataTable TablaRol = ds.Tables[0];

        string codigo;
        string clasificacion;
        string descripcion;
        string peso;
        string cadena;

        codigo = TablaRol.Rows[0]["codPaquete"].ToString();
        clasificacion = TablaRol.Rows[0]["clasificacionPaquete"].ToString();
        descripcion = TablaRol.Rows[0]["descripcionPaquete"].ToString();
        peso = TablaRol.Rows[0]["pesoPaquete"].ToString();
        cadena = "CODIGO: "+codigo +"\nCLASIFICACION: "+ clasificacion +"\nDESCRIPCION: " +descripcion +"\nPESO: "+ peso;


        conexion.Close();
        return cadena; 
    }

    [WebMethod]
    public DataSet verEmpleado()
    {
        conexion.Open();
        string consulta = "Select *from Empleado  WHERE codDepartamento is Null";

        SqlDataAdapter daClientes = new SqlDataAdapter(consulta, conexion);
        DataSet dsClientes = new DataSet();
        daClientes.Fill(dsClientes, "Paquete");
        return dsClientes;
    }

    [WebMethod]
    public string consultarEmpleado(string codEmpleado)
    {


        conexion.Open();
        SqlCommand cmdU = new SqlCommand();

        string consulta = "SELECT codEmpleado, idEmpleado, nombreEmpleado, apellidoEmpleado, telefonoEmpleado, direccionEmpleado, salarioEmpleado  FROM Empleado WHERE codEmpleado='" + codEmpleado + "'";
        SqlDataAdapter CMD = new SqlDataAdapter(consulta, conexion);
        DataSet ds = new DataSet();
        CMD.Fill(ds, "DATOS");
        DataTable TablaRol = ds.Tables[0];

        string codigo;
        string id;
        string nombre;
        string apellido;
        string telefono;
        string direccion;
        string salario;

        string cadena;

        codigo = TablaRol.Rows[0]["codEmpleado"].ToString();
        id = TablaRol.Rows[0]["idEmpleado"].ToString();
        nombre = TablaRol.Rows[0]["nombreEmpleado"].ToString();
        apellido = TablaRol.Rows[0]["apellidoEmpleado"].ToString();
        telefono = TablaRol.Rows[0]["telefonoEmpleado"].ToString();
        direccion = TablaRol.Rows[0]["direccionEmpleado"].ToString();
        salario = TablaRol.Rows[0]["salarioEmpleado"].ToString();
        cadena = "CODIGO: " + codigo + "\nID: " + id + "\nNOMBRE: " + nombre + "\nAPELLIDO: " + apellido + "\nTELEFONO: " + telefono + "\nDIRECCION: " + direccion + "\nSALARIO: "+salario;


        conexion.Close();
        return cadena;
    }


    }
    
