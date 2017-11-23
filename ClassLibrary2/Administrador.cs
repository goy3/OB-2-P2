using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// constructor de administrador
    /// </summary>
    public class Administrador : Usuario
    {
        public Administrador(string email, string contrasenia) : base(email, contrasenia, Usuario.Rol.ADMINISTRADOR)
        {
            
        }
        
    }
    
}
