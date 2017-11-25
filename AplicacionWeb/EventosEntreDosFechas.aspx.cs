using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AplicacionWeb
{
    public partial class EventosEntreDosFechas : System.Web.UI.Page
    {
        Eventos2017 unE = Eventos2017.Instancia;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrarEventos_Click(object sender, EventArgs e)
        {
            DateTime fechaInicial = CalendarioFechaInicial.SelectedDate;
            DateTime fechaFinal = CalendarioFechaFinal.SelectedDate;

            MostrarEventosEntreDosFechas(fechaInicial, fechaFinal);
        }

        private void MostrarEventosEntreDosFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            foreach (Evento unEvento in Eventos2017.Instancia.Eventos)
            {
                if(fechaFinal > unEvento.Fecha && fechaInicial < unEvento.Fecha)
                {
                    Panel1.Visible = false;
                    Panel2.Visible = false;
                    TablaMostrarEventosEntreDosFechas.DataSource = Eventos2017.Instancia.Eventos;
                    TablaMostrarEventosEntreDosFechas.DataBind();
                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MenuAdministrador.aspx");
        }
    }
}