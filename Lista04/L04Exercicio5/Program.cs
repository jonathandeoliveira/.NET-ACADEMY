namespace L04Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição. */

            int[] vetor = new int[80];
            int position,min;

            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 201);
                Console.WriteLine($"Valor da posição {i + 1} do vetor 1 é de {vetor[i]}");
            }
            Console.WriteLine("----------------------------------");
            min = vetor.Min();
            position = Array.IndexOf(vetor, min);
            Console.WriteLine($"O menor valor do vetor é de {min}, na posição:{position+1}");

        }
    }
}