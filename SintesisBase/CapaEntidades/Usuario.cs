using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaEntidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public string ClaveHash { get; set; }
        public bool Estado { get; set; }
        public int Id_Rol {  get; set; }
        

    }
}
