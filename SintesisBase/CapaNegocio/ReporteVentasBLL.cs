using SintesisBase.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaNegocio
{
    public class ReporteVentasBLL
    {
        private ReporteVentaDAL dal = new ReporteVentaDAL();

        public DataTable ObtenerReporteVentas(DateTime inicio, DateTime fin)
        {
            if (inicio > fin)
                throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha fin.");

            return dal.ReporteVentas(inicio, fin);
        }

        public static DataTable ObtenerVentasPorPeriodo(DateTime inicio, DateTime fin)
        {
            return ReporteVentaDAL.ObtenerVentasPorPeriodo(inicio, fin);
        }
    }
}
