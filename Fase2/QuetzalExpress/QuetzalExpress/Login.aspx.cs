using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuetzalExpress
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblfecha.Text = System.DateTime.Now.ToString();
            lblusuario.Text = "Invitado";
            lblusuario.Visible = true;  

        }

        protected void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}