using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private static long proxMatricula = 1570482410000;

        private long Matricula { get; }
        public string? Nome { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        private double Media;

        private double CalcularMedia()
        {
            return (P1 + P2) / 2;
        }

        public void MostrarAtributos()
        {
            Media = CalcularMedia();

            Console.WriteLine(
                $"Matrícula: {Matricula}\nNome: {Nome}\nP1: {P1}\nP2: {P2}\nMédia: {Media}\n"
            );
        }

        public Aluno()
        {
            Matricula = proxMatricula++;
        }
    }
}
