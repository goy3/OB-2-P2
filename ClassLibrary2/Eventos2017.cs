using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Eventos2017
    {
        #region atributos privados

        private static Eventos2017 instancia; 
        private List<Servicios> servicios;
        private List<Usuario> usuarios;
        private List<Evento> eventos;
        private List<DateTime> fechas;
        private List<ServicioComprado> serviciosComprados;
            



        #endregion
        #region Properties

        /// <summary>
        /// singleton
        /// </summary>
        public static Eventos2017 Instancia
        {
            get 
            { 
                if(instancia == null) instancia = new Eventos2017();
                return instancia; 
            }
        }

        public List<DateTime> Fechas
        {
            get { return fechas; }
            set { fechas = value; }
        }

        public List<ServicioComprado> ServiciosComprados
        {
            get { return serviciosComprados; }
            set { serviciosComprados = value; }
        }

        public List<Usuario> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }

        public List<Servicios> Servicios
        {
            get { return servicios; }
            set { servicios = value; }
        }
        #endregion
        #region Metodos

        private Eventos2017()
        {
            usuarios = new List<Usuario>();
            Usuario unU1 = new Administrador("admin@eventos17.com","Admin!99");
            OrganizadorEventos unU2 = new OrganizadorEventos("goybol@hotmail.com", "Holanda!", "Andres", 099715287, "Rondeau 1530");
            AltaUsuario(unU1);  
            AltaUsuario(unU2);

            servicios = new List<Servicios>();
            Servicios unS1 = new Servicios("CABALGATA","Paseo a caballo por el campo", 150);
            Servicios unS2 = new Servicios("CASTILLO INFLABLE", "Inflable para niños", 200);
            Servicios unS3 = new Servicios("SALIDA A CENAR", "Cena para los mas allegados", 300) ;
            AltaServicio(unS1);
            AltaServicio(unS2);
            AltaServicio(unS3);

            eventos = new List<Evento>();
            Evento unE1 = new Comun(Evento.EnumTurno.Noche, DateTime.Today, "Cumpleanos al aire libre", "Adolfo", Evento.EnumTipo.Comun, 4, 9, unU2);
            Evento unE2 = new Premium(Evento.EnumTurno.Tarde, DateTime.Today, "Golf", "Ernestor", Evento.EnumTipo.Premium, 78, unU2);
            AltaEvento(unE1);
            AltaEvento(unE2);
            
            serviciosComprados = new List<ServicioComprado>();
            ServicioComprado unSC1 = new ServicioComprado("Cabalgata", "Paseo a caballo por el campo", 150, 5);
            ServicioComprado unSC2 = new ServicioComprado("Castillo inflable", "Inflable para niños", 200, 22);

            unE1.ServiciosComprados.Add(unSC1);
            unE2.ServiciosComprados.Add(unSC2);
        }
        public void AltaServicio(Servicios unServicio)
        {
            servicios.Add(unServicio);
        }
        /// <summary>
        /// recorre la lista de usuarios comparando el mail ingresado y lo retorna si existe
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Usuario BuscarUsuario(string email)
        {
            Usuario unUsuario = null;
            bool esta = false;
            int posicion = 0;

            while(!esta && posicion < usuarios.Count())
            {
                if(usuarios[posicion].Email == email)
                {
                    esta = true;
                    unUsuario = usuarios[posicion];
                }
                else
                {
                    posicion++;
                }
            }
            return unUsuario;
        }

        /// <summary>
        /// recorre la lista de usuarios y verifica que sean organizadores comparando el rol y el nombre y lo devuelve
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="contrasenia"></param>
        /// <returns></returns>
        public OrganizadorEventos BuscarOrganizador(string nombre, string contrasenia)
        {
            OrganizadorEventos unOrganizador = null;
            bool esta = false;
            int posicion = 0;

            while(!esta && posicion < usuarios.Count())
            {
                if (usuarios[posicion].Tipo == Usuario.Rol.ORGANIZADOR && ((OrganizadorEventos)usuarios[posicion]).Nombre == nombre)
                {
                     if(((OrganizadorEventos)usuarios[posicion]).Contrasenia == contrasenia)
                    {
                        esta = true;
                        unOrganizador = (OrganizadorEventos)usuarios[posicion];
                    }  
                }
                
                else
                {
                    posicion++;
                }
            }
            return unOrganizador;
        }

        /// <summary>
        /// retorna la lista de usuarios
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ListaUsuarios()
        {
            return usuarios;
        }

        /// <summary>
        /// si no existe el mail ingresado lo agrega a la lista de usuarios
        /// </summary>
        /// <param name="unUsuario"></param>
        public void AltaUsuario(Usuario unUsuario)
        {
            if(BuscarUsuario(unUsuario.Email) == null)
            {
                usuarios.Add(unUsuario);
            }
        }

        /// <summary>
        /// recorre la lista de eventos y compara el codigo del evento. Si lo encuentra lo retorna.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Evento BuscarEvento(int codigo)
        {
            Evento unoEvento = null;
            bool esta = false;
            int posicion = 0;

            while (!esta && posicion < eventos.Count())
            {
                if (eventos[posicion].Codigo == codigo)
                {
                    esta = true;
                    unoEvento = eventos[posicion];
                }
                else
                {
                    posicion++;
                }
            }
            return unoEvento;
        }

        /// <summary>
        /// recorre la lista de eventos mediante el metodo BuscarEvento. Si el codigo es null agrega el evento
        /// </summary>
        /// <param name="unoEvento"></param>
        public void AltaEvento(Evento unoEvento)
        {
            if(BuscarEvento(unoEvento.Codigo) == null)
            {
                eventos.Add(unoEvento);
            }
        }

        /// <summary>
        /// recorre la lista de servicios y compara el nombre. Si encuentra una coincidencia lo devuelve.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Servicios BuscarServicio(string nombre)
        {
            Servicios unServicio = null;
            bool esta = false;
            int posicion = 0;

            while(!esta && posicion < servicios.Count())
            {
                if(servicios[posicion].Nombre == nombre.ToUpper())
                {
                    esta = true;
                    unServicio = servicios[posicion];
                }
                else
                {
                    posicion++;
                }

            }
            return unServicio;
        }

        /// <summary>
        /// retorna la lista de servicios
        /// </summary>
        /// <returns></returns>
        public List<Servicios> ListaServicios()
            {
                return servicios;
            }

        /// <summary>
        /// retorna la lista de eventos
        /// </summary>
        /// <returns></returns>
        public List<Evento> Eventos()
        {
            return eventos;
        }

        /// <summary>
        /// recorre la lista de servicios 
        /// </summary>
        /// <param name="unServicio"></param>
        public void ComprarServicio(Servicios unServicio)
        {
            if(BuscarServicio(unServicio.Nombre)==null)
            {
                servicios.Add(unServicio);
            }
        }

        /// <summary>
        /// busca un organizador por su mail
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public OrganizadorEventos BuscarOrganizadorPorMail(string email)
        {
            OrganizadorEventos unOrganizador = null;
            bool esta = false;
            int posicion = 0;

            while (!esta && posicion < usuarios.Count())
            {
                if (usuarios[posicion].Tipo == Usuario.Rol.ORGANIZADOR && ((OrganizadorEventos)usuarios[posicion]).Email == email)
                {
                        esta = true;
                        unOrganizador = (OrganizadorEventos)usuarios[posicion];   
                }
                else
                {
                    posicion++;
                }
            }
            return unOrganizador;
        }

        /// <summary>
        /// recorre la lista de eventos y compara el mail. Si coincide lo agrega a la lista auxiliar. Luego retorna la lista auxiliar
        /// </summary>
        /// <param name="organizador"></param>
        /// <returns></returns>
        //public List<Evento> DevolverEventosDeOrganizador(OrganizadorEventos organizador)
        //{
        //    List<Evento> EventosOrganizador = new List<Evento>();
        //    foreach (Evento unoEvento in eventos)
        //    {
        //        if (unoEvento.Organizador.Email == organizador.Email)
        //        {
        //            EventosOrganizador.Add(unoEvento);
        //        }
        //    }
        //    return EventosOrganizador;
        //}

        public List<Evento> DevolverEventosDeOrganizador(string email)
        {
            List<Evento> EventosOrganizador = new List<Evento>();
            foreach (Evento unoEvento in eventos)
            {
                if (unoEvento.Organizador.Email == email)
                {
                    EventosOrganizador.Add(unoEvento);
                }
            }
            return EventosOrganizador;
        }

        /// <summary>
        /// recorre la lista de eventos y compara la fecha
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public bool BuscarEventoPorFecha(DateTime fecha)
        {
            bool esta = false;
            int posicion = 0;

            while (!esta && posicion < eventos.Count())
            {
                if (eventos[posicion].Fecha == fecha)
                {
                    esta = true;
                }
                else
                {
                    posicion++;
                }
            }
            return esta;
        }

        public bool ValidarEmail(string email)
        {
            bool valido = false;
            int arrobas = 0;
            int posicionDeArroba = 0;
            int punto = 0;
            int posicionDelPunto = 0;
            int carateresDespuesDelPunto = 0;
            int espacioVacio = 0;


            Char caracterABuscar = '@';
            Char buscarPunto = '.';
            Char buscarVacio = ' ';

            for (int i = 1; i < email.Length; i++)
            {
                if (email[i] == caracterABuscar)
                {
                    arrobas++;
                    posicionDeArroba = i;
                }
            }
            for (int j = 0; j < email.Length; j++)
            {
                if (email[j] == buscarPunto)
                {
                    punto++;
                    posicionDelPunto = j;
                }
            }
            for (int k = posicionDelPunto; k < email.Length; k++)
            {
                carateresDespuesDelPunto++;
            }
            for (int m = 0; m < email.Length; m++)
            {
                if (email[m] == buscarVacio)
                {
                    espacioVacio++;
                }
            }

            if (arrobas == 1 && punto == 1 && carateresDespuesDelPunto > 2 && email.Length > 3 && posicionDeArroba < posicionDelPunto && posicionDelPunto - posicionDeArroba > 1 && espacioVacio == 0)
            {
                valido = true;
            }
            return valido;
        }

        public bool validarContrasenia(string contrasenia)
        {
            bool valido = false;
            int contadorMayuscula = 0;
            int contadorCaracterEspecial = 0;

            if (contrasenia.Length > 7)
            {
                for (int i = 0; i < contrasenia.Length; i++)
                {
                    if (Char.IsUpper(contrasenia[i]))
                    {
                        contadorMayuscula++;
                    }
                    if (contrasenia[i] == '!' || contrasenia[i] == '.' || contrasenia[i] == ',' || contrasenia[i] == ';')
                    {
                        contadorCaracterEspecial++;
                    }
                }
            }
            if (contadorCaracterEspecial > 0 && contadorMayuscula > 0)
            {
                valido = true;
            }
            return valido;
        }

        public bool EsAdministrador(string unUsuario)
        {
            bool administrador = false;
            int posicion = 0;
            foreach (Usuario unoUsuario in usuarios)
            {
                if(usuarios[posicion].Tipo == Usuario.Rol.ADMINISTRADOR)
                {
                    administrador = true;
                }
            }
            return administrador;
        }
        #endregion

    }
}




