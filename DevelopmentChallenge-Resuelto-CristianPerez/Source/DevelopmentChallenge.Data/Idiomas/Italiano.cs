using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Formas;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Idiomas
{
    public class Italiano : IIdioma
    {
        public string EmptyList => "Elenco vuoto di moduli!";
        public string Header => "Rapporto sui moduli";
        public string Footer => "TOTALE:";
        public string Type => "moduli";
        public string Perimeter => "Perimetro";
        public string Area => "Area";

        private Dictionary<Type, Traduccion> _traducciones;

        public Italiano()
        {
            _traducciones = new Dictionary<Type, Traduccion>
            {
                { typeof(Cuadrado), new Traduccion("Quadrato", "Quadrati") },
                { typeof(Circulo), new Traduccion("Cerchio", "Cerchi") },
                { typeof(TrianguloEquilatero), new Traduccion("Triangolo", "Triangoli") },
                { typeof(Trapecio), new Traduccion("Trapezio", "Trapezi") },
                { typeof(Octagono), new Traduccion("Ottagono", "Ottagoni") },
                { typeof(Rectangulo), new Traduccion("Rettangolo", "Rettangoli") }
            };
        }

        public string TraducirNombreForma(FormaGeometrica forma, bool isSingular)
        {
            if (_traducciones.TryGetValue(forma.GetType(), out var traduccion))
            {
                return (isSingular ? traduccion.Singular : traduccion.Plural);
            }

            return (isSingular ? "Sconosciuto" : "Sconosciuto");
        }
    }
}
