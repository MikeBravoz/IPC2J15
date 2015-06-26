using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace QuetzalExpress
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblfecha.Text = System.DateTime.Now.ToString();
            lblusuario.Text = "Invitado";
            lblusuario.Visible = true; 
        }


        
        //public List<string[]> parseCSV(string path)
        //{
        //    List<string[]> parsedData = new List<string[]>();

        //    using (StreamReader readFile = new StreamReader(path))
        //    {
        //        string line;
        //        string[] row;

        //        while ((line = readFile.ReadLine()) != null)
        //        {
        //            row = line.Split(',');
        //            parsedData.Add(row);
        //        }
        //    }
        //    return parsedData;
        //}


        protected void btncargar_Click(object sender, EventArgs e)
        {

        }

        protected void btnClasificacion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrar/Clasificacion.aspx");
        }
        //{

        //    String savePath = @"C:\Users\LJYELA\Downloads\";
        //    if (FileUpload1.HasFile)
        //    {
        //        String fileName = FileUpload1.FileName;
        //        savePath += fileName;
        //        FileUpload1.SaveAs(savePath);
        //        parseCSV2(savePath);
        //    }
        //}
        //public List<string[]> parseCSV2(string path)
        //{
        //    List<string[]> parsedData = new List<string[]>();

        //    using (StreamReader readFile = new StreamReader(path))
        //    {
        //        string line = "'";
        //        string[] row;

        //        while ((line = readFile.ReadLine()) != null)
        //        {
        //            row = line.Split(',');
        //            parsedData.Add(row);
        //            ConexionWeb.ServiceSoapClient W1 = new ConexionWeb.ServiceSoapClient();

        //           // Webservice.Servicio W1 = new Webservice.Servicio();
        //            W1.perdidos(Convert.ToInt32(row[0]), row[1], row[2], Convert.ToInt32(row[3]), Convert.ToInt32(row[4]));
        //        }
        //        GridView6.DataBind();
        //        Response.Redirect("Empleado.aspx");
        //    }
        //    return parsedData;







            //string path = FileUpload1.FileName;      
            //string url=Server.MapPath(FileUpload1.FileContent.ToString());
            //txtpantalla.Text = path;
            //txtpantalla.Text = parseCSV(url).ToString();

            
                
            
            


        }
    }
