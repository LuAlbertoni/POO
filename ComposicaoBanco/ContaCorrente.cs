using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private double Saldo { get; set; }
        private double ChequeEspecial { get; set; }

        public ContaCorrente(double saldoInicial, double limiteChequeEspecial)
        {
            Saldo = saldoInicial;
            ChequeEspecial = limiteChequeEspecial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:c} realizado com sucesso.");
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo + ChequeEspecial)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:c} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void GerarExtrato()
        {
            Console.WriteLine($"Saldo atual: {Saldo:c}");
        }
    }
}