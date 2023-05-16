using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15_05
{
    internal class MotorCombustao : IMotor
    {
        public double combustivel;
        public bool ligado;

        public void Desligar()
        {
            if (ligado) { 
                ligado = false;
                Console.WriteLine("Motor a combustão desligado");
            }
            Console.WriteLine("Motor a combustão desligado");
        }

        public void Ligar()
        {
            if (combustivel>0 && !ligado)
            {
                ligado = true;
                Console.WriteLine("Motor a combustão ligado");

            }
            Console.WriteLine("Motor a combustão ligado");
        }
    }
}
