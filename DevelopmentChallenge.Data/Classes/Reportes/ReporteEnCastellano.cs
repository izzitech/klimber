using DevelopmentChallenge.Data.Classes.Traductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Reportes
{
    public class ReporteEnCastellano : IReporte
    {
        public string ListaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public string ObtenerTitulo()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public string ObtenerLinea(string nombreForma, int cantidad, decimal area, decimal perimetro)
        {
            var traductor = new TraductorDeFormas(new TraductorDeCastellano());
            return $"{cantidad} {traductor.TraducirForma(nombreForma, cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
        }

        public string ObtenerTotal(int totalFormas, decimal totalPerimetro, decimal totalArea)
        {
            var sb = new StringBuilder();
            sb.Append("TOTAL:<br/>");
            sb.Append($"{totalFormas} formas ");
            sb.Append($"Perimetro {totalPerimetro.ToString("#.##")} ");
            sb.Append($"Area {totalArea.ToString("#.##")}");
            return sb.ToString();
        }
    }
}
