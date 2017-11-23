using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Servicios
    {
        #region atributos privados

        private string nombre;
        private string descripcion;
        private int precioPorPersona;


        #endregion
        #region Properties

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int PrecioPorPersona
        {
            get { return precioPorPersona; }
            set { precioPorPersona = value; }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// constructor de Servicios
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="precioPorPersona"></param>
        public Servicios(string nombre, string descripcion, int precioPorPersona)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioPorPersona = precioPorPersona;
        }

        public override string ToString()
        {
            return nombre + "\nDescripcion: " + descripcion + "\nPrecio por persona: " + precioPorPersona;
        }
        #endregion
    }
}
