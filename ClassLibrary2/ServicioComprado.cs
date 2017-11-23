using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ServicioComprado
    {
        
        #region atributos privados

        private string nombre;
        private string descripcion;
        private int precioPorPersona;
        private int cantidadContratada;

        #endregion
        #region Properties
        public int CantidadContratada
        {
            get { return cantidadContratada; }
            set { cantidadContratada = value; }
        }

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
        /// constructor de ServicioComprado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="precioPorPersona"></param>
        /// <param name="cantidadContratada"></param>
        public ServicioComprado(string nombre, string descripcion, int precioPorPersona, int cantidadContratada)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioPorPersona = precioPorPersona;
            this.cantidadContratada = cantidadContratada;
        }

        public override string ToString()
        {
            return "\nNombre: " + nombre + "\nDescripcion: " + descripcion + "\nPrecio por persona: " + precioPorPersona + "\nCantidad de personas contratadas: " + cantidadContratada + "\nTotal por servicio: " + totalPorServicio() + "\n";
        }

        /// <summary>
        /// calcula el costo total por cada servicio comprado
        /// </summary>
        /// <returns></returns>
        public double totalPorServicio()
        {
            double total = precioPorPersona * cantidadContratada;
            return total;
        }
        #endregion
    }
}
