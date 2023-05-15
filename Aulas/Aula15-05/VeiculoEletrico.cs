using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15_05
{
    internal class VeiculoEletrico : Veiculo
    {
        public double autonomia;

        public override void Ligar()
        {
            if (autonomia > 0)
            {
                Console.WriteLine("Carro elétrico ligado");
            }
            else
            {
                Console.WriteLine("Não foi possivel ligar. Sem bateria");
            }
        }

        public void Carregar()
        {
            this.autonomia += 10;
            Console.WriteLine("Carreguei 10%");
        }
    }

    }
}
