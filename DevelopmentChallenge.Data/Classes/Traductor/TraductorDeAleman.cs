using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Traductor
{
    internal class TraductorDeAleman : IDiccionario
    {
        Dictionary<string, string> diccionarioSingular = new Dictionary<string, string>
            {
                { "triangulo equilatero", "Dreiek" },
                { "cuadrado", "Quadrat" },
                { "circulo", "Kreis" },
                { "rectangulo", "Rechteck" }
            };

        Dictionary<string, string> diccionarioPlural = new Dictionary<string, string>
            {
                { "triangulo equilatero", "Dreiecke" },
                { "cuadrado", "Quadrate" },
                { "circulo", "Kreise" },
                { "rectangulo", "Rechtecke" }
            };

        public string TraducirForma(string nombreForma, int cantidad)
        {
            if (cantidad <= 1)
            {
                if (diccionarioSingular.ContainsKey(nombreForma))
                {
                    return diccionarioSingular[nombreForma];
                }
                else
                {
                    return nombreForma;
                }
            }
            else
            {
                if (diccionarioPlural.ContainsKey(nombreForma))
                {
                    return diccionarioPlural[nombreForma];
                }
                else
                {
                    return nombreForma;
                }
            }
        }
    }
}
