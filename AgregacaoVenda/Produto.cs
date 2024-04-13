using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private static int proximoCodigo = 500;
        public int Codigo { get; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Codigo = proximoCodigo++;
            Nome = nome;

            if (preco > 0)
                Preco = preco;
            else
                Console.WriteLine("O preço do produto deve ser maior que zero.");
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}, Nome: {Nome}, Preço: {Preco:c}");
        }
    }
}
