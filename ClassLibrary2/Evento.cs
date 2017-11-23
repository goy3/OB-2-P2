using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Evento
    {
        public enum EnumTurno { Mañana, Tarde, Noche }
        public enum EnumTipo { Comun, Premium}
        #region atributos privados


        private OrganizadorEventos organizador;
        private DateTime fecha;
        private EnumTurno turno;
        private string descripcion;
        private EnumTipo tipo;
        private static int ultCodigo;
        private int codigo;
        private int asistentes;
        private List<ServicioComprado> serviciosComprados = new List<ServicioComprado>();
        private double totales;
        private string nombre;
        #endregion
        #region Properties

        public int Asistentes
        {
            get { return asistentes; }
            set { asistentes = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public EnumTurno Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public EnumTipo Tipo    
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public List<ServicioComprado> ServiciosComprados 
        {
            get { return serviciosComprados; }
            set { serviciosComprados = value; }
        }

        
        public OrganizadorEventos Organizador
        {
            get { return organizador; }
            set { organizador = value; }
        }

        public double Totales
        {
            get { return totales; }
            set { totales = value; }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// constructor de Evento
        /// </summary>
        /// <param name="unTurno"></param>
        /// <param name="fecha"></param>
        /// <param name="descripcion"></param>
        /// <param name="nombre"></param>
        /// <param name="unTipo"></param>
        /// <param name="asistentes"></param>
        /// <param name="organizador"></param>
        public Evento(EnumTurno unTurno, DateTime fecha, string descripcion, string nombre, EnumTipo unTipo, int asistentes, OrganizadorEventos organizador)
        {
            this.codigo = ultCodigo;
            ultCodigo++;
            this.Turno = unTurno;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.nombre = nombre;
            Tipo = unTipo;
            this.asistentes = asistentes;
            this.organizador = organizador;

        }

        /// <summary>
        /// dependiendo del numero del turno elegido selecciona un item del enumTurno. 
        /// </summary>
        /// <param name="nuevoTurno"></param>
        public void ElegirTurno(int nuevoTurno)
        {
            if(nuevoTurno == 1)
            {
                turno = EnumTurno.Mañana;
            }
            else if(nuevoTurno == 2)
            {
                turno = EnumTurno.Tarde;
            }
            else if(nuevoTurno == 3)
            {
                turno = EnumTurno.Noche;
            }
        }

        /// <summary>
        /// dependiendo del numero del tipo elegido selecciona un item del enumTipo.
        /// </summary>
        /// <param name="nuevoTipo"></param>
        public void ElegirTipo(string nuevoTipo)
        {
            if(nuevoTipo == "1")
            {
                tipo = EnumTipo.Comun;
            }
            else if(nuevoTipo == "2")
            {
                tipo = EnumTipo.Premium;
            }
        }
   
        public override string ToString()
        {
            return "EVENTO: " + codigo + "\n Fecha: " + fecha + "\n Nombre del cliente: " + nombre + "\n Tipo de evento: " + tipo + "\n Asistentes: " + asistentes + "\n Turno: " + turno + "\n Organizador: " + organizador.Nombre;
        }

        /// <summary>
        /// agrega un servicio a la lista de servicios comprados
        /// </summary>
        /// <param name="servicio"></param>
        public void AgregarServicioComprado(ServicioComprado servicio)
        {
            serviciosComprados.Add(servicio);
        }

        /// <summary>
        /// recorre la lista de servicios comprados para calcular el costo total de todos los servicios
        /// </summary>
        /// <returns></returns>
        public double CalcularCostoTotal()
        {
            double total = 0;
            foreach (ServicioComprado unServicio in serviciosComprados)
            {
                total += unServicio.totalPorServicio();
            }
           
            return total;
        }
        #endregion

    }
}
