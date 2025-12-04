using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaEntidades
{
    public class Compra
    {
        public int Id { get; set; }
        public decimal TotalCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Proveedor { get; set; }
        public int Id_Usuario { get; set; }

    }
}
