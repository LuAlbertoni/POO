using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Produto
    {
        public long Codigo { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public static List<Produto> produtos = new List<Produto>();

        public static void CadastrarProduto()
        {
            Console.WriteLine("\n------- CADASTRO -------");
            Console.Write("Código: ");
            long codigo = Convert.ToInt64(Console.ReadLine());

            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].Codigo == codigo)
                {
                    Console.Write($"\nCódigo já cadastrado! Deseja adicionar mais estoque ao produto '{produtos[i].Nome}'? (s/n) ");
                    string? opcao = Console.ReadLine();

                    if (opcao == "s")
                    {
                        Console.Write("Estoque: ");
                        int quant = Convert.ToInt32(Console.ReadLine());
                        produtos[i].Estoque += quant;
                        Console.WriteLine("\nEstoque atualizado com sucesso!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nCadastro cancelado!");
                        return;
                    }
                }
            }

            Console.Write("Nome: ");
            string? nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Estoque: ");
            int estoque = Convert.ToInt32(Console.ReadLine());

            Produto produto = new Produto { Codigo = codigo, Nome = nome, Preco = preco, Estoque = estoque };
            produtos.Add(produto);

            Console.WriteLine("\nProduto cadastrado com sucesso!");
        }

    }
}