using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AplicacionWeb
{
    public partial class RegistroOrganizador : System.Web.UI.Page
    {
        Eventos2017 unE = Eventos2017.Instancia;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string contrasenia = txtContrasenia.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;

            if(email == "" || contrasenia == "" || nombre == "" || telefono == "" || direccion == "")
            {
                lblMensaje.Text = "Los campos no pueden estar vacios";
            }
            else
            {
                Usuario unUsuario = unE.BuscarUsuario(email);

                if (unUsuario != null)
                {
                    lblMensajeEmail.Text = "El mail ingresado ya existe. Por favor elija otro";

                }
                else
                {
                    bool correcto = unE.ValidarEmail(email);
                    if (!correcto)
                    {
                        lblMensajeEmail.Text = "El mail ingresado no es correcto. Ingreselo nuevamente";
                    }
                    else
                    {
                        correcto = unE.validarContrasenia(contrasenia);
                        if (!correcto)
                        {
                            lblMensajeContrasenia.Text = "contraseña incorrecta! debe contener minimo 8 digitos, una mayuscula y un caracter especial(!.,;)";
                        }
                        else
                        {
                            correcto = unE.ValidarNombre(nombre);
                            if (!correcto)
                            {
                                lblNombre.Text = "El nombre debe tener al menos 3 caracteres y puede contener solo 1 espacio";
                            }
                            else
                            {
                                if (unUsuario == null)
                                {
                                    unUsuario = new OrganizadorEventos(email, contrasenia, nombre, telefono, direccion);
                                    unE.AltaUsuario(unUsuario);
                                    Response.Redirect("~/Login.aspx");
                                }
                            }



                        }


                    }


                }
            }
            

            
        }
    }
}