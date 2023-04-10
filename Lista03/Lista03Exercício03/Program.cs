namespace Lista03Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  3 - Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número
                    x lido utilizando laços de repetição, e mostre na tela. */

            Console.WriteLine("Digite um número para saber sua tabuada do 1 ao 10:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine('\n');
            for (int i = 1; i <= 10 ; i++) { 
                Console.WriteLine($"{i} x {n} = {i*n} ");
            }
        }
    }
}