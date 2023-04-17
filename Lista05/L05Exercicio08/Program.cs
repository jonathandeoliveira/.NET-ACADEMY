namespace L05Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.*/

            int[,] matriz = new int[4,4];
            Random random = new Random();

            Console.WriteLine("Matriz gerada:");
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


            Console.WriteLine("Matriz Invertida:");

            for (int linha = matriz.GetLength(0) -1 ; linha >=0; linha--)
            {
                for (int col = matriz.GetLength(1) -1; col >=0; col--)
                {
                    Console.Write(matriz[linha, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}