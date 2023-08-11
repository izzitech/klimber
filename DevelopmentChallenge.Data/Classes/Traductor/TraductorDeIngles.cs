using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Traductor
{
    internal class TraductorDeIngles : IDiccionario
    {
        Dictionary<string, string> diccionarioSingular = new Dictionary<string, string>
            {
                { "triangulo equilatero", "Triangle" },
                { "cuadrado", "Square" },
                { "circulo", "Circle" },
                { "rectangulo", "Rectangle" }
            };

        Dictionary<string, string> diccionarioPlural = new Dictionary<string, string>
            {
                { "triangulo equilatero", "Triangles" },
                { "cuadrado", "Squares" },
                { "circulo", "Circles" },
                { "rectangulo", "Rectangles" }
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
