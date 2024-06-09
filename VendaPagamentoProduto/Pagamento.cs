using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Pagamento
    {
        public DateTime Data { get; set; }
        public double Total { get; set; }

        public Pagamento(double total)
        {
            Data = DateTime.Now;
            Total = total;
        }
    }
}