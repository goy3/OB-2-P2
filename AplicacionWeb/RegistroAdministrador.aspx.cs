using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AplicacionWeb
{
    public partial class RegistroAdministrador : System.Web.UI.Page
    {
        Eventos2017 unE = Eventos2017.Instancia;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string contrasenia = txtContrasenia.Text;
          
            Usuario usu = unE.BuscarUsuario(email);
            
            while (usu != null)
            {
                lblMensajeEmail.Text = "El mail ingresado ya existe. Por favor elija otro";
                email = txtEmail.Text;
                usu = unE.BuscarUsuario(email);
            }

            bool correcto = unE.ValidarEmail(email);
            while (!correcto)
            {
                lblMensajeEmail.Text = "El mail ingresado no es correcto. Ingreselo nuevamente";
                email = txtEmail.Text;
                correcto = unE.ValidarEmail(email);
            }

            correcto = unE.validarContrasenia(contrasenia);
            while (!correcto)
            {
                lblMensajeContrasenia.Text = "contraseña incorrecta! debe contener minimo 8 digitos, una mayuscula y un caracter especial(!.,;)";
                contrasenia = txtContrasenia.Text;
                correcto = unE.validarContrasenia(contrasenia);
            }

            if(usu == null)
            {
                usu = new Administrador(email, contrasenia);
                unE.AltaUsuario(usu);
                lblMensaje.Text = "Ingresado con éxito";
            }
            else
            {
                lblMensaje.Text = "El mail ingresado ya existe por favor elija otro";
            }
            
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MenuAdministrador.aspx");
        }
    }
}