using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        public ContaCorrente[] contasCorrente;
        public Poupanca[] poupancas;
        private int numContasCorrente;
        private int numPoupancas;

        public Banco(int maxContasCorrente, int maxPoupancas)
        {
            contasCorrente = new ContaCorrente[maxContasCorrente];
            poupancas = new Poupanca[maxPoupancas];
            numContasCorrente = 0;
            numPoupancas = 0;
        }

        public void AbrirContaCorrente(double saldoInicial, double limiteChequeEspecial)
        {
            if (numContasCorrente < contasCorrente.Length)
            {
                contasCorrente[numContasCorrente] = new ContaCorrente(
                    saldoInicial,
                    limiteChequeEspecial
                );
                numContasCorrente++;
                Console.WriteLine("Conta corrente aberta com sucesso.");
            }
            else
            {
                Console.WriteLine("Limite máximo de contas correntes atingido.");
            }
        }

        public void AbrirPoupanca(double saldoInicial)
        {
            if (numPoupancas < poupancas.Length)
            {
                poupancas[numPoupancas] = new Poupanca(saldoInicial);
                numPoupancas++;
                Console.WriteLine("Conta poupança aberta com sucesso.");
            }
            else
            {
                Console.WriteLine("Limite máximo de contas poupança atingido.");
            }
        }

        public void DecretarFalencia()
        {
            Console.WriteLine("\nO banco decretou falência.");
            contasCorrente = null;
            poupancas = null;
            numContasCorrente = 0;
            numPoupancas = 0;
        }
    }
}
