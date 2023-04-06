using System.Runtime.Intrinsics.X86;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            //forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes. 
            Console.Write("Digite a data no formato DDMMAAAA: ");
            string date = Console.ReadLine();
            int day = int.Parse(date.Substring(0, 2));
            int month = int.Parse(date.Substring(2, 2));
            int year = int.Parse(date.Substring(4, 4));
            int year2digits = int.Parse(date.Substring(6, 2));
            string data1 = $"{year}/{month}/{day}";
            string data2 = $"{year2digits}/{month}/{day}";
            Console.Write($"A data no formato AAAA/MM/DD é:{data1}\n\n");
            Console.Write($"A data no formato AA/MM/DD é:{data2}\n\n");
        }
    }
}