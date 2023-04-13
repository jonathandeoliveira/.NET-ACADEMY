namespace L04Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice,
               colocando o resultado em um terceiro vetor. Mostre o vetor resultante. */

            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[10];

            Random random = new Random();
            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = random.Next(1, 11);
                Console.WriteLine($"Valor da posição {i + 1} do vetor 1 é de {vetor1[i]}");
            }
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < vetor2.Length; i++)
            {
                vetor2[i] = random.Next(1, 11);
                Console.WriteLine($"Valor da posição {i + 1} do vetor 2 é de {vetor2[i]}");
            }
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < vetor3.Length; i++)
            {
                vetor3[i] = vetor1[i] * vetor2[i];
                Console.WriteLine($"Valor da multiplicação das posições {i + 1} do vetor1 e vetor2 é de {vetor3[i]}");
            }

        }
    }
}