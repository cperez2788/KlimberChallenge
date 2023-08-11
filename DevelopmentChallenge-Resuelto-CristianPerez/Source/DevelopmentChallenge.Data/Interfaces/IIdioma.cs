using DevelopmentChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IIdioma
    {
        string EmptyList { get; }
        string Header { get; }
        string Footer { get; }
        string Type { get; }
        string Perimeter { get; }
        string Area { get; }

        string TraducirNombreForma(FormaGeometrica forma, bool IsSingular);
    }
}
