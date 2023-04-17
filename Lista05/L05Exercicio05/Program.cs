namespace L05Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5) Leia duas matrizes 2x3 de números double. 
                  Imprima a soma destas duas matrizes. */

            double[,] matriz1 = new double[2, 3];
            double[,] matriz2 = new double[2, 3];
            double[,] matriz_soma = new double[2, 3];
            Random random = new Random();

            // Gera matriz um //
            Console.WriteLine("Matriz Um:");
            for (int linha = 0; linha < matriz1.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz1.GetLength(1); col++)
                {
                    matriz1[linha, col] = random.Next(1, 10);
                    Console.Write(matriz1[linha, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------");
            // Gera matriz dois //
            Console.WriteLine("Matriz Dois:"); 
            for (int linha = 0; linha < matriz2.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz2.GetLength(1); col++)
                {
                    matriz2[linha, col] = random.Next(1, 10);
                    Console.Write(matriz2[linha, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------");
            // Calcula a matriz soma //
            for (int linha = 0; linha < matriz1.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz2.GetLength(1); col++)
                {
                    matriz_soma[linha, col] = matriz1[linha, col] + matriz2[linha, col];
                }
            }

            // Imprime matriz soma //
            Console.WriteLine("Matriz Soma:");
            for (int linha = 0; linha < matriz_soma.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz_soma.GetLength(1); col++)
                {
                    Console.Write(matriz_soma[linha, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}