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

        SqlConnection conect = new SqlConnection("Data Source=PERSONAL;Initial Catalog=PruevaQuetzal;Integrated Security=True");
        
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

    //[WebMethod]
    //public void INSERTAR(ClsUsr Usuario)
    //{
    //    SqlConnection con = new SqlConnection("Data Source=PERSONAL;Initial Catalog=DBTamakoMarket;Integrated Security=True");
    //    con.Open();
    //    SqlCommand cmd2 = new SqlCommand();
    //    cmd2.Connection = con;
    //    cmd2.CommandType = CommandType.Text;
    //    cmd2.CommandText = "INSERT INTO Tabla_Cliente VALUES(@Nombre_Cliente, @Usuario_Cliente, @Contrasena_Cliente, @Dpi_Cliente, @Nit_Cliente, @Telefono_Cliente, @Direccion_Cliente, @Correo_Cliente, @Edad_Cliente, @Sexo_Cliente)";

    //    cmd2.Parameters.Add("@Nombre_Cliente", SqlDbType.VarChar, 50).Value = Usuario.Nombre_Cliente;
    //    cmd2.Parameters.Add("@Usuario_Cliente", SqlDbType.VarChar, 50).Value = Usuario.Usuario_Cliente;
    //    cmd2.Parameters.Add("@Contrasena_Cliente", SqlDbType.VarChar, 50).Value = Usuario.Contrasena_Cliente;
    //    cmd2.Parameters.Add("@Dpi_Cliente", SqlDbType.VarChar, 50).Value = Usuario.Dpi_Cliente;
    //    cmd2.Parameters.Add("@Nit_Cliente", SqlDbType.VarChar, 50).Value = Usuario.Nit_Cliente;
    //    cmd2.Parameters.Add("@Telefono_Cliente", SqlDbType.VarChar, 50).Value = Usuario.Telefono_Cliente;
    //    cmd2.Parameters.Add("@Direccion_Cliente", SqlDbType.VarChar, 50).Value = Usuario.Direccion_Cliente;
    //    cmd2.Parameters.Add("@Correo_Cliente", SqlDbType.VarChar, 50).Value = Usuario.Correo_Cliente;
    //    cmd2.Parameters.Add("@Edad_Cliente", SqlDbType.VarChar, 50).Value = Usuario.Edad_Cliente;
    //    cmd2.Parameters.Add("@Sexo_Cliente", SqlDbType.VarChar, 50).Value = Usuario.Sexo_Cliente;


    //    cmd2.ExecuteNonQuery();
    //    con.Close();
    //}

   

    }
    
