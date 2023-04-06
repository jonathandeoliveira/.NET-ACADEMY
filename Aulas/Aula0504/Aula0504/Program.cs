using static System.Net.Mime.MediaTypeNames;

namespace Aula0504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo para ler quatro valores, calcular a sua média, e escrever na tela os que são superiores à média.
            Console.WriteLine("Digite quatro números");
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            float n3 = float.Parse(Console.ReadLine());
            float n4 = float.Parse(Console.ReadLine());
            float media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine($"A média dos valores digatados é de: {media} ");
            if (n1 > media)
            {
                Console.WriteLine($"O valor {n1} está acima da média ");
            }
            if (n2 > media)
            {
                Console.WriteLine($"O valor {n2} está acima da média ");
            }
            if (n3 > media)
            {
                Console.WriteLine($"O valor {n3} está acima da média ");
            }
            if (n4 > media)
            {
                Console.WriteLine($"O valor {n4} está acima da média ");
            }
        }
    }
}