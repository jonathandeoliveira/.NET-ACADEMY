using System.Net;

namespace L03P2Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 12.Apresentar o total da soma dos cem primeiros números inteiros. */
            double num, count = 100, soma = 0;
            while (count != 0)
            {
                Console.WriteLine("Digite um número");
                num = double.Parse(Console.ReadLine());
                count--;
                soma += num;
            }
            Console.WriteLine($"A soma dos {count} valores digitados é de: {soma}");
        }
    }
}