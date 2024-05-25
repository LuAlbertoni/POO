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

        public Dependente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}