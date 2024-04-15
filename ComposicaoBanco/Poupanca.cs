using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        private double Saldo { get; set; }

        public Poupanca(double saldoInicial)
        {
            if (saldoInicial < 0)
            {
                Console.WriteLine(
                    "Saldo inicial inválido. O saldo inicial deve ser maior ou igual a zero."
                );

                return;
            }

            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine(
                    "Valor inválido. O valor do depósito deve ser maior ou igual a zero."
                );
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:c} realizado com sucesso.");
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:c} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void GerarRendimento(double taxa)
        {
            Saldo *= 1 + (taxa / 100);
            Console.WriteLine($"Rendimento aplicado. Novo saldo: {Saldo:c}");
        }
    }
}
