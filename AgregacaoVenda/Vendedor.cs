using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        private const double comissao = 2;
        private double comissaoRecebida;

        public void MostrarAtributo()
        {
            Console.WriteLine($"Comissão do vendedor: {comissaoRecebida:c}");
        }

        public void CalcularComissao(double precoTotal)
        {
            comissaoRecebida = precoTotal * (comissao / 100);
        }
    }
}
