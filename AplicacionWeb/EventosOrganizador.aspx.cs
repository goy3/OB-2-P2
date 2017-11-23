using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AplicacionWeb
{
    public partial class EventosOrganizador : System.Web.UI.Page
    {
        Eventos2017 unE = Eventos2017.Instancia;
        protected void Page_Load(object sender, EventArgs e)
        {
            TablaEventosPorOrganizador.DataSource = unE.DevolverEventosDeOrganizador((string)Session["usu"]);
            TablaEventosPorOrganizador.DataBind();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MenuOrganizador.aspx");
        }

        protected void btnListarEventos_Click(object sender, EventArgs e)
        {
            //Usuario unUsuario = unE.BuscarOrganizadorPorMail((string)Session["usu"]);
            //Response.Redirect("~/ListaEventosPorOrganizador.aspx");
            //TablaEventosPorOrganizador.DataSource = unE.DevolverEventosDeOrganizador((string)Session["usu"]);
            //TablaEventosPorOrganizador.DataBind();
        }
    }
}

//Usuario.GetType() == typeof(Organizador)