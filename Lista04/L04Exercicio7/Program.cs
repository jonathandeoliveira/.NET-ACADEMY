using System;

namespace L04Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
                    a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
                    b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|  */

            int[] vetor = new int[10];
            int[] vetor_ordenado = new int[10];
            int conta_par = 0,conta_impar = 0;
            Random random = new Random();
            Console.WriteLine("Vetor inicial:");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 101);
                Console.Write($"|{vetor[i]}|");
                if (vetor[i] % 2 == 0) {
                    vetor_ordenado[conta_par] = vetor[i];
                    conta_par++;
                }
                else
                {
                    vetor_ordenado[(vetor_ordenado.Length - 1) - conta_impar ] = vetor[i];
                    conta_impar++;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Vetor ordenado:");
            for (int i = 0; i < vetor_ordenado.Length; i++)
            {
                Console.Write($"|{vetor_ordenado[i]}|");
            }
            Console.WriteLine(" ");
        }
    }
}