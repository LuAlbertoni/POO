using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionarioMensalistaHorista
{
    public class Horista : Funcionario
    {
        private int qtdeHorasSemana;

        public Horista(int codigo, string nome, double salario, int qtdeHorasSemana)
            : base(codigo, nome, salario)
        {
            this.qtdeHorasSemana = qtdeHorasSemana;
        }

        public int QtdeHorasSemana
        {
            get { return qtdeHorasSemana; }
            set { qtdeHorasSemana = value; }
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Quantidade de Horas por Semana: {qtdeHorasSemana}");
        }
    }
}
