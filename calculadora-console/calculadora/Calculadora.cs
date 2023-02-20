using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class Calculadora
    {
        public Calculadora(int numeroUm, int numeroDois)
        {
            NumeroUm = numeroUm;
            NumeroDois = numeroDois;
        }

        private protected int NumeroUm { get; set; }
        private protected int NumeroDois { get; set; }

    }
}
