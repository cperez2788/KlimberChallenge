using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Formas;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Idiomas
{
    public class Castellano : IIdioma
    {
        private Dictionary<Type, Traduccion> _traducciones;
        public string EmptyList => "Lista vacía de formas!";
        public string Header => "Reporte de Formas";
        public string Footer => "TOTAL:";
        public string Type => "formas";
        public string Perimeter => "Perimetro";
        public string Area => "Area";

        public Castellano()
        {
            _traducciones = new Dictionary<Type, Traduccion>
            {
                { typeof(Cuadrado), new Traduccion("Cuadrado", "Cuadrados") },
                { typeof(Circulo), new Traduccion("Círculo", "Círculos") },
                { typeof(TrianguloEquilatero), new Traduccion("Triángulo", "Triángulos") },
                { typeof(Trapecio), new Traduccion("Trapecio", "Trapecios") },
                { typeof(Octagono), new Traduccion("Octágono", "Octágonos") },
                { typeof(Rectangulo), new Traduccion("Rectangulo", "Rectangulos") }
            };
        }

        public string TraducirNombreForma(FormaGeometrica forma, bool isSingular)
        {
            if (_traducciones.TryGetValue(forma.GetType(), out var traduccion))
            {
                return (isSingular ? traduccion.Singular : traduccion.Plural);
                                                                   
            }

            return (isSingular ? "Desconocido" : "Desconocidos");
        }
    }
}
