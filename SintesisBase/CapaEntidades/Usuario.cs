using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaEntidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ClaveHash { get; set; }
        public string Rol { get; set; }
        public bool Estado { get; set; }

        //método para cuando cerremos sesión, borra los datos guardados.
        public void Cerrar()
        {
            this.IdUsuario = 0;
            this.NombreUsuario = null;
            this.Rol = null;
            this.ClaveHash = null;
            this.Estado = false;
        }
    }
}
