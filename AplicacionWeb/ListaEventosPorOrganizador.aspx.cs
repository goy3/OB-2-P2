using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AplicacionWeb
{
    public partial class ListaEventosPorOrganizador : System.Web.UI.Page
    {
        Eventos2017 unE = Eventos2017.Instancia;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TablaEventosPorOrganizador.DataSource = unE.DevolverEventosDeOrganizador((string)Session["usu"]);
                TablaEventosPorOrganizador.DataBind();
            }
        }
    }
}