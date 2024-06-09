using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Especie : Pagamento
    {
        public double Quantia { get; set; }
        public double Troco { get; set; }

        public Especie(double total, double quantia) : base(total)
        {
            Quantia = quantia;
            Troco = quantia - total;
        }
    }
}