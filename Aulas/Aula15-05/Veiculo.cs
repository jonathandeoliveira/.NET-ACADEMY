using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15_05
{
    internal class Veiculo
    {
        public string modelo;
        public double potencia;

        public virtual void Ligar()
        {
            Console.WriteLine("Oi, sou o Veiculo ligado!");
        }
    }
}
