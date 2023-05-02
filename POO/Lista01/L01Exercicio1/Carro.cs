using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01Exercicio1
{
    internal class Carro
    {
        public string marca, modelo;
        public int anoFabricacao;
  


        public void exibeDados()
        {
            Console.WriteLine($"Dados do carro:");
            Console.WriteLine($"Marca:{this.marca}");
            Console.WriteLine($"Modelo:{this.marca}");
            Console.WriteLine($"Ano de Fabricação:{this.marca}");
            Console.WriteLine($"-----------------------------------------------");
        }
    }
}
