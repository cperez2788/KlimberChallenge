using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Formas
{
    public class Octagono : FormaGeometrica
    {
        private readonly decimal _lado;

        public Octagono(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return 2 * (1 + (decimal)Math.Sqrt(2)) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return 8 * _lado;
        }
    }
}
