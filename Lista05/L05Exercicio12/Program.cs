using System.Runtime.Intrinsics.X86;

namespace L05Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices(i + j) seja um número par.*/

            double[,] matrizA = new double[4, 3];
            double[,] matrizB = new double[4, 3];
            Random random = new Random();

            // Gera matriz A //
            Console.WriteLine("Matriz Gerada:");
            for (int linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for (int col = 0; col < matrizA.GetLength(1); col++)
                {
                    matrizA[linha, col] = random.Next(1, 21);
                    Console.Write(matrizA[linha, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------\n");

            // percorrendo a matriz A  e populando a matriz B //
            Console.WriteLine("Matriz Resultante:");
            for (int linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for (int col = 0; col < matrizA.GetLength(1); col++)
                {
                    matrizB[linha, col] = (matrizA[linha, col] / (linha + col));
                    if (matrizB[linha,])
                    Console.Write(matrizB[linha, col].ToString("F2") + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}