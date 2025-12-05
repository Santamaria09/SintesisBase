using SintesisBase.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaNegocio
{
    internal class ReporteComprasBLL
    {
        private ReporteCompraDAL dal = new ReporteCompraDAL();

        public DataTable ObtenerReporteCompras(DateTime inicio, DateTime fin)
        {
            if (inicio > fin)
                throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha fin.");

            return dal.ReporteCompras(inicio, fin);
        }

        public static DataTable ObtenerComprasPorPeriodo(DateTime inicio, DateTime fin)
        {
            return ReporteCompraDAL.ObtenerComprasPorPeriodo(inicio, fin);
        }
    }
}

