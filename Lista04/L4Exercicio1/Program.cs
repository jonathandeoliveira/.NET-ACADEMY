namespace L4Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares. */

            int[] vetor = new int[10];
            int odd = 0, even = 0;

            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1,101);
                Console.WriteLine($"Valor da posição {i+1} é de {vetor[i]}");
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0) { even++; }
                else { odd++; }
            }
            Console.WriteLine($"A quantidade de números pares é de: {even}");
            Console.WriteLine($"A quantidade de números impares é de: {odd}");

        }
    }
}