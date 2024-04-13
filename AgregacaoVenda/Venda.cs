using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        private Comprador comprador;
        private Vendedor vendedor;
        private List<Produto> vetProd;

        public Venda(Comprador comprador, Vendedor vendedor)
        {
            this.comprador = comprador;
            this.vendedor = vendedor;
            this.vetProd = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            if (produto.Preco <= 0)
            {
                Console.WriteLine("* Alguns produtos não foram adicionados, pois o preço deve ser maior que zero.");
                return;
            }

            vetProd.Add(produto);
        }

        public void FinalizarVenda()
        {
            double precoTotal = 0;

            foreach (Produto p in vetProd)
            {
                precoTotal += p.Preco;
            }

            Console.WriteLine($"Preço total: {precoTotal:c}");

            if (precoTotal > comprador.Verba)
            {
                Console.WriteLine("O comprador não tem dinheiro suficiente para finalizar a compra.");
                return;
            }

            comprador.Verba -= precoTotal;
            vendedor.CalcularComissao(precoTotal);
            vendedor.MostrarAtributo();
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("\nProdutos selecionados:");
            foreach (Produto produto in vetProd)
            {
                produto.MostrarAtributos();
            }
        }
    }
}
