using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {

        public enum Rol { ADMINISTRADOR, ORGANIZADOR };

        #region atributos privados

        private string email;
        private string contrasenia;
        private Rol rol;
        private string usuario;


        #endregion
        #region Properties

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public Rol Tipo
        {
            get { return rol; }
            set { rol = value; }
        }

        public string Usuarioo
        {
            get { return usuario; }
            set { usuario = value; }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// constructor de usuarios
        /// </summary>
        /// <param name="email"></param>
        /// <param name="contrasenia"></param>
        /// <param name="unTipo"></param>
        public Usuario(string email, string contrasenia, Rol unTipo)
        {
            this.email = email;
            this.contrasenia = contrasenia;
            this.Tipo = unTipo;
        }

        public override string ToString()
        {
            return this.Tipo + "\n  Email: " + Email;
        }
        #endregion

    }
}
