using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionarioMensalistaHorista
{
    public class Mensalista : Funcionario
    {
        private int qtdeHorasTrabalhadas;

        public Mensalista(int codigo, string nome, double salario, int qtdeHorasTrabalhadas)
            : base(codigo, nome, salario)
        {
            this.qtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
        }

        public int QtdeHorasTrabalhadas
        {
            get { return qtdeHorasTrabalhadas; }
            set { qtdeHorasTrabalhadas = value; }
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Quantidade de Horas Trabalhadas: {qtdeHorasTrabalhadas}");
        }
    }
}
