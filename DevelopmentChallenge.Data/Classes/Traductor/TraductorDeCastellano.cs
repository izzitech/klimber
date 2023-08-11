using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Traductor
{
    internal class TraductorDeCastellano : IDiccionario
    {
        Dictionary<string, string> diccionarioSingular = new Dictionary<string, string>
            {
                { "triangulo equilatero", "Triángulo" },
                { "cuadrado", "Cuadrado" },
                { "circulo", "Círculo" },
                { "rectangulo", "Rectángulo" }
            };

        Dictionary<string, string> diccionarioPlural = new Dictionary<string, string>
            {
                { "triangulo equilatero", "Triángulos" },
                { "cuadrado", "Cuadrados" },
                { "circulo", "Círculos" },
                { "rectangulo", "Rectángulos" }
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
