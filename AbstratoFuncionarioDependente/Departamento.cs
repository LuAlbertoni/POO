using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            VetF = new List<Funcionario>();
        }

        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine($"\n=-=-=-=-=-= Listagem do departamento {Nome} =-=-=-=-=-=");
            foreach (Funcionario f in VetF)
            {
                f.Mostrar();
                f.ListarDependentes();
            }
        }

        public void Demitir(int codigo)
        {
            VetF.RemoveAll(f => f.Codigo == codigo);
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            foreach (Funcionario f in VetF)
            {
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }

        public void CalcularQuantidadeDependentes()
        {
            Console.WriteLine($"\nQuantidade de dependentes por funcionário no departamento {Nome}:");
            foreach (Funcionario f in VetF)
            {
                Console.WriteLine($"{f.Nome}: {f.TotalDependentes()}");
            }
        }
    }
}