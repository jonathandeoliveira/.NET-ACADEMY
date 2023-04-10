namespace Exercicio01For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Lista 03 1- Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade n pessoas, calcular a média de idade das n pessoas. */
            double n; double idade; double total_idades = 0;
            double media_idades;
            Console.WriteLine("Digite um número para o total de pessoas:");
            n = int.Parse(Console.ReadLine());

            for(int i = 1 ; i <= n; i++)
            {
                Console.WriteLine($"Digite a idade da pessoa {i}");
                idade = int.Parse(Console.ReadLine());
                total_idades += idade;
            }

            media_idades = (total_idades / n);
            Console.WriteLine($"A média de idade das {n} pessoas é: {media_idades}");
        }
    }
}