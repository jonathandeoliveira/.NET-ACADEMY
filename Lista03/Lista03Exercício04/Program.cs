namespace Lista03Exercício04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4 - Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
                    elevado na y sem utilizar a função pow. */
            int x; int y; int result = 1;
            Console.WriteLine("Digite um número base:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua potência:");
            y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= y; i++)
            {
                result *= x;
            }
            Console.WriteLine($"O resultado número {x} elevado a {y} é: {result}");
        }
    }
}