using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Traductor
{
    internal interface IDiccionario
    {
        string TraducirForma(string nombreForma, int cantidad);
    }
}
