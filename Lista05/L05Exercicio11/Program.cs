namespace L05Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices. */

            double[,] matrizA = new double[3, 3];
            double[,] matrizB = new double[3, 3];
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
                    Console.Write(matrizB[linha, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}