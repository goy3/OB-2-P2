using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AplicacionWeb
{
    public partial class MostrarUsuarios : System.Web.UI.Page
    {
        Eventos2017 unE = Eventos2017.Instancia;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TablaMostrarUsuarios.DataSource = unE.Usuarios;
                TablaMostrarUsuarios.DataBind();
            }
            
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            //Usuario unUsuario = (Usuario)Session["usu"];
            if (unE.EsAdministrador((string)Session["usu"]))
            {
                //unUsuario.Tipo == 1
                Response.Redirect("~/MenuAdministrador.aspx");
            }
            else
            {
                Response.Redirect("~/MenuOrganizador.aspx");
            }



        }
    }
}