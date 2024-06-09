using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Venda
    {
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();
        public static List<Venda> Vendas { get; set; } = new List<Venda>();

        public void AdicionarItem(ItemVenda item)
        {
            Itens.Add(item);
            Total += item.Subtotal;
        }

        public static void RealizarVenda(List<Produto> produtos, List<Venda> vendas)
        {
            Venda venda = new Venda { Data = DateTime.Now };

            while (true)
            {
                Console.WriteLine("\n---------- VENDA ---------\n1 - Adicionar Item\n2 - Finalizar Venda\n-------------------------");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("\nNenhum produto cadastrado!");
                        return;
                    }

                    Console.Write("\nCódigo do Produto: ");
                    long codigo = Convert.ToInt64(Console.ReadLine());

                    Produto produto = null;

                    for (int i = 0; i < produtos.Count; i++)
                    {
                        if (produtos[i].Codigo == codigo)
                        {
                            produto = produtos[i];
                            break;
                        }
                    }

                    if (produto == null)
                    {
                        Console.WriteLine("\nProduto não encontrado!");
                        return;
                    }

                    Console.Write("Quantidade: ");
                    int quantidade = Convert.ToInt32(Console.ReadLine());

                    if (quantidade > produto.Estoque)
                    {
                        Console.WriteLine("\nEstoque insuficiente!");
                        return;
                    }

                    ItemVenda itemVenda = new ItemVenda(produto, quantidade);
                    venda.AdicionarItem(itemVenda);
                    produto.Estoque -= quantidade;

                    Console.WriteLine("\nItem adicionado com sucesso!");
                }
                else if (opcao == 2)
                {
                    int totalItens = 0;

                    Console.WriteLine("\n---------- RESUMO ---------");
                    foreach (ItemVenda item in venda.Itens)
                    {
                        Console.WriteLine($"{item.Produto.Nome} - {item.Quantidade} x R$ {item.Preco} = R$ {item.Subtotal}");
                        totalItens += item.Quantidade;
                    }

                    if (venda.Itens.Count == 0)
                    {
                        Console.WriteLine("\nNenhum item adicionado!");
                        return;
                    }
                    
                    if (totalItens >= 50)
                    {
                        Console.WriteLine("\nA compra ultrapassou o limite de 50 itens, desconto de 20% aplicado!");
                        venda.Total *= 0.8;
                    }

                    Console.WriteLine($"Total R$ {venda.Total}");

                    ProcessarPagamento(venda);
                    vendas.Add(venda);

                    break;
                }
            }
        }

        public static void ProcessarPagamento(Venda venda)
        {
            Console.WriteLine("\n---------- PAGAMENTO ---------\n1 - Espécie\n2 - Cheque\n3 - Cartão\n-------------------------------");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    double quantia = 0;

                    while (quantia < venda.Total)
                    {
                        Console.Write("Quantia recebida: ");
                        quantia = Convert.ToDouble(Console.ReadLine());

                        if (quantia < venda.Total)
                        {
                            Console.WriteLine("Quantia insuficiente!");
                        }
                    }

                    Especie especie = new Especie(venda.Total, quantia);
                    Console.WriteLine($"Troco: {especie.Troco}");
                    break;
                case 2:
                    Console.Write("Número do cheque: ");
                    long numero = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Data de depósito: ");
                    DateTime dataDeposito = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Situação: ");
                    int situacao = Convert.ToInt32(Console.ReadLine());
                    Cheque cheque = new Cheque(venda.Total, numero, dataDeposito, situacao);
                    break;
                case 3:
                    Console.Write("Dados da transação: ");
                    string? dadosTransacao = Console.ReadLine();
                    Console.Write("Resultado da transação (1 para sucesso, 0 para falha): ");
                    int resultadoTransacao = Convert.ToInt32(Console.ReadLine());
                    Cartao cartao = new Cartao(venda.Total, dadosTransacao, resultadoTransacao);
                    break;
            }
        }
    }
}