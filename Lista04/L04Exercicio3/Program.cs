using System;

namespace L04Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos e 
              então mostre na tela o índice da posição dos valores correspondentes a números primos. */

            int[] vetor = new int[20];

            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 101);
                Console.WriteLine($"Valor da posição {i + 1} é de {vetor[i]}");
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0 && vetor[i] % 3 != 0 && vetor[i] % 5 != 0 && vetor[i] % 7 != 0 && vetor[i] % vetor[i] == 0 ) {
                    Console.WriteLine($"o índice {i} do vetor é um número primo com o valor de {vetor[i]} "); ; 
                }
            }
            

        }
    }
}