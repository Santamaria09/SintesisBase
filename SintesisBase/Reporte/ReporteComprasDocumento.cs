using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;        // Extensiones para Page(), Table(), Text(), etc.
using QuestPDF.Helpers;       // Acceso a colores, tamaños y herramientas
using QuestPDF.Infrastructure;// IDocument, IContainer, DocumentMetadata, etc.
using System.Data;


namespace SintesisBase.Reporte
{
    namespace Prueba_XYZ.Reportes
    {
        public class ReporteComprasDocumento : IDocument
        {

            // Modelo donde vienen los datos del reporte de compras
            private readonly ReporteComprasModel Modelo;

            public ReporteComprasDocumento(ReporteComprasModel modelo)
            {
                Modelo = modelo;
            }

            public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

            public DocumentSettings GetSettings() => new DocumentSettings();

            public void Compose(IDocumentContainer container)
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(30);

                    // ENCABEZADO
                    page.Header().Column(col =>
                    {
                        col.Item().Text("TIENDA EMANUEL")
                            .Bold().FontSize(20);

                        col.Item().Text("Reporte de Compras por Período")
                            .FontSize(14);

                        col.Item().Text($"Desde {Modelo.Inicio:dd/MM/yyyy} — Hasta {Modelo.Fin:dd/MM/yyyy}")
                            .FontSize(11);
                    });

                    // TABLA PRINCIPAL
                    page.Content().PaddingTop(20)
                        .Element(GenerarTablaCompras);

                    // PIE DE PÁGINA
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Generado el ").SemiBold();
                        txt.Span(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                        txt.Line(" — SintesisBase");
                    });
                });
            }

            private void GenerarTablaCompras(IContainer container)
            {
                container.Table(table =>
                {
                    // COLUMNAS
                    table.ColumnsDefinition(cols =>
                    {
                        cols.RelativeColumn(3); // Producto
                        cols.RelativeColumn(2); // Proveedor
                        cols.RelativeColumn(1); // Cantidad
                        cols.RelativeColumn(1); // Costo Unidad
                        cols.RelativeColumn(1); // Subtotal
                    });

                    // ENCABEZADOS
                    table.Header(header =>
                    {
                        header.Cell().Background(Colors.Grey.Lighten3).Padding(5).Text("Producto").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Padding(5).Text("Proveedor").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Padding(5).Text("Cantidad").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Padding(5).Text("Costo").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Padding(5).Text("Subtotal").SemiBold();
                    });

                    decimal totalGeneral = 0;

                    // FILAS
                    foreach (DataRow row in Modelo.Tabla.Rows)
                    {
                        // VALIDACIÓN DE NOMBRES DE COLUMNAS
                        string producto = row["Producto"].ToString();
                        string proveedor = row["Proveedor"].ToString();

                        // EN COMPRAS EL CAMPO ES **PrecioCompra**
                        int cantidad = Convert.ToInt32(row["Cantidad"]);
                        decimal costo = Convert.ToDecimal(row["PrecioCompra"]);

                        // Subtotal debe calcularse
                        decimal subtotal = cantidad * costo;

                        totalGeneral += subtotal;

                        table.Cell().Padding(4).Text(producto);
                        table.Cell().Padding(4).Text(proveedor);
                        table.Cell().Padding(4).Text(cantidad.ToString());
                        table.Cell().Padding(4).Text(costo.ToString("C2"));
                        table.Cell().Padding(4).Text(subtotal.ToString("C2"));
                    }

                    // TOTAL GENERAL (fila completa)
                    table.Footer(footer =>
                    {
                        footer.Cell().ColumnSpan(5).AlignRight().PaddingTop(10)
                            .Text($"TOTAL GENERAL DE COMPRAS: {totalGeneral:C2}")
                            .Bold().FontSize(14);
                    });
                });
            }
        }

    }
}


