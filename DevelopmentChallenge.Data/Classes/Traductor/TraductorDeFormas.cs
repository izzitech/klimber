using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Traductor
{
    internal class TraductorDeFormas
    {
        private readonly IDiccionario _diccionario;


        public TraductorDeFormas(IDiccionario diccionario)
        {
            _diccionario = diccionario;
        }

        public string TraducirForma(string nombreForma, int cantidad)
        {
            return _diccionario.TraducirForma(nombreForma, cantidad);
        }
    }
}
