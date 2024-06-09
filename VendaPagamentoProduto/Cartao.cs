using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Cartao : Pagamento
    {
        public string DadosTransacao { get; set; }
        public int ResultadoTransacao { get; set; }

        public Cartao(double total, string dadosTransacao, int resultadoTransacao) : base(total)
        {
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }
    }
}