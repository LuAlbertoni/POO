using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        private double verba;

        public double Verba
        {
            get { return verba; }
            set
            {
                if (value >= 0)
                    verba = value;
                else
                    Console.WriteLine("A verba do comprador não pode ser negativa.");
            }
        }

        public Comprador(double verba)
        {
            this.verba = verba;
        }

        public void MostrarAtributo()
        {
            Console.WriteLine($"Verba do comprador: {verba:c}");
        }
    }
}
