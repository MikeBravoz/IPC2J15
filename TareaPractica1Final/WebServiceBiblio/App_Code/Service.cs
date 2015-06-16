using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;


[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    SqlConnection conect= new SqlConnection("Data Source=PERSONAL;Initial Catalog=Biblioteca;Integrated Security=True");

    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    //[WebMethod]
    //public void INSERTAR(ClsUsr Usuario)
    //{
    //    SqlConnection con = new SqlConnection("Data Source=PERSONAL;Initial Catalog=Biblioteca;Integrated Security=True");
    //    con.Open();
    //    SqlCommand cmd2 = new SqlCommand();
    //    cmd2.Connection = con;
    //    cmd2.CommandType = CommandType.Text;
    //    cmd2.CommandText = "INSERT INTO Cliente VALUES(@carnet_cliente, @nombre_cliente, @DPI_cliente, @direccion_cliente, @telefono_cliente, @no_prestados_cliente)";

    //   // cmd2.Parameters.Add("@carnet_cliente", SqlDbType.int).Value = Usuario.Nombre_Cliente;
    //    cmd2.Parameters.Add("@nombre_cliente", SqlDbType.VarChar, 50).Value = Usuario.nombre_cliente;
    //    cmd2.Parameters.Add("@DPI_cliente", SqlDbType.Int).Value = Usuario.DPI_cliente;
    //    cmd2.Parameters.Add("@direccion_cliente", SqlDbType.VarChar, 50).Value = Usuario.direccion_cliente;
    //    cmd2.Parameters.Add("@telefono_cliente", SqlDbType.Int).Value = Usuario.telefono_cliente;
    //    cmd2.Parameters.Add("@no_prestados_cliente", SqlDbType.Int).Value = Usuario.no_prestados_cliente;
        


    //    cmd2.ExecuteNonQuery();
    //    con.Close();
    //}
}