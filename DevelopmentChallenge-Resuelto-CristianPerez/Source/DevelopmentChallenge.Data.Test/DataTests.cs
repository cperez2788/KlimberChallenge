using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Formas;
using DevelopmentChallenge.Data.Idiomas;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Test
{
    [TestFixture]
    public class DataTests
    {
        private Reporte _reporte;

        [SetUp]
        public void Setup()
        {
            _reporte = new Reporte();
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                _reporte.Imprimir(new List<FormaGeometrica>(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                _reporte.Imprimir(new List<FormaGeometrica>(), new Ingles()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = _reporte.Imprimir(cuadrados, new Castellano());
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = _reporte.Imprimir(cuadrados, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = _reporte.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = _reporte.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaVaciaEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di moduli!</h1>",
                _reporte.Imprimir(new List<FormaGeometrica>(), new Italiano()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnItaliano()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = _reporte.Imprimir(cuadrados, new Italiano());
            Assert.AreEqual("<h1>Rapporto sui moduli</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTALE:<br/>1 moduli Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConOctagonosIngles()
        {
            var octagonos = new List<FormaGeometrica>
            {
                new Octagono(5),
                new Octagono(1),
                new Octagono(3)
            };

            var resumen = _reporte.Imprimir(octagonos, new Ingles());
            Assert.AreEqual("<h1>Shapes report</h1>3 Octagons | Area 168,99 | Perimeter 72 <br/>TOTAL:<br/>3 shapes Perimeter 72 Area 168,99", resumen);
        }

        [TestCase]
        public void TestResumenListaConOctagonosItaliano()
        {
            var octagonos = new List<FormaGeometrica>
            {
                new Octagono(5),
                new Octagono(1),
                new Octagono(3)
            };

            var resumen = _reporte.Imprimir(octagonos, new Italiano());
            Assert.AreEqual("<h1>Rapporto sui moduli</h1>3 Ottagoni | Area 168,99 | Perimetro 72 <br/>TOTALE:<br/>3 moduli Perimetro 72 Area 168,99", resumen);
        }

        [TestCase]
        public void TestResumenListaConOctagonosYTrapeciosCastellano()
        {
            var lista = new List<FormaGeometrica>
            {
                new Octagono(1),
                new Trapecio(4,3,2,3,3),
                new Octagono(2),
                new Trapecio(3,2,2,3,2)
            };

            var resumen = _reporte.Imprimir(lista, new Castellano());
            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Octágonos | Area 24,14 | Perimetro 24 <br/>2 Trapecios | Area 12 | Perimetro 23 <br/>TOTAL:<br/>4 formas Perimetro 47 Area 36,14", resumen);
        }

        [TestCase]
        public void TestResumenListaConRectangulos()
        {
            var rectangulos = new List<FormaGeometrica>
            {
                new Rectangulo(3,4),
                new Rectangulo(5,4),
                new Rectangulo(8,3),
                new Rectangulo(2,5),
            };

            var resumen = _reporte.Imprimir(rectangulos, new Ingles());
            Assert.AreEqual("<h1>Shapes report</h1>4 Rectangles | Area 66 | Perimeter 68 <br/>TOTAL:<br/>4 shapes Perimeter 68 Area 66", resumen);
        }
    }
}