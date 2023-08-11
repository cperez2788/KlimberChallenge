using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Traduccion
    {
        public string Singular { get; set; }
        public string Plural { get; set; }

        public Traduccion(string singular, string plural)
        {
            Singular = singular;
            Plural = plural;
        }
    }
}
