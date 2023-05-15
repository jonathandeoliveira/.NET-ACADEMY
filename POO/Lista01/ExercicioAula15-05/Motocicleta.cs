using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula15_05
{
    internal class Motocicleta : Veiculo
    {
        private double cilindrada;


        public double Cilindrada { get; set; }


        public void Dirigir()
        {
            Console.WriteLine($"Dirigindo um {this.marca} - {this.modelo} de {this.Cilindrada}  Cilidradas.");
        }
    }
}
