using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Dependente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Codigo { get; private set; }

        public Dependente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public bool VerificarMaioridade()
        {
            return Idade >= 18;
        }
    }
}