namespace L04Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2. Escreva um algoritmo que leia valores para dois vetores de 20 elementos e 
              então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor. */

            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];
            int[] vetor3 = new int[20];
            int odd = 0, even = 0;

            Random random = new Random();
            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = random.Next(1, 101);
                Console.WriteLine($"Valor da posição {i + 1} do vetor 1 é de {vetor1[i]}");
            }
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < vetor2.Length; i++)
            {
                vetor2[i] = random.Next(1, 101);
                Console.WriteLine($"Valor da posição {i + 1} do vetor 2 é de {vetor2[i]}");
            }
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < vetor3.Length; i++)
            {
                vetor3[i] = vetor1[i] + vetor2[i];
                Console.WriteLine($"Valor da soma das posições {i + 1} do vetor1 e vetor2 é de {vetor3[i]}");
            }

        }
    }
}