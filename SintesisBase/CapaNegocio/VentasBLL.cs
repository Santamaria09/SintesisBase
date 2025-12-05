using SintesisBase.CapaDatos;
using SintesisBase.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaNegocio
{
    public class VentasBLL
    {
        public static Transacciones ValidarVenta(Venta venta, List<VentaItem> detalles)
        {
            //Validar existencia
            if (venta == null)
                return new Transacciones { Exito = false, Mensaje = "Venta no valida" };

            //Cliente
            if (venta.Id_Cliente <= 0)
                return new Transacciones { Exito = false, Mensaje = "Debe de seleccionar un cliente" };

            //validar detalles
            if (detalles == null || detalles.Count == 0)
            {
                return new Transacciones
                { Exito = false, Mensaje = "La venta debe de obtener al menos un producto" };
            }

            //Montos
            if (venta.Total <= 0)
                return new Transacciones { Exito = false, Mensaje = "El total de la venda debe de ser mayor a cero" };

            //Cada detalle
            foreach (var d in detalles)
            {
                //Cantidad
                if (d.Cantidad <= 0)
                    return new Transacciones { Exito = false, Mensaje = $"La cantidad del Producto ID{d.Id_Producto} es invalida" };
                //Precio
                if (d.PrecioUnitario <= 0)
                    return new Transacciones{ Exito = false, Mensaje = $"El precio unitario invalido para el Producto ID{d.Id_Producto}" };


                //Subtotal
                if (d.SubTotal != d.Cantidad * d.PrecioUnitario)
                    return new Transacciones { Exito = false, Mensaje = $"SubTotal incorrecto para el produto ID{d.Id_Producto}" };

                //Validar stock
                int StockActual = ProductoDAL.ObtenerStock(d.Id_Producto);
                if (StockActual < d.Cantidad)
                {
                    return new Transacciones{ Exito = false, Mensaje = $"Stock insuficiente del Producto ID{d.Id_Producto}(Stock Actual:{StockActual})" };

                }



            }
            return new Transacciones
            { Exito = true, Mensaje = "Validacion correcta" };
        }

      
    
    }
}
