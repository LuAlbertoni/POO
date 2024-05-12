using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionarioMensalistaHorista
{
    public class Funcionario
    {
        protected int codigo;
        protected string? nome;
        protected double salario;

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {codigo}. Nome: {nome}. Salário: {salario}");
        }
    }
}
