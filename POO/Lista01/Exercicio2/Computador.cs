using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Computador
    {
        public string marca, modelo;
        public int tipo;
        public double preco;

        public Computador()
        {
        }

        public Computador(string marca, string modelo, int tipo, double preco) 
        { 
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = tipo;
            this.preco = preco;
        }

        public void exibeDados()
        {
            Console.WriteLine($"Marca:{this.marca}");
            Console.WriteLine($"Modelo:{this.modelo}");
            Console.WriteLine($"Tipo:{this.tipo}");
            Console.WriteLine($"Preço: R${this.preco}");
            Console.WriteLine($"-----------------------------------------------");
        }
    }
}
