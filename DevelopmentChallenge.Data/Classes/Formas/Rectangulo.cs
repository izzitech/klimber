using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Rectangulo : IFormaGeometrica
    {
        private readonly decimal _base;
        private readonly decimal _altura;

        public Rectangulo(decimal baseDelRectangulo, decimal altura)
        {
            _base = baseDelRectangulo;
            _altura = altura;
        }

        public decimal CalcularArea()
        {
            return _base * _altura;
        }

        public decimal CalcularPerimetro()
        {
            return (_base * 2) + (_altura * 2);
        }

        public string ObtenerNombre()
        {
            return "rectangulo";
        }
    }
}
