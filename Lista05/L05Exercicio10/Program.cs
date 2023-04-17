namespace L05Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média. */

            double[,] matriz1 = new double[4, 4];
            double[,] matriz2 = new double[4, 4];
            double soma1 = 0 , soma2 = 0;
            double media1, media2;
            int acima1 = 0, acima2 = 0, abaixo1 =0, abaixo2 = 0;
            Random random = new Random();

            // Gera matriz um //
            Console.WriteLine("Matriz Um:");
            for (int linha = 0; linha < matriz1.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz1.GetLength(1); col++)
                {
                    matriz1[linha, col] = random.Next(0, 81);
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
                    matriz2[linha, col] = random.Next(0, 81);
                    Console.Write(matriz2[linha, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------");
            // calcula médias //
            for (int linha = 0; linha < matriz1.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz1.GetLength(1); col++) 
                {
                    soma1 += matriz1[linha, col];
                }
            }
            for (int linha = 0; linha < matriz2.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz2.GetLength(1); col++)
                {
                    soma2 += matriz2[linha, col];
                }
            }
            media1 = soma1 / (matriz1.GetLength(0) * matriz1.GetLength(1));
            media2 = soma2 / (matriz2.GetLength(0) * matriz2.GetLength(1));

            //calcula qtd de numeros acima e abaixo
            for (int linha = 0; linha < matriz1.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz1.GetLength(1); col++)
                {
                    if (matriz1[linha, col] >= media1) { acima1++; }
                    else { abaixo1++; }
                }
            }
            for (int linha = 0; linha < matriz2.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz2.GetLength(1); col++)
                {
                    if (matriz2[linha, col] >= media1) { acima2++; }
                    else { abaixo2++; }
                }
            }

            // exibe resultados
            Console.WriteLine($"A média da matriz um é de: {media1}");
            Console.WriteLine($"A quantidade de números acima da média na matriz um é de:{acima1}");
            Console.WriteLine($"A quantidade de números abaixo da média na matriz um é de:{abaixo1}");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"A média da matriz dois é de: {media2}");
            Console.WriteLine($"A quantidade de números acima da média na matriz um é de:{acima2}");
            Console.WriteLine($"A quantidade de números abaixo da média na matriz um é de:{abaixo2}");


        }
    }
}