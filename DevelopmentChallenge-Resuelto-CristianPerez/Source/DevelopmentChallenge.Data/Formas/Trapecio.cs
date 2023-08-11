using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Formas
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;
        private readonly decimal _ladoA;
        private readonly decimal _ladoB;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoA, decimal ladoB)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _ladoA = ladoA;
            _ladoB = ladoB;
        }

        public override decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) * _altura) / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + _ladoA + _ladoB;
        }
    }
}
