using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class SeguroDeVida : ITributavel
    {
        public double CalculaTributos()
        {
            Console.WriteLine("Valor do tributo do seguro de vida: 75.0");
            return 75.0;
        }
    }
}