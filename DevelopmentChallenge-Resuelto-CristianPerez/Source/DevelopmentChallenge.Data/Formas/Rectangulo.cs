using DevelopmentChallenge.Data.Classes;

namespace DevelopmentChallenge.Data.Formas
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal _base;
        private readonly decimal _altura;

        public Rectangulo(decimal @base, decimal altura)
        {
            _base = @base;
            _altura = altura;
        }

        public override decimal CalcularArea()
        {
            return _base * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (_base + _altura);
        }
    }
}
