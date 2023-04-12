namespace L03P2Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 13. Elaborar um programa que apresente o somatório dos valores pares existentes 
                entre 1 e 500.  */
            int max = 500 , sum = 0;
            for (int i = 0; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"A somatória de números pares entre 1 e {max} é de: {sum}");
        }
    }
}