using DevelopmentChallenge.Data.Classes.Traductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Reportes
{
    public class ReporteEnAleman : IReporte
    {
        public string ListaVacia()
        {
            return "<h1>Leere Formenliste!</h1>";
        }

        public string ObtenerTitulo()
        {
            return "<h1>Formularbericht</h1>";
        }

        public string ObtenerLinea(string nombreForma, int cantidad, decimal area, decimal perimetro)
        {
            var traductor = new TraductorDeFormas(new TraductorDeAleman());
            return $"{cantidad} {traductor.TraducirForma(nombreForma, cantidad)} | Bereich {area:#.##} | Umfang {perimetro:#.##} <br/>";
        }

        public string ObtenerTotal(int totalFormas, decimal totalPerimetro, decimal totalArea)
        {
            var sb = new StringBuilder();
            sb.Append("GESAMT:<br/>");
            sb.Append($"{totalFormas} formen ");
            sb.Append($"Umfang {totalPerimetro.ToString("#.##")} ");
            sb.Append($"Bereich {totalArea.ToString("#.##")}");
            return sb.ToString();
        }
    }
}
