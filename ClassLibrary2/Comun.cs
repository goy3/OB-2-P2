using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comun : Evento
    {
        #region atributos privados

        private int duracion;
        private int limpieza;
        #endregion
        #region Properties

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public int Limpieza
        {
            get { return limpieza; }
            set { limpieza = value; }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// constructor de usuario comun que hereda de usuario
        /// </summary>
        /// <param name="unTurno"></param>
        /// <param name="fecha"></param>
        /// <param name="descripcion"></param>
        /// <param name="nombre"></param>
        /// <param name="unTipo"></param>
        /// <param name="duracion"></param>
        /// <param name="asistentes"></param>
        /// <param name="organizador"></param>
        public Comun(EnumTurno unTurno, DateTime fecha, string descripcion, string nombre, EnumTipo unTipo, int duracion, int asistentes, OrganizadorEventos organizador) : base(unTurno, fecha, descripcion, nombre, unTipo, asistentes, organizador)
        {

            this.limpieza = 500; /// costo fijo por limpieza
            this.duracion = duracion;  
        }

        public override string ToString()
        {
            string lista = "";
            for (int i = 0; i < ServiciosComprados.Count(); i++)
            {
                lista = lista + ServiciosComprados[i].ToString();
            }
            return base.ToString() + "\n Duracion: " + duracion + "\n Limpieza: " + limpieza + "\n" + "\n\nServicios contratados: " + lista + "\nCosto total: " + CalcularTotalComun(limpieza) + "\n";
        }

        /// <summary>
        /// llama al metodo CalcularCostoTotal y le suma la limpieza. Suma el resultado en la variable Totales y devuelve el total.
        /// </summary>
        /// <param name="limpieza"></param>
        /// <returns></returns>
        public double CalcularTotalComun(int limpieza)
        {
            double total = CalcularCostoTotal() + limpieza;
            Totales += total;
            return total;
        }
        
        #endregion
    }
}