/*class Program
{
    static void Main(string[] args)
    {
        Eventos2017 unEvento = Eventos2017.Instancia;


        Usuario unUsuario;
        Servicios unServicio;
        OrganizadorEventos organizador;
        string email;
        string contrasenia;
        string nombre;
        int telefono;
        string direccion;
        DateTime fecha;
        int turnoElegido;
        string descripcion;
        int tipoElegido;
        int asistentes;
        int duracion;



        bool meVoy = false;

        while (!meVoy)
        {
            Console.WriteLine();
            Console.WriteLine("     EVENTOS 2017\n\n");
            Console.WriteLine("1- Registro de administrador");
            Console.WriteLine("2- Registro de organizador");
            Console.WriteLine("3- Listar todos los usuarios");
            Console.WriteLine("4- Listar el catalogo de servicios");
            Console.WriteLine("5- Registrar un evento");
            Console.WriteLine("6- Eventos de un organizador");

            int num = PedirNumero("9- Salir");

            Console.Clear();

            switch (num)
            {
                case 1:
                    email = PedirTexto("email: ");
                    unUsuario = unEvento.BuscarUsuario(email);
                    while (unUsuario != null)
                    {
                        Console.WriteLine("El mail " + unUsuario.Email + " ya existe");
                        email = PedirTexto("email: ");
                        unUsuario = unEvento.BuscarUsuario(email);
                    }

                    bool correcto = ValidarEmail(email);
                    while (!correcto)
                    {
                        Console.WriteLine("Mail invalido! formato correcto: xxx@xxx.xxx");
                        email = PedirTexto("email: ");
                        correcto = ValidarEmail(email);
                    }


                    contrasenia = PedirTexto("contraseña: ");
                    correcto = validarContrasenia(contrasenia);
                    while (!correcto)
                    {
                        Console.WriteLine("contraseña incorrecta! debe contener minimo 8 digitos, una mayuscula y un caracter especial(!.,;)");
                        contrasenia = PedirTexto("contraseña: ");
                        correcto = validarContrasenia(contrasenia);
                    }

                    if (unUsuario == null)
                    {
                        unUsuario = new Administrador(email, contrasenia);
                        unEvento.AltaUsuario(unUsuario);
                        Console.WriteLine("Ingresado con exito!");
                    }
                    break;

                case 2:
                    email = PedirTexto("email: ");
                    unUsuario = unEvento.BuscarUsuario(email);
                    while (unUsuario != null)
                    {
                        Console.WriteLine("El mail " + unUsuario.Email + " ya existe");
                        email = PedirTexto("email: ");
                        unUsuario = unEvento.BuscarUsuario(email);
                    }


                    correcto = ValidarEmail(email);
                    while (!correcto)
                    {
                        Console.WriteLine("Mail invalido! formato correcto: xxx@xxx.xxx");
                        email = PedirTexto("email: ");
                        correcto = ValidarEmail(email);
                    }


                    contrasenia = PedirTexto("contraseña: ");
                    correcto = validarContrasenia(contrasenia);
                    while (!correcto)
                    {
                        Console.WriteLine("contraseña incorrecta! debe contener minimo 8 digitos, una mayuscula y un caracter especial(!.,;)");
                        contrasenia = PedirTexto("contraseña: ");
                        correcto = validarContrasenia(contrasenia);
                    }
                    nombre = PedirTexto("nombre: ");
                    correcto = ValidarNombre(nombre);
                    while (!correcto)
                    {
                        Console.WriteLine("Error! El nombre debe tener al menos 3 caracteres y puede contener solo 1 espacio");
                        nombre = PedirTexto("nombre: ");
                        correcto = ValidarNombre(nombre);
                    }
                    telefono = PedirNumero("telefono: ");

                    direccion = PedirTexto("direccion: ");
                    correcto = ValidarNombre(direccion);
                    while (!correcto)
                    {
                        Console.WriteLine("Error! La direccion debe tener al menos 3 caracteres y puede contener solo 1 espacio");
                        direccion = PedirTexto("direccion: ");
                        correcto = ValidarNombre(direccion);
                    }

                    if (unUsuario == null)
                    {
                        unUsuario = new OrganizadorEventos(email, contrasenia, nombre, telefono, direccion);
                        unEvento.AltaUsuario(unUsuario);
                    }

                    break;

                case 3:
                    mostrarUsuarios(unEvento);
                    break;
                case 4:
                    mostrarServicios(unEvento);
                    break;
                case 5:
                    nombre = PedirTexto("nombre: ");
                    correcto = ValidarNombre(nombre);
                    while (!correcto)
                    {
                        Console.WriteLine("Error! El nombre debe tener al menos 3 caracteres");
                        nombre = PedirTexto("nombre: ");
                        correcto = ValidarNombre(nombre);
                    }
                    contrasenia = PedirTexto("contraseña: ");
                    correcto = validarContrasenia(contrasenia);
                    while (!correcto)
                    {
                        Console.WriteLine("contraseña incorrecta! debe contener minimo 8 digitos, una mayuscula y un caracter especial(!.,;)");
                        contrasenia = PedirTexto("contraseña: ");
                        correcto = validarContrasenia(contrasenia);
                    }

                    unUsuario = unEvento.BuscarOrganizador(nombre, contrasenia);

                    if (unUsuario != null)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine(unUsuario);
                        fecha = pedirFecha("\nIngrese la fecha: \n formato: dd/mm/aaaa o dd-mm-aaaa");


                        while (fecha < DateTime.Today)
                        {
                            Console.WriteLine("Error! La fecha no puede ser anterior a hoy");
                            fecha = pedirFecha("Ingrese la fecha: \nformato: dd/mm/aaaa o dd-mm-aaaa");
                        }
                        correcto = unEvento.BuscarEventoPorFecha(fecha);
                        while (correcto)
                        {
                            Console.WriteLine("Ya existe un evento en la fecha ingresada. Por favor ingrese otra");
                            fecha = pedirFecha("Ingrese la fecha: \nformato: dd/mm/aaaa o dd-mm-aaaa");
                            correcto = unEvento.BuscarEventoPorFecha(fecha);
                        }


                        turnoElegido = PedirNumero("Seleccione un turno: \n 1- Mañana \n 2- Tarde \n 3- Noche");
                        while (turnoElegido < 1 || turnoElegido > 3)
                        {
                            Console.WriteLine("Opcion incorrecta!");
                            turnoElegido = PedirNumero("Seleccione un turno: \n 1 - Mañana \n 2 - Tarde \n 3 - Noche");

                        }

                        descripcion = PedirTexto("Ingrese una breve descripcion: ");
                        correcto = ValidarNombre(descripcion);
                        while (!correcto)
                        {
                            Console.WriteLine("Error! La descripcion debe tener al menos 3 caracteres");
                            descripcion = PedirTexto("descripcion: ");
                            correcto = ValidarNombre(descripcion);
                        }

                        nombre = PedirTexto("Nombre del cliente: ");
                        correcto = ValidarNombre(nombre);
                        while (!correcto)
                        {
                            Console.WriteLine("Error! El nombre debe tener al menos 3 caracteres");
                            nombre = PedirTexto("nombre: ");
                            correcto = ValidarNombre(nombre);
                        }

                        tipoElegido = PedirNumero("Seleccione tipo de evento: \n 1- Comun \n 2- Premium");
                        while (tipoElegido < 1 || tipoElegido > 2)
                        {
                            Console.WriteLine("Opcion incorrecta!");
                            tipoElegido = PedirNumero("Seleccione tipo de evento: \n 1 - Comun \n 2 - Premium");
                        }
                        if (tipoElegido == 1)
                        {
                            asistentes = PedirNumero("Ingrese cantidad de asistentes: ");
                            correcto = false;
                            while (!correcto)
                            {
                                if (asistentes <= 10 && asistentes > 0)
                                {
                                    correcto = true;

                                }
                                else
                                {
                                    Console.WriteLine("Error! La cantidad de asistentes para los eventos comunes debe ser entre 1 y 10");
                                    asistentes = PedirNumero("Ingrese cantidad de asistentes: ");
                                }
                            }
                            duracion = PedirNumero("Ingrese la duracion del evento: ");
                            correcto = false;
                            while (!correcto)
                            {
                                if (duracion <= 4 && duracion > 0)
                                {
                                    correcto = true;

                                }
                                else
                                {
                                    Console.WriteLine("Error! La duracion debe estar entre 1 y 4 horas");
                                    duracion = PedirNumero("Ingrese la duracion del evento: ");
                                }
                            }

                            Evento unEventoComun = new Comun(Evento.EnumTurno.Mañana, fecha, descripcion, nombre, Evento.EnumTipo.Comun, duracion, asistentes, ((OrganizadorEventos)unUsuario));
                            unEventoComun.ElegirTurno(turnoElegido);


                            correcto = false;
                            while (!correcto)
                            {
                                Console.WriteLine("Desea agregar algun servicio?");
                                string serviciosSiNo = PedirTexto("S/N: ");

                                bool otroCorrecto = false;
                                if (serviciosSiNo.ToUpper().Trim() == "S")
                                {
                                    mostrarServicios(unEvento);
                                    string nombreServicio = PedirTexto("\nIngrese el nombre del servicio deseado: ");
                                    unServicio = unEvento.BuscarServicio(nombreServicio);
                                    if (unServicio != null)
                                    {
                                        int cantidadParaServicio = PedirNumero("\nIngrese la cantidad de personas para el servicio: ");
                                        while (!otroCorrecto)
                                        {
                                            if (cantidadParaServicio < 0 || cantidadParaServicio > asistentes)
                                            {
                                                Console.WriteLine("Error! La cantidad de personas no puede ser 0 y no puede ser mayor al total de personas que asisten al evento");
                                                cantidadParaServicio = PedirNumero("Ingrese la cantidad de personas para el servicio: ");
                                            }
                                            else
                                            {
                                                ServicioComprado nuevoServicioComprado = new ServicioComprado(unServicio.Nombre, unServicio.Descripcion, unServicio.PrecioPorPersona, cantidadParaServicio);
                                                unEventoComun.ServiciosComprados.Add(nuevoServicioComprado);
                                                Console.WriteLine("Se ha ingresado el servicio indicado");
                                                otroCorrecto = true;
                                            }
                                        }

                                    }

                                }
                                else if (serviciosSiNo.ToUpper().Trim() == "N")
                                {
                                    correcto = true;
                                }
                                else
                                {
                                    Console.WriteLine("Error! ingrese S o N");
                                    serviciosSiNo = PedirTexto("S/N: ");
                                }
                            }
                            unEvento.AltaEvento(unEventoComun);
                            mostrarEvento(unEventoComun);
                        }
                        else if (tipoElegido == 2)
                        {
                            asistentes = PedirNumero("Ingrese cantidad de asistentes: ");
                            correcto = false;
                            while (!correcto)
                            {
                                if (asistentes <= 100 && asistentes > 0)
                                {
                                    correcto = true;

                                }
                                else
                                {
                                    Console.WriteLine("Error! La cantidad de asistentes para los eventos premium debe ser entre 1 y 100");
                                    asistentes = PedirNumero("Ingrese cantidad de asistentes: ");
                                }
                            }
                            Evento unEventoPremium = new Premium(Evento.EnumTurno.Mañana, fecha, descripcion, nombre, Evento.EnumTipo.Premium, asistentes, ((OrganizadorEventos)unUsuario));
                            unEventoPremium.ElegirTurno(turnoElegido);
                            correcto = false;
                            while (!correcto)
                            {
                                Console.WriteLine("Desea agregar algun servicio?");
                                string serviciosSiNo = PedirTexto("S/N: ");

                                bool otroCorrecto = false;
                                if (serviciosSiNo.ToUpper().Trim() == "S")
                                {
                                    mostrarServicios(unEvento);
                                    string nombreServicio = PedirTexto("Ingrese el nombre del servicio deseado: ");
                                    unServicio = unEvento.BuscarServicio(nombreServicio);
                                    if (unServicio != null)
                                    {

                                        int cantidadParaServicio = PedirNumero("\nIngrese la cantidad de personas para el servicio: ");
                                        while (!otroCorrecto)
                                        {
                                            if (cantidadParaServicio < 0 || cantidadParaServicio > asistentes)
                                            {
                                                Console.WriteLine("Error! La cantidad de personas no puede ser 0 y no puede ser mayor al total de personas que asisten al evento");
                                                cantidadParaServicio = PedirNumero("\nIngrese la cantidad de personas para el servicio: ");
                                            }
                                            else
                                            {
                                                ServicioComprado nuevoServicioComprado = new ServicioComprado(unServicio.Nombre, unServicio.Descripcion, unServicio.PrecioPorPersona, cantidadParaServicio);
                                                unEventoPremium.AgregarServicioComprado(nuevoServicioComprado);
                                                Console.WriteLine("Se ha ingresado el servicio indicado");
                                                otroCorrecto = true;

                                            }
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("No existe servicio con ese nombre!");
                                    }

                                }
                                else if (serviciosSiNo.ToUpper().Trim() == "N")
                                {
                                    correcto = true;
                                }
                                else
                                {
                                    Console.WriteLine("Error! ingrese S o N");
                                    serviciosSiNo = PedirTexto("S/N: ");
                                }
                            }
                            unEvento.AltaEvento(unEventoPremium);
                            mostrarEvento(unEventoPremium);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Error! No se encuentra un organizador con ese nombre y esa contraseña");
                    }
                    break;
                case 6:
                    email = PedirTexto("Ingrese mail del organizador: ");
                    organizador = unEvento.BuscarOrganizadorPorMail(email);

                    while (organizador == null)
                    {
                        Console.WriteLine("No se encuentra un organizador con ese email");
                        email = PedirTexto("Ingrese mail del organizador: ");
                        organizador = unEvento.BuscarOrganizadorPorMail(email);
                    }
                    MostrarEventos(unEvento, organizador);
                    break;
                case 9:
                    Console.WriteLine("Hasta Luego");
                    meVoy = true;

                    break;
            }

            Console.ReadKey();
            Console.Clear();
        }
    }


    public static bool ValidarEmail(string email)
    {
        bool valido = false;
        int arrobas = 0;
        int posicionDeArroba = 0;
        int punto = 0;
        int posicionDelPunto = 0;
        int carateresDespuesDelPunto = 0;
        int espacioVacio = 0;


        Char caracterABuscar = '@';
        Char buscarPunto = '.';
        Char buscarVacio = ' ';

        for (int i = 1; i < email.Length; i++)
        {
            if (email[i] == caracterABuscar)
            {
                arrobas++;
                posicionDeArroba = i;
            }
        }
        for (int j = 0; j < email.Length; j++)
        {
            if (email[j] == buscarPunto)
            {
                punto++;
                posicionDelPunto = j;
            }
        }
        for (int k = posicionDelPunto; k < email.Length; k++)
        {
            carateresDespuesDelPunto++;
        }
        for (int m = 0; m < email.Length; m++)
        {
            if (email[m] == buscarVacio)
            {
                espacioVacio++;
            }
        }

        if (arrobas == 1 && punto == 1 && carateresDespuesDelPunto > 2 && email.Length > 3 && posicionDeArroba < posicionDelPunto && posicionDelPunto - posicionDeArroba > 1 && espacioVacio == 0)
        {
            valido = true;
        }
        return valido;
    }

    /*public static bool validarContrasenia(string contrasenia)
    {
        bool valido = false;
        int contadorMayuscula = 0;
        int contadorCaracterEspecial = 0;

        if (contrasenia.Length > 7)
        {
            for (int i = 0; i < contrasenia.Length; i++)
            {
                if (Char.IsUpper(contrasenia[i]))
                {
                    contadorMayuscula++;
                }
                if (contrasenia[i] == '!' || contrasenia[i] == '.' || contrasenia[i] == ',' || contrasenia[i] == ';')
                {
                    contadorCaracterEspecial++;
                }
            }
        }
        if (contadorCaracterEspecial > 0 && contadorMayuscula > 0)
        {
            valido = true;
        }
        return valido;
    }

    private static bool ValidarNombre(string nombre)
    {
        bool valido = false;
        int espacio = 0;



        Char buscarEspacio = ' ';

        for (int k = 0; k < nombre.Length; k++)
        {
            if (nombre[k] == buscarEspacio)
            {
                if (k != 0 && k != nombre.Length)
                    espacio++;
            }

        }
        if (nombre.Length > 2 && espacio <= 1)
        {
            valido = true;
        }
        return valido;
    }

    private static string PedirTexto(string texto)
    {
        string ingreso = "";
        bool pude = false;
        do
        {
            Console.WriteLine(texto);
            ingreso = Console.ReadLine();
            if (ingreso != "")
            {
                pude = true;
            }
        }
        while (!pude);
        return ingreso;
    }

    private static int PedirNumero(string texto)
    {
        int num;
        bool pude = false;
        Console.WriteLine(texto);
        do
        {
            pude = int.TryParse(Console.ReadLine(), out num);
            if (!pude)
            {
                Console.WriteLine("Ingreso incorrecto.");
                Console.WriteLine(texto);
            }
        }
        while (!pude);
        return num;
    }

    private static void mostrarUsuarios(Eventos2017 unEvento)
    {
        foreach (Usuario unUsuario in unEvento.Usuarios())
        {
            Console.WriteLine("\n" + unUsuario);
        }
    }

    private static void mostrarServicios(Eventos2017 unEvento)
    {
        foreach (Servicios unServicio in unEvento.Servicios())
        {
            Console.WriteLine("\n" + unServicio);
        }
    }

    private static void mostrarEvento(Evento unoEvento)
    {
        Console.WriteLine("\n" + unoEvento);
    }

    private static DateTime pedirFecha(string texto)
    {
        DateTime fecha;
        bool pude = false;
        Console.WriteLine(texto);
        do
        {
            pude = DateTime.TryParse(Console.ReadLine(), out fecha);
            if (!pude)
            {
                Console.WriteLine("Ingreso incorrecto.");
                Console.WriteLine(texto);
            }
        }
        while (!pude);
        return fecha;
    }

    private static void MostrarEventos(Eventos2017 unEvento, OrganizadorEventos organizador)
    {
        double sumaDeTotales = 0;
        foreach (Evento unoEvento in unEvento.DevolverEventosDeOrganizador(organizador))
        {
            Console.WriteLine("\n" + unoEvento);
            sumaDeTotales = unoEvento.Totales;
        }
        Console.WriteLine("Total Eventos: " + sumaDeTotales);
    }

}
}*/
