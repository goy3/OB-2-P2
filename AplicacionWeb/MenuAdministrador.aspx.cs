using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AplicacionWeb
{
    public partial class Menu : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegistrarAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RegistroAdministrador.aspx");
        }

        protected void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MostrarUsuarios.aspx");
        }

        protected void btnListarServicios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MostrarServicios.aspx");
        }

        protected void btnEventosEntreFechas_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EventosEntreDosFechas.aspx");
        }

        protected void btnEventosQueNoUtilizanServico_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EventosQueNoUtilizanUnServicio.aspx");
        }
    }
}