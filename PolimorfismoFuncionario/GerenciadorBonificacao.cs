using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class GerenciadorBonificacao
    {
        private double TotaldeBonificacao;

        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            this.TotaldeBonificacao += funcionario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Secretario secretario)
        {
            this.TotaldeBonificacao += secretario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Gerente gerente)
        {
            this.TotaldeBonificacao += gerente.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Diretor diretor)
        {
            this.TotaldeBonificacao += diretor.CalcularBonificacao();
        }

        public double GetTotaldeBonificacao()
        {
            return this.TotaldeBonificacao;
        }
    }
}