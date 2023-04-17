namespace L05Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal! 
              0,0       0,1       0,2       0,3
              1,0       1,1       1,2       1,3
              2,0       2,1       2,2       2,3
              3,0       3,1       3,2       3,3  */

            int[,] matriz = new int[4, 4];
            Random random = new Random();
            int[] dp = new int[4];

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    matriz[linha, col] = random.Next(1, 10);
                    Console.Write(matriz[linha, col] + "\t");
                }
                Console.WriteLine();

            }
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    if(linha == col){
                        dp[linha] = matriz[linha, col];
                    }
                }

            }
            Console.WriteLine("A matriz principal é:");
            for (int i = 0; i < dp.Length; i++)
            {
                Console.Write($"|{dp[i]}|");
            }
            Console.WriteLine(" ");
        }
    }
}