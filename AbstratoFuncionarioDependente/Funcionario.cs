using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public List<Dependente> Dependentes { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Dependentes = new List<Dependente>();
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"\nCódigo: {Codigo}, Nome: {Nome}, Salário: {Salario}");
        }

        public abstract double CalcularSalario(int diasUteis);

        public int TotalDependentes()
        {
            return Dependentes.Count;
        }

        public void AdicionarDependente(Dependente dependente)
        {
            if (dependente.VerificarMaioridade() == false)
                Dependentes.Add(dependente);
            else
                Console.WriteLine("O dependente não pôde ser adicionado");
        }

        public void RemoverDependente(string nome)
        {
            Dependentes.RemoveAll(d => d.Nome == nome);
        }

        public void ListarDependentes()
        {
            Console.WriteLine($"Dependentes de {Nome}:");
            foreach (var dependente in Dependentes)
            {
                Console.WriteLine($"Nome: {dependente.Nome}, Idade: {dependente.Idade}");
            }
        }
    }
}