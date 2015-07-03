using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace QuetzalExpress.Administrar
{
    public partial class Clasificacion : System.Web.UI.Page
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

        protected void btncargar_Click(object sender, EventArgs e)
        {
            String savePath = @"C:\Users\Johnny Bravo\Documents\GitHub\IPC2J15\Fase2\Documentacion\Archivos de Carga Masiva\";
            if (FUcategorias.HasFile)
            {
                String fileName = FUcategorias.FileName;
                savePath += fileName;
                FUcategorias.SaveAs(savePath);
                parseCSV2(savePath);
                dgvDatos.DataBind();
                Response.Redirect("~/Administrar/Clasificacion.aspx");

            }
        }
        public List<string[]> parseCSV2(string path)
        {
            List<string[]> parsedData = new List<string[]>();

            using (StreamReader readFile = new StreamReader(path))
            {
                string line;
                string[] row;

                while ((line = readFile.ReadLine()) != null)
                {
                    row = line.Split(',');
                    parsedData.Add(row);
                    ConexionWeb.ServiceSoapClient service = new ConexionWeb.ServiceSoapClient();
                    service.insertarCategoria(row[0],Convert.ToInt32(row[1]));


                }


            }
            return parsedData;
        }
    }
}