namespace L05Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-99. Após isso determine o maior número da matriz. */

            int[,] matriz = new int[4, 4];
            int maior = 1;
            Random random = new Random();
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    matriz[linha, col] = random.Next(0, 99);
                    Console.Write(matriz[linha, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------");

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    if (matriz[linha,col] > maior){ maior = matriz[linha,col]; }
                }
            }
            Console.WriteLine($"O maior número gerado pela matriz foi:{maior}");
        }
    }
}