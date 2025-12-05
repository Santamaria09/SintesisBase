using SintesisBase.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaNegocio
{
    public class RolBLL
    {
        public static List<string> ListarRol()
        {
            return RolDAL.ListarRol();
        }
    }
}
