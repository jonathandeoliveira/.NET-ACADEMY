using System;

namespace L05Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2) Solicite ao usuário, preencher uma Matriz 3x3 
             Informe ao usuário:
            *A soma dos elementos de cada linha
	            -Ex: Linha 1: 30
	                 Linha 2: 17
            *A soma dos elementos de cada coluna
	            -Ex: Coluna 1: 23
	                 Coluna 2: 36 */

            int[,] matriz = new int[3, 3];
            Random random = new Random();
            Console.WriteLine("Olá, digite 9 números para preencher uma matriz 3x3");
            Console.WriteLine("------------------");
            for (int linha = 0; linha < matriz.GetLength(0); linha++) 
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    matriz[linha, col] = random.Next(1, 10);
                    Console.Write(matriz[linha, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Soma dos elementos de cada linha:");
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                int soma_linha = 0;
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    soma_linha += matriz[linha, col];
                }
                Console.WriteLine($"Soma da linha: {linha + 1}: {soma_linha}");
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Soma dos elementos de cada coluna:");
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                int soma_coluna = 0;
                for (int linha = 0; linha < matriz.GetLength(1); linha++)
                {
                    soma_coluna += matriz[linha, coluna];
                }
                Console.WriteLine($"Soma da coluna:{coluna+1} {soma_coluna}");
            }
            Console.WriteLine("------------------");
        }
    }
}
