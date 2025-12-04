using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaEntidades
{
    public class Inventario
    {
        public int Id { get; set; }
        public string Stock { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Id_Producto { get; set; }
    }
}
