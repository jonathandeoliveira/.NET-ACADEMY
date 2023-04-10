namespace ExemploFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* •Escreva um algoritmo leia pelo teclado os dois valores inteiros chamados inicio e fim, e então mostre todos os números entre inicio e fim. */

            int inicio; int fim;
            Console.WriteLine("Digite um valor para inicio");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para fim");
            fim = int.Parse(Console.ReadLine());
            if (inicio > fim)
            {
                for (int i = inicio; i >= fim; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else if (inicio < fim)
            {
                for (int i = inicio; i <= fim; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}