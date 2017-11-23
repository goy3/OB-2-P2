using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Premium : Evento
    {
        #region atributos privados

        private double aumento = 60; /// <summary>
        /// porcentaje de aumento
        /// </summary>
        #endregion

        #region Properties

        public double Aumento
        {
            get { return aumento; }
            set { aumento = value; }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// constructor de evento Premium
        /// </summary>
        /// <param name="unTurno"></param>
        /// <param name="fecha"></param>
        /// <param name="descripcion"></param>
        /// <param name="nombre"></param>
        /// <param name="unTipo"></param>
        /// <param name="asistentes"></param>
        /// <param name="organizador"></param>
        public Premium(EnumTurno unTurno, DateTime fecha,  string descripcion, string nombre, EnumTipo unTipo, int asistentes, OrganizadorEventos organizador) : base(unTurno, fecha, descripcion, nombre, unTipo, asistentes, organizador)
        {
            
        }

        public override string ToString()
        {
            string lista = "";
            
            for(int i = 0; i < ServiciosComprados.Count(); i++)
            {
                lista = lista + ServiciosComprados[i].ToString();
            }
            return base.ToString() + "\n Aumento: " + aumento + "%" + "\n\nServicios Contratados: " + lista + "\nCosto Total: " + CalcularTotalPremium(aumento) + "\n";
        }

        /// <summary>
        /// calcula el total dependiendo del porcentaje de aumento precargado
        /// </summary>
        /// <param name="aumento"></param>
        /// <returns></returns>
        public double CalcularTotalPremium(double aumento)
        {
            double neto = CalcularCostoTotal();
            double total = (neto + (neto * aumento) / 100);
            Totales += total;
            return total;
        }
        #endregion

    }
}
