using DevelopmentChallenge.Data.Idiomas;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Reporte
    {
        public string Imprimir(List<FormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{idioma.EmptyList}</h1>");
            }
            else
            {
                sb.Append($"<h1>{idioma.Header}</h1>");

                var formasAgrupadasPorTipo = formas.GroupBy(forma => forma.GetType());
                decimal totalPerimetros = 0;
                decimal totalAreas = 0;

                foreach (var grupo in formasAgrupadasPorTipo)
                {
                    int cantidad = grupo.Count();
                    decimal areaTotal = grupo.Sum(forma => forma.CalcularArea());
                    decimal perimetroTotal = grupo.Sum(forma => forma.CalcularPerimetro());
                    string nombreForma = idioma.TraducirNombreForma(grupo.First(), cantidad == 1);

                    totalPerimetros += perimetroTotal;
                    totalAreas += areaTotal;

                    sb.Append($"{cantidad} {nombreForma} | {idioma.Area} {areaTotal:#.##} | {idioma.Perimeter} {perimetroTotal:#.##} <br/>");
                }

                sb.Append($"{idioma.Footer}<br/>");
                sb.Append($"{formas.Count} {idioma.Type} ");
                sb.Append($"{idioma.Perimeter} {totalPerimetros:#.##} " );
                sb.Append($"{idioma.Area} {totalAreas:#.##}" );
            }

            return sb.ToString();
        }
    }
}
