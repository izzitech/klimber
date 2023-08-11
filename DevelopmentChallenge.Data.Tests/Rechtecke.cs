using System;
using System.Collections.Generic;
using NUnit.Framework;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Reportes;
using DevelopmentChallenge.Data.Classes.Formas;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var reporte = new CreadorDeReportes(new ReporteEnCastellano());

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                reporte.Imprimir(new List<IFormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var reporte = new CreadorDeReportes(new ReporteEnIngles());

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                reporte.Imprimir(new List<IFormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var figuras = new List<IFormaGeometrica>()
            {
                new Cuadrado(5)
            };

            var reporte = new CreadorDeReportes(new ReporteEnCastellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25",
                reporte.Imprimir(figuras));
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var figuras = new List<IFormaGeometrica>()
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var reporte = new CreadorDeReportes(new ReporteEnIngles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", 
                reporte.Imprimir(figuras));
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var figuras = new List<IFormaGeometrica>()
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var reporte = new CreadorDeReportes(new ReporteEnIngles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                reporte.Imprimir(figuras));
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var figuras = new List<IFormaGeometrica>()
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var reporte = new CreadorDeReportes(new ReporteEnCastellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                reporte.Imprimir(figuras));
        }

        [TestCase]
        public void TestCalcularPerimetroDeUnRectangulo()
        {
            var rectangulo = new Rectangulo(10, 5);

            Assert.AreEqual(30m, rectangulo.CalcularPerimetro());
        }

        [TestCase]
        public void TestCalcularAreaDeUnRectangulo()
        {
            var rectangulo = new Rectangulo(10, 5);

            Assert.AreEqual(50m, rectangulo.CalcularArea());
        }

        [TestCase]
        public void TestReporteEnAlemanDeVariosRectangulos()
        {
            var figuras = new List<IFormaGeometrica>()
            {
                new Rectangulo(10, 5),
                new Rectangulo(20,10)
            };

            var reporte = new CreadorDeReportes(new ReporteEnAleman());

            Assert.AreEqual(
                "<h1>Formularbericht</h1>2 Rechtecke | Bereich 250 | Umfang 90 <br/>GESAMT:<br/>2 formen Umfang 90 Bereich 250",
                reporte.Imprimir(figuras));
        }
    }
}
