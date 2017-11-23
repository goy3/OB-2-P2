using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AplicacionWeb
{
    public partial class MenuOrganizador : System.Web.UI.Page
    {
        Eventos2017 unE = Eventos2017.Instancia;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MostrarUsuarios.aspx");
        }

        protected void btnRegistrarEvento_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RegistrarEvento.aspx");
        }

        protected void btnEventosDeOrganizador_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EventosOrganizador.aspx");
        }
    }
}