using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class OrganizadorEventos : Usuario
    {
        #region atributos privados

        private string nombre;
        private int telefono;
        private string direccion;
        private DateTime fecha = new DateTime();
        #endregion
        #region Properties

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        #endregion
        #region Metodos
        /// <summary>
        /// constructor de OrganizadorEventos que hereda de usuarios
        /// </summary>
        /// <param name="email"></param>
        /// <param name="contrasenia"></param>
        /// <param name="nombre"></param>
        /// <param name="telefono"></param>
        /// <param name="direccion"></param>
        public OrganizadorEventos(string email, string contrasenia, string nombre, int telefono, string direccion):base(email, contrasenia, Usuario.Rol.ORGANIZADOR)
        {
          
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            fecha = DateTime.Today;
        }

        public override string ToString()
        {
            return base.ToString() + "\n  Nombre: " + nombre + "\n  Telefono: " + telefono + "\n  Direccion: " + direccion + "\n  Fecha: " + fecha;
        }
        #endregion
    }
}
