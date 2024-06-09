using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Cheque : Pagamento
    {
        public long Numero { get; set; }
        public DateTime DataDeposito { get; set; }
        public int Situacao { get; set; }

        public Cheque(double total, long numero, DateTime dataDeposito, int situacao) : base(total)
        {
            Numero = numero;
            DataDeposito = dataDeposito;
            Situacao = situacao;
        }
    }
}