using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb
{
    public partial class Inicio : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsuarioSeleccionado.Text = "Bienvenido " + Session["usu"] + "!";
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session["usu"] = null;
            Response.Redirect("~/Login.aspx");
        }
    }
}