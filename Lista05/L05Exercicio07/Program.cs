namespace L05Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.  */


            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];
            int[,] matrizC = new int[3, 3];
            Random random = new Random();

            // Gera matriz A //
            Console.WriteLine("Matriz Um:");
            for (int linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for (int col = 0; col < matrizA.GetLength(1); col++)
                {
                    matrizA[linha, col] = random.Next(0, 21);
                    Console.Write(matrizA[linha, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------");
            // Gera matriz B //
            Console.WriteLine("Matriz Dois:");
            for (int linha = 0; linha < matrizB.GetLength(0); linha++)
            {
                for (int col = 0; col < matrizB.GetLength(1); col++)
                {
                    matrizB[linha, col] = random.Next(1, 10);
                    Console.Write(matrizB[linha, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------");
            // Calcula a matriz C //
            for (int linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for (int col = 0; col < matrizB.GetLength(1); col++)
                {
                    matrizC[linha, col] = matrizA[linha, col] - matrizB[linha, col];
                }
            }

            // Imprime matriz C //
            Console.WriteLine("Matriz C:");
            for (int linha = 0; linha < matrizC.GetLength(0); linha++)
            {
                for (int col = 0; col < matrizC.GetLength(1); col++)
                {
                    Console.Write(matrizC[linha, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}