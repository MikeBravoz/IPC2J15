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
        public String leerArchivo(string path)
        {
            string cadena="";
            //StreamReader leer = new StreamReader(path + FileUpload1.FileName);
            cadena = System.IO.File.ReadAllText(path + FileUpload1.FileName);

            return cadena;
        }

        protected void btncargar_Click(object sender, EventArgs e)
        {
            String savePath = @"C:\Users\Johnny Bravo\Documents\GitHub\IPC2J15\CSV\";
            if (FileUpload1.HasFile)
            {
                String fileName = FileUpload1.FileName;
                savePath += fileName;
                FileUpload1.SaveAs(savePath);
                parseCSV2(savePath);
                dgvDatos.DataBind();
                Response.Redirect("~/Administrar/Clasificacion.aspx");

            }
        }
        public List<string[]> parseCSV2(string path)
        {
            List<string[]> parsedData = new List<string[]>();
            Boolean mensaje = false;
            using (StreamReader readFile = new StreamReader(path))
            {
                string line;
                string[] row;

                while ((line = readFile.ReadLine()) != null)
                {
                    row = line.Split(',');
                    parsedData.Add(row);
                    ConexionWeb.ServiceSoapClient service = new ConexionWeb.ServiceSoapClient();
                    mensaje= service.insertarCategoria(row[0], Convert.ToInt32(row[1]));
                    Response.Redirect("~/Administrar/Clasificacion.aspx");

                }

                if(mensaje==true)
                {
                   

                    string cadena = "Se han cargado los archivos con exito";
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + cadena + "');</script>");
                    Response.Redirect("~/Administrar/Clasificacion.aspx");
                }
                else
                {
                    string cadena ="ERROR al cargar archivos";
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + cadena + "');</script>");
                }

            }
            return parsedData;
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
