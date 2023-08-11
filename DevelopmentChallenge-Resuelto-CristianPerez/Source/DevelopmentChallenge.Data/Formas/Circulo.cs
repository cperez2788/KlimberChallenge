using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Formas
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _diametro;

        public Circulo(decimal diametro)
        {
            _diametro = diametro;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2); ;
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }
    }
}
