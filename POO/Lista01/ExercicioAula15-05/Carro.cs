using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula15_05
{
    internal class Carro : Veiculo
    {
        public int QuantidadeDePortas;

        public virtual void Dirigir()
        {
            Console.WriteLine($"Dirigindo um {this.marca} - {this.modelo} de {this.QuantidadeDePortas} portas.");
        }


    }
}
