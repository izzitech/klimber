using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Reportes
{
    public interface IReporte
    {
        string ListaVacia();

        string ObtenerTitulo();

        string ObtenerLinea(string nombreForma, int cantidad, decimal area, decimal perimetro);

        string ObtenerTotal(int totalFormas, decimal totalPerimetro, decimal totalArea);
    }
}
