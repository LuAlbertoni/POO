using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class ItemVenda
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Subtotal { get; set; }
        public Produto Produto { get; set; }

        public ItemVenda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = produto.Preco;
            Subtotal = Preco * Quantidade;
        }
    }
}