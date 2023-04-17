namespace L05Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
                Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”. */

            int[,] matriz = new int[3, 3];
            int existe = 0;
            Random random = new Random();

            // Gera matriz //
            Console.WriteLine("Matriz Gerada:");
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    matriz[linha, col] = random.Next(1, 10);
                    Console.Write(matriz[linha, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------\n");

            Console.WriteLine("Digite um número:");
            int num = int.Parse(Console.ReadLine());

            for (int linha = 0; linha < matriz.GetLength(0); linha++) 
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    if (matriz[linha,col] == num)
                    {
                        existe++;
                        Console.WriteLine($"Número encontrado na posição:{col} da linha: {linha}");
                    }
                }
            }
            Console.WriteLine("------------------\n");
            if (existe == 0) { Console.WriteLine("Número não encontrado na matriz"); }
        }
    }
}