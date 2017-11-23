using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AplicacionWeb
{
    
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Login1.UserNameLabelText = "Email";
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string email = Login1.UserName;
            string contrasenia = Login1.Password;

            Eventos2017 unE = Eventos2017.Instancia;
            Usuario usu = unE.BuscarUsuario(email);

            if(usu == null)
            {
                e.Authenticated = false;
            }
            else
            {
                e.Authenticated = true;
                Session["usu"] = usu.Email;

                switch (usu.Tipo)
                {
                    case Usuario.Rol.ADMINISTRADOR:
                        Response.Redirect("~/MenuAdministrador.aspx");
                        break;
                    case Usuario.Rol.ORGANIZADOR:
                        Response.Redirect("~/MenuOrganizador.aspx");
                        break;
                    default:
                        break;
                }
            }

        }
    }
}