namespace L05Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  4) Popule uma matriz 5x5 e informe:
                -Quantos números são pares
                -Quantos números são impares
                -Quantos números são positivos
                -Quantos números são negativos
                -Quantos zeros existem!  */

            int[,] matriz = new int[5, 5];
            int odd = 0, even = 0, positive = 0, negative = 0, zero = 0 ;
            Random random = new Random();
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    matriz[linha, col] = random.Next(-20, 21);
                    Console.Write(matriz[linha, col] + "\t");
                }
                Console.WriteLine();
            }
            for (int linha = 0; linha < matriz.GetLength(0); linha++) 
            { 
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    if (matriz[linha, col] % 2 == 0)
                    {
                        even++;
                        if (matriz[linha, col] > 0){ positive++;}
                        if (matriz[linha, col] < 0){ negative++; }
                    }
                    if(matriz[linha, col] % 2 != 0) { 
                        odd++;
                        if (matriz[linha, col] > 0){positive++;}
                        if (matriz[linha, col] < 0) { negative++; }
                    }
                    if (matriz[linha, col] == 0) { zero++; }
                }
            }
            Console.WriteLine($"A quantidade de numeros impares é de:{odd}");
            Console.WriteLine($"A quantidade de numeros pares é de:{even}");
            Console.WriteLine($"A quantidade de numeros positivos é de:{positive}");
            Console.WriteLine($"A quantidade de numeros negativos é de:{negative}");
            Console.WriteLine($"A quantidade de numeros zero é de:{zero}");
        }
    } 
}
