using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Formas;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Idiomas
{
    public class Ingles : IIdioma
    {
        public string EmptyList => "Empty list of shapes!";
        public string Header => "Shapes report";
        public string Footer => "TOTAL:";
        public string Type => "shapes";
        public string Perimeter => "Perimeter";
        public string Area => "Area";

        private Dictionary<Type, Traduccion> _traducciones;

        public Ingles()
        {
            _traducciones = new Dictionary<Type, Traduccion>
            {
                { typeof(Cuadrado), new Traduccion("Square", "Squares") },
                { typeof(Circulo), new Traduccion("Circle", "Circles") },
                { typeof(TrianguloEquilatero), new Traduccion("Triangle", "Triangles") },
                { typeof(Trapecio), new Traduccion("Trapeze", "Trapezoids") },
                { typeof(Octagono), new Traduccion("Octagon", "Octagons") },
                { typeof(Rectangulo), new Traduccion("Rectangle", "Rectangles") }
            };
        }

        public string TraducirNombreForma(FormaGeometrica forma, bool isSingular)
        {
            if (_traducciones.TryGetValue(forma.GetType(), out var traduccion))
            {
                return (isSingular ? traduccion.Singular : traduccion.Plural);
            }

            return (isSingular ? "Unknown" : "Unknowns");
        }
    }
}
