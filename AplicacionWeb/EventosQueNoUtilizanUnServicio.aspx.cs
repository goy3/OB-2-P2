using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AplicacionWeb
{
    public partial class EventosQueNoUtilizanUnServicio : System.Web.UI.Page
    {
        Eventos2017 unE = Eventos2017.Instancia;
        protected void Page_Load(object sender, EventArgs e)
        {
            TablaServicios.DataSource = unE.Servicios;
            TablaServicios.DataBind();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MenuAdministrador.aspx");
        }

        protected void TablaServicios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int posServicio;
            if(e.CommandName == "Ver")
            {
                posServicio = int.Parse((string)e.CommandArgument);
                //TablaEventosSinUnServicio.DataSource = unE.Eventos[posServicio].ServiciosComprados;
                //TablaEventosSinUnServicio.DataSource = unE.ServicioEsta((ServicioComprado)e.CommandArgument);
                TablaEventosSinUnServicio.DataBind();
                TablaEventosSinUnServicio.Visible = true;
            }
        }

    }
}