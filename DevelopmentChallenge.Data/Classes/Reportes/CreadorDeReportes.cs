using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Reportes
{
    public class CreadorDeReportes
    {
        private readonly IReporte _idiomaDeReporte;
        public CreadorDeReportes(IReporte idiomaDeReporte)
        {
            _idiomaDeReporte = idiomaDeReporte;
        }

        public string Imprimir(List<IFormaGeometrica> formas)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(_idiomaDeReporte.ListaVacia());
            }
            else
            {
                sb.Append(_idiomaDeReporte.ObtenerTitulo());

                var totales = new List<FormaTotales>();

                foreach(var forma in formas)
                {
                    if(!totales.Any(f => f.NombreForma == forma.ObtenerNombre())){
                        totales.Add(new FormaTotales()
                        {
                            NombreForma = forma.ObtenerNombre(),
                            Cantidad = 1,
                            AreaTotal = forma.CalcularArea(),
                            PerimetroTotal = forma.CalcularPerimetro()
                        });
                    }
                    else
                    {
                        var item = totales.First(f => f.NombreForma == forma.ObtenerNombre());
                        item.Cantidad += 1;
                        item.AreaTotal += forma.CalcularArea();
                        item.PerimetroTotal += forma.CalcularPerimetro();
                    }
                }

                foreach(var total in totales)
                {
                    sb.Append(_idiomaDeReporte.ObtenerLinea(total.NombreForma, total.Cantidad, total.AreaTotal, total.PerimetroTotal));
                }

                sb.Append(_idiomaDeReporte.ObtenerTotal(totales.Sum(t => t.Cantidad), totales.Sum(t => t.PerimetroTotal), totales.Sum(t => t.AreaTotal)));
            }

            return sb.ToString();
        }
    }
}
