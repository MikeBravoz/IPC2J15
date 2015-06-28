using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuetzalExpress.Empleado
{
    public partial class Lote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblfecha.Text = System.DateTime.Now.ToString();
            lblusuario.Text = Session["SessionEmpleado"].ToString();
            lblusuario.Visible = true; 
        }
    }
}