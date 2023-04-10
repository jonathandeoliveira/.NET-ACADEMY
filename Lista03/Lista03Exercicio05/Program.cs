using System.Security.Cryptography.X509Certificates;

namespace Lista03Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5 - Escreva um algoritmo para calcular o fatorial de um número. */
            int numero; int fatorial = 1;
            Console.WriteLine("Digite um número para saber seu fatorial");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1 ; i <= numero ; i++) {
                fatorial *= i;
            }
            Console.WriteLine($" O fatorial de {numero} é:{fatorial}");
        }
    }
}