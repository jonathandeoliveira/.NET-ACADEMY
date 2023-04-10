namespace Lista03Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2 - Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor. */
            int n; int max = 0;
            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine($"Digite o número {i}: ");
                n = int.Parse(Console.ReadLine());
                if ( n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine($"O maior número digitado foi {max}");
        }
    }
}